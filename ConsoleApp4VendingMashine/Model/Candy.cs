using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4VendingMashine.Model
{
    public class Candy : Product
    {
             
        
        private string v1;
        private int v2;
        private int v3;

        private string candyName { get; set; }
        private string candyDescription { get; set; }
        public string candyType
        {
            get
            {
                return candyName;
            }
            set
            {
                candyName = value;
            }
        }

        public Candy(int id) 
        {
            id = id;
        }

        public Candy(int id, string productName, int priceOfproduct, string candyType) : base(id, priceOfproduct, productName)
        {
            candyType = candyType;
            candyName = "Mars";
            candyDescription = candyDescription;
        }

        //public Candy(int id, string v1, int v2, int v3) : this(id)
        //{
        //   this.v1 = v1;
        //    this.v2 = v2;
        //    this.v3 = v3;
        //}

        public override string Examine()
        {
            return base.Examine() + $"{ProductName}" +" $"+ $"{PriceOfProduct}"; 
        }
        public override string Use()
        {
            return base.Use() + "put it in your mouth ";
        }
        
    }
}









