using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    public abstract class Stationary : Product
    {
        public Stationary(string id, string name, string manufacturer, string description, float price) : base(id, name, manufacturer, description, price) { }
        public Stationary() : this("NullId", "NullName", "NullManufacturer", "NullDescription", 0) { }
        public override float getDiscount()
        {
            float tmpPrice = 0;
            DateTime today = DateTime.Now;
            if (today.Day % 2 == 0)
            {
                tmpPrice = 3 * this.Price / 100;
                return this.Price - tmpPrice;
            }
            return base.getDiscount();
        }

    }
}
