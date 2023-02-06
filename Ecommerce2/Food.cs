using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ecommerce2
{
    public class Food : Product
    {
        private string[] _ingredients = new string[10];
        private DateTime _expirationDate; // dd/mm/yy
        private string _dayOfTheWeek;
        public DateTime ExpirationDate
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
        
        public string[] Ingredients
        {
            get
            {
                return _ingredients;
            }
            private set
            {
                if (value != null)
                {
                    _ingredients = value;
                }
                else
                    throw new Exception("Invalid Ingredients");
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

        public Food(string id, string name, string manufacturer, string description, float price, string[] ingredients, DateTime expirationDate) : base(id, name, manufacturer, description, price)
        {
            ExpirationDate = expirationDate;
            Ingredients = ingredients;
        }

        public Food(string id, string name, string manufacturer, string description, float price, DateTime expirationDate) : base(id, name, manufacturer, description, price)
        {
            ExpirationDate = expirationDate;
            Ingredients = generateNullIngredients();
        }

        private string[] generateNullIngredients()
        {
            for (int i = 0; i < Ingredients.Length; i++)
            {
                Ingredients[i] = "NullIngredient";
            }
            return Ingredients;
        }
        
        public Food() : this("NullId", "NullName", "NullManufacturer", "NullDescription", 0, new DateTime(9999, 1, 1))
        {

        }

        private float Discount(float price)
        {
            if (DayOfTheWeek == "Monday")
            {
                float tmp = price / 100 * 5;
                price = price - tmp;
                return price;
            }
            return price;
        }

        private string IngredientsToString()
        {
            return Convert.ToString(Ingredients[0]) + Convert.ToString(Ingredients[1]) + Convert.ToString(Ingredients[2]) +
                Convert.ToString(Ingredients[3]) + Convert.ToString(Ingredients[4]) + Convert.ToString(Ingredients[5]) +
                Convert.ToString(Ingredients[6]) + Convert.ToString(Ingredients[7]) + Convert.ToString(Ingredients[8])
                + Convert.ToString(Ingredients[9]);
        }
    }
}
