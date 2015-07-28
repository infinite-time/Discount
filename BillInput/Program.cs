using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discount;
using Discount.Models;

namespace BillInput
{
    /// <summary>
    /// Driver class which tests the results the discount component.
    /// Discount is implemented as a separated dll so that it can be referenced and used by any consumer.
    /// Here the test class is the consumer. Note that NUnit is not used as the system on which this is run would
    /// need NUnit installation.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Basic test case for employee
            {
                Console.WriteLine();
                String userIDString = "EMP" + "1234556789";
                Bill bill = new Bill(System.Guid.NewGuid(), userIDString, 2000);
                IUser user = UserFactory.GiveUser(userIDString);
                if(user != null)
                {
                    UserData userData = new UserData(userIDString, "ABC");
                    user.SetUserData(userData);
                    user.SetBill(bill);
                    DiscountResult result = user.CalculateDiscountAmount();
                    Console.WriteLine("User ID = " + userIDString + ", " + "Bill Amount = " + bill.BillAmount + ", " + "Discounted bill = " + result.DiscountedBillAmount);
                    if (!result.Success)
                    {
                        Console.WriteLine(result.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Unknown user with ID " + userIDString);
                }
                
            }

            // Basic test case for customer
            {
                Console.WriteLine();
                String userIDString = "CUST" + "1234556789";
                Bill bill = new Bill(System.Guid.NewGuid(), userIDString, 2000);
                IUser user = UserFactory.GiveUser(userIDString);
                if (user != null)
                {
                    UserData userData = new UserData(userIDString, "ABC");
                    user.SetUserData(userData);
                    user.SetAssociatedYears(4);
                    user.SetBill(bill);
                    DiscountResult result = user.CalculateDiscountAmount();
                    Console.WriteLine("User ID = " + userIDString + ", " + "Bill Amount = " + bill.BillAmount + ", " + "Discounted bill = " + result.DiscountedBillAmount);
                    if (!result.Success)
                    {
                        Console.WriteLine(result.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Unknown user with ID " + userIDString);
                }
            }

            // Basic test case for affiliate
            {
                Console.WriteLine();
                String userIDString = "AFF" + "1234556789";
                Bill bill = new Bill(System.Guid.NewGuid(), userIDString, 2000);
                IUser user = UserFactory.GiveUser(userIDString);
                if (user != null)
                {
                    UserData userData = new UserData(userIDString, "ABC");
                    user.SetUserData(userData);
                    user.SetBill(bill);
                    DiscountResult result = user.CalculateDiscountAmount();
                    Console.WriteLine("User ID = " + userIDString + ", " + "Bill Amount = " + bill.BillAmount + ", " + "Discounted bill = " + result.DiscountedBillAmount);
                    if (!result.Success)
                    {
                        Console.WriteLine(result.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Unknown user with ID " + userIDString);
                }
            }

            // Test case for unknown user
            {
                Console.WriteLine();
                String userIDString = "ABB" + "1234556789";
                Bill bill = new Bill(System.Guid.NewGuid(), userIDString, 2000);
                IUser user = UserFactory.GiveUser(userIDString);
                if (user != null)
                {
                    UserData userData = new UserData(userIDString, "ABC");
                    user.SetUserData(userData);
                    user.SetBill(bill);
                    DiscountResult result = user.CalculateDiscountAmount();
                    Console.WriteLine("User ID = " + userIDString + ", " + "Bill Amount = " + bill.BillAmount + ", " + "Discounted bill = " + result.DiscountedBillAmount);
                    if (!result.Success)
                    {
                        Console.WriteLine(result.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Unknown user with ID " + userIDString);
                }
            }

            // Test case for negative bill value
            {
                Console.WriteLine();
                String userIDString = "EMP" + "1234556789";
                Bill bill = new Bill(System.Guid.NewGuid(), userIDString, -2000);
                IUser user = UserFactory.GiveUser(userIDString);
                if (user != null)
                {
                    UserData userData = new UserData(userIDString, "ABC");
                    user.SetUserData(userData);
                    user.SetBill(bill);
                    DiscountResult result = user.CalculateDiscountAmount();
                    Console.WriteLine("User ID = " + userIDString + ", " + "Bill Amount = " + bill.BillAmount + ", " + "Discounted bill = " + result.DiscountedBillAmount);
                    if(!result.Success)
                    {
                        Console.WriteLine(result.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Unknown user with ID " + userIDString);
                }
            }

            // Test case for customer who is associated for less than 2 years
            {
                Console.WriteLine();
                String userIDString = "CUST" + "1234556789";
                Bill bill = new Bill(System.Guid.NewGuid(), userIDString, 2000);
                IUser user = UserFactory.GiveUser(userIDString);
                if (user != null)
                {
                    UserData userData = new UserData(userIDString, "ABC");
                    user.SetUserData(userData);
                    user.SetAssociatedYears(1);
                    user.SetBill(bill);
                    DiscountResult result = user.CalculateDiscountAmount();
                    Console.WriteLine("User ID = " + userIDString + ", " + "Bill Amount = " + bill.BillAmount + ", " + "Discounted bill = " + result.DiscountedBillAmount);
                    if (!result.Success)
                    {
                        Console.WriteLine(result.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Unknown user with ID " + userIDString);
                }
            }

            Console.ReadLine();
        }
    }
}
