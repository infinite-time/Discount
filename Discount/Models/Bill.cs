using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    /// <summary>
    /// This class is used to store data related to Bill
    /// </summary>
    public class Bill
    {
        // User ID which is unique to the user
        String userId;
        // Bill ID which is unique for each bill
        Guid billId;
        // Total amount of the bill
        double billAmount;

        /// <summary>
        /// Constructor which creates a Bill object with all the required parameters
        /// </summary>
        /// <param name="billId">Unique ID of the bill</param>
        /// <param name="userId">Unique ID of the user</param>
        /// <param name="billAmount">Total amount of the bill</param>
        public Bill(Guid billId, String userId, double billAmount)
        {
            this.userId = userId;
            this.billId = billId;
            this.billAmount = billAmount;
        }
         
        /// <summary>
        /// Returns user Id. Set is allowed only through constructor to prevent any
        /// unexpected changes after creating the object.
        /// </summary>   
        public String UserId
        {
            get { return userId; }
        }

        /// <summary>
        /// Returns bill Id. Set is allowed only through constructor to prevent any
        /// unexpected changes after creating the object.
        /// </summary> 
        public Guid BillId
        {
            get { return billId; }
        }

        /// <summary>
        /// Returns bill amount. Set is allowed only through constructor to prevent any
        /// unexpected changes after creating the object.
        /// </summary> 
        public double BillAmount
        {
            get { return billAmount; }
        }
    }
}
