using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    public class Electronic : Product
    {
        string _model;
        string _dayOfTheWeek;
        float _discountedPrice;
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
            private set
            {
                _dayOfTheWeek = getDay();
            }
        }

        public float DiscountedPrice
        { 
            get { return _discountedPrice; }
            private set { _discountedPrice = Discount(Price); }
        }

        private string getDay()
        {
            DayOfWeek d = DateTime.Today.DayOfWeek;
            return Convert.ToString(d);
        }

        public Electronic(string id, string name, string manufacturer, string description, float price, string model) : base(id, name, manufacturer, description, price)
        {
            DiscountedPrice = Discount(price);
            Model = model;
            DayOfTheWeek = getDay();
        }

        public Electronic() : this("NullName", "NullName", "NullManufacturer", "NullDescription", 0, "NullModel")
        {

        }
        
        private float Discount(float price)
        {
            if (DayOfTheWeek == "Monday")// || DayOfTheWeek == "Lunedì")
            {
                float tmp = price / 100 * 5;
                price = price - tmp;
                return price;
            }
            return price;
        }
    }
}
