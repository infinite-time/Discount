using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discount;

namespace BillInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic test case for employee
            {
                String userIDString = "EMP" + "1234556789";
                Bill bill = new Bill(System.Guid.NewGuid(), userIDString, 2000);
                IUser user = UserFactory.GiveUser(userIDString);
                UserData userData = new UserData(userIDString, "ABC");
                user.SetUserData(userData);
                user.SetBill(bill);
                double discountedAmount = user.CalculateDiscountAmount();
            }

            // Basic test case for customer
            {
                String userIDString = "CUST" + "1234556789";
                Bill bill = new Bill(System.Guid.NewGuid(), userIDString, 2000);
                IUser user = UserFactory.GiveUser(userIDString);
                UserData userData = new UserData(userIDString, "ABC");
                user.SetUserData(userData);
                user.SetBill(bill);
                double discountedAmount = user.CalculateDiscountAmount();
            }

            // Basic test case for affiliate
            {
                String userIDString = "AFF" + "1234556789";
                Bill bill = new Bill(System.Guid.NewGuid(), userIDString, 2000);
                IUser user = UserFactory.GiveUser(userIDString);
                UserData userData = new UserData(userIDString, "ABC");
                user.SetUserData(userData);
                user.SetBill(bill);
                double discountedAmount = user.CalculateDiscountAmount();
            }
        }
    }
}
