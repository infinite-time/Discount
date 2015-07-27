using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    class Customer : IUser
    {
        UserData userData;
        int associatedSinceYears;
        Bill bill;

        public double CalculateDiscountAmount()
        {
            DiscountReader reader = new DiscountReader(this);
            int percentageDiscount = reader.FindDiscount();

            double discountedAmount = bill.BillAmount;

            if (bill.BillAmount >= 100)
            {
                double generalDiscount = reader.FindGeneralDiscount();
                generalDiscount = (generalDiscount / 100.0) * bill.BillAmount;
                discountedAmount -= generalDiscount;
            }

            return discountedAmount;
        }

        public void SetUserData(UserData userData)
        {
            this.userData = userData;
        }

        public int AssociatedSinceYears
        {
            get { return associatedSinceYears; }
            set { associatedSinceYears = value; }
        }


        public UserData GetUserData()
        {
            throw new NotImplementedException();
        }

        public void SetBill(Bill bill)
        {
            this.bill = bill;
        }
    }
}
