using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4VendingMashine.Model
{
    public class Food : Product
    {
        private string foodType { get; set; }
        private string foodName { get; set; }
        private string foodDescription { get; set; }
        
        private string v1;
        private int v2;
        private string v3;

        public Food(int id)
        {
            id = id;
        }
        public Food(int id, string productName, int priceOfproduct, string foodType) : base(id, priceOfproduct, productName)
        {
            foodType = foodType;
            //drinkName="Tonic";
            foodDescription = foodDescription;
        }
        //public Food(int id, string v1, int v2, string v3) : this(id)
        //{
        //    this.v1 = v1;
        //    this.v2 = v2;
        //    this.v3 = v3;
        //}

        public override string Examine()
        {
            return base.Examine() + $"{ProductName}" + " $" + $"{PriceOfProduct}";
        }

        public override string Use()
        {
            return base.Use() + "put it on your mouth ";
        }
    }
}
