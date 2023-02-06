using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce2
{
    public class Electronic : Product
    {
        private string _model;
        private string _dayOfTheWeek;
        private float _discountedPrice;
        public string Model 
        {
            get
            {
                return _model;
            }
            private set
            {
                if (value != null)
                    _model = value;
                else
                    throw new Exception("Invalid Model");
            }
        }

        public string DayOfTheWeek
        {
            get
            {
                return _dayOfTheWeek;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _dayOfTheWeek = value;
                }
            }
        }

        private string getDay()
        {
            DayOfWeek d = DateTime.Today.DayOfWeek;
            return Convert.ToString(d);
        }

        public Electronic(string id, string name, string manufacturer, string description, float price, string model) : base(id, name, manufacturer, description, price)
        {
            Model = model;
            DayOfTheWeek = getDay();
            Price = Discount(price);
        }

        public Electronic() : this("NullId", "NullName", "NullManufacturer", "NullDescription", 0, "NullModel")
        {

        }
        
        private float Discount(float price)
        {
            if (DayOfTheWeek == "Monday" || DayOfTheWeek == "Lunedì")
            {
                float tmp = price / 100 * 5;
                price = price - tmp;
                return price;
            }
            return base.getDiscount();
        }

        public override string ToString()
        {
            return base.ToString() + Model + ";";
        }
    }
}
