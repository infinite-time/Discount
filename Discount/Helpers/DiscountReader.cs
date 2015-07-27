using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Discount
{
    class DiscountReader
    {
        IUser user;

        public DiscountReader(IUser user)
        {
            this.user = user;
        }

        public int FindDiscount()
        {
            int discountPercentage = 0;
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            if(user is Employee)
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
            return discountPercentage;
        }

        public double FindGeneralDiscount()
        {
            double discountValue;
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\ApplicableDiscounts\\GeneralDiscount.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("DiscountPerHundredDollar");
            String discount = xmlnode[0].FirstChild.Value;
            discountValue = Double.Parse(discount);
            return discountValue;
        }
    }
}
