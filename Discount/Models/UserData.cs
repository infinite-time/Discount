using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    /// <summary>
    /// Class which holds data related to the user
    /// </summary>
    public class UserData
    {
        // User ID which is unique to the user
        String userId;
        // User name
        String userName;

        /// <summary>
        /// Constructor to set the data about the user
        /// </summary>
        /// <param name="userId">User ID which is unique to the user</param>
        /// <param name="userName">User name</param>
        public UserData(String userId, String userName)
        {
            this.userId = userId;
            this.userName = userName;
        }

        /// <summary>
        /// Getter and setter for User Id
        /// </summary>
        public String UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        /// <summary>
        /// Getter and setter for User name
        /// </summary>
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
