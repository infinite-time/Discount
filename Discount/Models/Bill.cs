using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    public class Bill
    {
        String userId;
        Guid billId;
        double billAmount;

        public Bill(Guid billId, String userId, double billAmount)
        {
            this.userId = userId;
            this.billId = billId;
            this.billAmount = billAmount;
        }
                    
        public String UserId
        {
            get { return userId; }
        }
        public Guid BillId
        {
            get { return billId; }
        }
        

        public double BillAmount
        {
            get { return billAmount; }
        }
    }
}
