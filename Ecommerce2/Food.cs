using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    public class Food : Product
    {
        string[] _ingredients = new string[10];
        string _expirationDate;
        public string ExpirationDate
        {
            get
            {
                return _expirationDate;
            }
            private set
            {
                if (value != null)
                    _expirationDate = value;
                else
                    throw new Exception("Invalid Expiration Date");
            }
        }
        /*
        public string Ingredients
        {
            get
            {
                return _ingredients[];
            }
            private set
            {
                if (value == null)
                {
                    DayOfWeek d = DateTime.Today.DayOfWeek;
                    _day = Convert.ToString(d);
                }
                else
                    throw new Exception("Invalid Day");
            }
        }*/
        /*
        public Electronic(string id, string name, string manufacturer, string description, float price, string model) : base(id, name, manufacturer, description, price)
        {
            Price = Discount(price);
            Model = model;
            string day = DayOfTheWeek;
            DayOfTheWeek = day;
        }

        public Electronic() : this("NullName", "NullName", "NullManufacturer", "NullDescription", 0, "NullModel")
        {

        }*/
        /*
        private float Discount(float price)
        {
            if (DayOfTheWeek == "Monday" || DayOfTheWeek == "Lunedì")
            {
                float tmp = price / 100 * 5;
                price -= tmp;
                return price;
            }
            return price;
        }*/
        /*
        private string IngredientsToString()
        {
            return Convert.ToString(Ingredients[0]) + Convert.ToString(Ingredients[1]) + Convert.ToString(Ingredients[2]) +
                Convert.ToString(Ingredients[3]) + Convert.ToString(Ingredients[4]) + Convert.ToString(Ingredients[5]) +
                Convert.ToString(Ingredients[6]) + Convert.ToString(Ingredients[7]) + Convert.ToString(Ingredients[8])
                + Convert.ToString(Ingredients[9]);
        }*/
    }
}
