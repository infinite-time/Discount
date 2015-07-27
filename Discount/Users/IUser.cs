using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    public interface IUser
    {
        double CalculateDiscountAmount();
        void SetUserData(UserData userData);
        UserData GetUserData();
        void SetBill(Bill bill);
    }
}
