using Discount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    /// <summary>
    /// Interface which defines the minimum required behaviors by the users
    /// </summary>
    public interface IUser
    {
        // Calculate the discount amount applicable
        DiscountResult CalculateDiscountAmount();

        // Set data related to the user
        void SetUserData(UserData userData);

        // Set the bill for the user
        void SetBill(Bill bill);

        // Set the number of years the user is associated with the organization if applicable
        void SetAssociatedYears(int years);
    }
}
