using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    public static class UserFactory
    {
        public static IUser GiveUser(String userId)
        {
            IUser user = null;

            if(userId.StartsWith("EMP"))
            {
                user = new Employee();
            }
            else if (userId.StartsWith("AFF"))
            {
                user = new Affiliate();
            }
            else if (userId.StartsWith("CUST"))
            {
                user = new Customer();
            }

            return user;
        }
    }
}
