using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Models
{
    /// <summary>
    /// This class holds the discount result. This class has been designed keeping in mind
    /// for future extension where errors can be logged to a repository (file, database etc.,)
    /// </summary>
    public class DiscountResult
    {
        /// <summary>
        /// Discounted bill amount
        /// </summary>
        double discountedBillAmount;

        /// <summary>
        /// Whether there was success in calculating discount
        /// </summary>
        bool success;

        /// <summary>
        /// Any message which needs to be sent with the result
        /// </summary>
        String message;

        /// <summary>
        /// Getter and setter for discounted bill amount
        /// </summary>
        public double DiscountedBillAmount
        {
            get { return discountedBillAmount; }
            set { discountedBillAmount = value; }
        }

        /// <summary>
        /// Getter and setter for any message associated with the result
        /// </summary>
        public String Message
        {
            get { return message; }
            set { message = value; }
        }

        /// <summary>
        /// Getter and setter for the result state
        /// </summary>
        public bool Success
        {
            get { return success; }
            set { success = value; }
        }
    }
}
