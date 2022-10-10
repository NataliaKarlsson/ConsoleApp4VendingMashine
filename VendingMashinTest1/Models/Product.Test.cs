using ConsoleApp4VendingMashine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMashinTest1.Models
{
    public class Product
    {
        [Fact]
        public void CreateProduct_Test()
        {
            //Arr
            Drink drink = new Drink(1,"Tonic", 21, "Drink");
            Food food = new Food(1, "Sendwich", 20, "Lunch");
            Candy candy = new Candy(1, "Mars", 3, "Chocolated");
            //Act



            //Ass
            Assert.Equal(1, drink.Id);
            Assert.Equal(1, food.Id);
            Assert.Equal(1, candy.Id);
            Assert.Equal(21, drink.PriceOfProduct);
            Assert.Equal(20, food.PriceOfProduct);
            Assert.Equal(3, candy.PriceOfProduct);



        }
    }
}
