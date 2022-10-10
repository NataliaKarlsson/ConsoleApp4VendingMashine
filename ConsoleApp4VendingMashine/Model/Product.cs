using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4VendingMashine.Model
{
    public abstract class Product
    {
        private readonly int id;
        public int PriceOfProduct { get; set; }
        public string? ProductName { get; set; }

        public Product()
        {

        }
        public Product(int id, int priceOfProduct, string productName)
        {
            this.id = id;
            PriceOfProduct = priceOfProduct;
            ProductName = productName;
        }
        public int Id { get { return id; } }

        public int Price { get; internal set; }

        public virtual string Examine()
        {
            return $"---{this.GetType().Name} Info----\nNumber: {Id} ";
        }
        public virtual string Use()
        {
            return $"---{this.GetType().Name} Instraction---\n";
        }
    }
}
