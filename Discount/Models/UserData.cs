using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    public class UserData
    {
        String userId;
        String userName;
        int percentageDiscountApplicable;

        public UserData(String userId, String userName)
        {
            this.userId = userId;
            this.userName = userName;
        }

        public String UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
