using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    public class Pens : Stationary
    {
        private string _type;
        public string Type
        {
            get { return _type; }
            private set
            {
                if (value != null)
                    _type = value;
                else
                    throw new Exception("Invalid Type");
            }
        }

        public Pens() : this("NullId", "NullName", "NullManufacturer", "NullDescription", 0, "NullType") { }


        public Pens(string id, string name, string manufacturer, string description, float price, string type) : base(id, name, manufacturer, description, price)
        {
            Type = type;
        }
    }
}
