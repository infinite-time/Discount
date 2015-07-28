using Discount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    class Customer : IUser
    {
        /// <summary>
        /// User related data
        /// </summary>
        UserData userData;

        /// <summary>
        /// Reader to load discount related data
        /// </summary>
        int associatedSinceYears;

        /// <summary>
        /// Bill made by the user
        /// </summary>
        Bill bill;

        /// <summary>
        /// Calculate the discount applicable to the user
        /// </summary>
        /// <returns>Returns the discount result</returns>
        public DiscountResult CalculateDiscountAmount()
        {
            DiscountResult result = new DiscountResult();
            DiscountReader reader = new DiscountReader(this);
            int percentageDiscount = reader.FindDiscount();
            double initialBillAmount = bill.BillAmount;

            // Validate the bill amount before proceeding
            if (initialBillAmount <= 0)
            {
                result.DiscountedBillAmount = initialBillAmount;
                result.Success = false;
                result.Message = "Invalid bill amount";
                return result;
            }

            double discountedAmount = bill.BillAmount - (bill.BillAmount / 100) * percentageDiscount;

            if (bill.BillAmount >= 100)
            {
                double generalDiscount = reader.FindGeneralDiscount();
                generalDiscount = (generalDiscount / 100.0) * bill.BillAmount;
                discountedAmount -= generalDiscount;
            }

            result.DiscountedBillAmount = discountedAmount;
            if (initialBillAmount == result.DiscountedBillAmount)
            {
                result.Message = "No discount applied";
                result.Success = false;
            }
            else
            {
                result.Message = "Discount applied";
                result.Success = true;
            }

            return result;
        }

        /// <summary>
        /// Set user data
        /// </summary>
        /// <param name="userData"></param>
        public void SetUserData(UserData userData)
        {
            this.userData = userData;
        }

        /// <summary>
        /// Getter and setter for associated years
        /// </summary>
        public int AssociatedSinceYears
        {
            get { return associatedSinceYears; }
            set { associatedSinceYears = value; }
        }

        /// <summary>
        /// Set the bill
        /// </summary>
        /// <param name="bill">Bill</param>
        public void SetBill(Bill bill)
        {
            this.bill = bill;
        }

        /// <summary>
        /// Set the association of the customer in terms of years
        /// </summary>
        /// <param name="years"></param>
        public void SetAssociatedYears(int years)
        {
            associatedSinceYears = years;
        }
    }
}
