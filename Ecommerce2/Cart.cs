using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    public class Cart
    {
        private string _id; //primary key
        private int _numeroprodotti = 0;
        private Product[] prodotti;

        public Cart(string id1, Product[] arrayp)
        {
            Id = id1;
            prodotti = arrayp;
        }

        public string Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public void aggiungi(Product p)
        {
            prodotti[_numeroprodotti] = p;
            _numeroprodotti++;
        }

        public Product rimuovi(Product p)
        {
            for (int i = 0; i < _numeroprodotti; i++)
            {
                if (p == prodotti[i])
                {
                    prodotti[i] = null;
                    return p;
                }
            }
            throw new Exception("prodotto insesistente");
        }

        public Product[] svuota()
        {
            Product[] array = new Product[999];
            for (int i = 0; i < _numeroprodotti; i++)
            {
                array[i] = prodotti[i];
                prodotti[i] = null;
            }
            return array;
        }

        public Product[] getProdotti()
        {
            return prodotti;
        }
    }
}
