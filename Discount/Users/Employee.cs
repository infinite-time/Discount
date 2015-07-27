using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    class Employee : IUser
    {
        UserData userData;
        DiscountReader reader;
        Bill bill;

        public double CalculateDiscountAmount()
        {
            DiscountReader reader = new DiscountReader(this);
            int percentageDiscount = reader.FindDiscount();

            double discountedAmount = bill.BillAmount - (bill.BillAmount / 100) * percentageDiscount;

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
