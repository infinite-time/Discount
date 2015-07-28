using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    /// <summary>
    /// Factory which creates and returns the user object
    /// </summary>
    public static class UserFactory
    {
        /// <summary>
        /// Based on the user ID, specific user object is created by this factory.
        /// The consumer of this class need not have knowledge of the user specific classes.
        /// Consumer user the IUser interfaces for all operations. So, it makes it easy to extend when 
        /// new types of users are added in future.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
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
