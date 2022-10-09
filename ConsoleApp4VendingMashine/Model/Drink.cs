using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4VendingMashine.Model
{
    public class Drink : Product
    {
        private string drinkType { get; set; }
        private string DrinkName { get; set; }
        private string drinkDescription { get; set; }
        private string drinkName;


        public string DrinkType
        {
            get
            {
                return drinkName;
            }
            set
            {
                drinkName = value;
            }
        }

        public Drink(int id)
        {
            id = id;
        }
        public Drink(int id, string productName, int priceOfproduct, string drinkType) : base(id, priceOfproduct, productName)

        {
            drinkType = drinkType;
            
            drinkDescription = drinkDescription;
        }
               

        public override string Examine()
        {
            return base.Examine() + $"{ProductName}" + " $" + $"{PriceOfProduct}";
        }

        public override string Use()
        {
            return base.Use() + "Drink it ";
        }

    }
}
