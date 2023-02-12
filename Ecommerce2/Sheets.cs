using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    public class Sheets : Stationary
    {
        private float _weight;
        public float Weight
        {
            get { return _weight; }
            private set { _weight = value; }
        }
        public Sheets() : this("NullId", "NullName", "NullManufacturer", "NullDescription", 0, 0) { }

        public Sheets(string id, string name, string manufacturer, string description, float price, float weight): base(id, name, manufacturer, description, price)
        {
            Weight = weight;
        }

    }
}
