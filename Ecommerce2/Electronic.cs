using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    internal class Electronic : Product
    {
        string _model;
        string[] days;

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

        public Electronic(string id, string name, string manufacturer, string description, string model) : base(id)
        {
            Model = model;
        }

        public Electronic() : this("NullName", "NullName", "NullManufacturer", "NullDescription", "NullModel")
        {

        }
    }
}
