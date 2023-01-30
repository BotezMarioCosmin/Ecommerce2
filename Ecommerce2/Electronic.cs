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
        string _day;
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
                return _day;
            }
            private set
            {
                if (value != null)
                {
                    DayOfWeek d = DateTime.Today.DayOfWeek;
                    _day = Convert.ToString(d);
                }
                else
                    throw new Exception("Invalid Day");
            }
        }

        public Electronic(string id, string name, string manufacturer, string description, float price, string model, string day) : base(id, name, manufacturer, description)
        {
            Price = Discount(price);
            Model = model;
            DayOfTheWeek = day;
        }

        public Electronic() : this("NullName", "NullName", "NullManufacturer", "NullDescription", 0, "NullModel", "NullDay")
        {

        }
        
        private float Discount(float price)
        {
            if (DayOfTheWeek == "Monday" || DayOfTheWeek == "Lunedì")
            {
                float tmp = price / 100 * 5;
                price -= tmp;
                return price;
            }
            return price;
        }
    }
}
