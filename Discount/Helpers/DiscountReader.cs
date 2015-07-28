using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Discount
{
    /// <summary>
    /// This class is used to read the discount applicable from the respective xml based on the user  type and
    /// to calculate the discount applicable.
    /// The discount values are read from xml so that they can be changed at any time without making any modifications in the code.
    /// Also, it makes it easy to extend this class with new types of users by describing their discount in another xml.
    /// </summary>
    class DiscountReader
    {
        /// <summary>
        /// User
        /// </summary>
        IUser user;

        /// <summary>
        /// Constructor which takes user as input
        /// </summary>
        /// <param name="user">User for whom discount has to be calculated</param>
        public DiscountReader(IUser user)
        {
            this.user = user;
        }

        /// <summary>
        /// Find the discount percentage applicable to the user
        /// </summary>
        /// <returns>Discount percentage</returns>
        public int FindDiscount()
        {
            int discountPercentage = 0;
            try
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;
                if (user is Employee)
                {
                    FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\ApplicableDiscounts\\EmployeeDiscount.xml", FileMode.Open, FileAccess.Read);
                    xmldoc.Load(fs);
                    xmlnode = xmldoc.GetElementsByTagName("Discount");
                    String discount = xmlnode[0].FirstChild.Value;
                    discountPercentage = Int32.Parse(discount);
                }
                if (user is Affiliate)
                {
                    FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\ApplicableDiscounts\\AffiliateDiscount.xml", FileMode.Open, FileAccess.Read);
                    xmldoc.Load(fs);
                    xmlnode = xmldoc.GetElementsByTagName("Discount");
                    String discount = xmlnode[0].FirstChild.Value;
                    discountPercentage = Int32.Parse(discount);
                }
                if (user is Customer && (user as Customer).AssociatedSinceYears >= 2)
                {
                    FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\ApplicableDiscounts\\CustomerDiscount.xml", FileMode.Open, FileAccess.Read);
                    xmldoc.Load(fs);
                    xmlnode = xmldoc.GetElementsByTagName("Discount");
                    String discount = xmlnode[0].FirstChild.Value;
                    discountPercentage = Int32.Parse(discount);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception while loading xml data for discount specific to to the type of user");
            }
            return discountPercentage;
        }

        /// <summary>
        /// Find the general discount which is applicable irrespective of the user type
        /// </summary>
        /// <returns>Discount value</returns>
        public double FindGeneralDiscount()
        {
            double discountValue = 0;
            try
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;
                FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\ApplicableDiscounts\\GeneralDiscount.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("DiscountPerHundredDollar");
                String discount = xmlnode[0].FirstChild.Value;
                discountValue = Double.Parse(discount);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception while loading xml data for general discount");
            }
            return discountValue;
        }
    }
}
