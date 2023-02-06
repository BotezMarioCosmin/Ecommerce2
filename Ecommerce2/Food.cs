using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private DateTime _currentDate;
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

        public DateTime CurrentDate
        {
            get
            {
                return DateTime.Now;
            }
            set
            {
                _currentDate = DateTime.Now;
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

        public Food() : this("NullId", "NullName", "NullManufacturer", "NullDescription", 0, new DateTime(9999, 1, 1))
        {

        }

        private string[] generateNullIngredients()
        {
            for (int i = 0; i < Ingredients.Length; i++)
            {
                Ingredients[i] = "NullIngredient";
            }
            return Ingredients;
        }

        public bool expired()
        {
            var dif = ExpirationDate.Subtract(CurrentDate);
            if (dif.Days < 0)
            {
                return true;
            }
            return false;
        }

        public override float getDiscount()
        {
            var dif = ExpirationDate.Subtract(CurrentDate);
            if (dif.Days < 7)
            {
                return Price / 2;
            }
            return base.getDiscount();
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
