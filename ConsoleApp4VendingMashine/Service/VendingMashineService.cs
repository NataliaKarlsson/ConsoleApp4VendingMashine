using ConsoleApp4VendingMashine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4VendingMashine.Service
{
    public class VendingMashineService : IVending

    {
        private readonly List<int> moneyDenominations = new List<int> { 1000, 500, 100, 50, 20, 10, 5, 1 };
        public List<Product> productList = new List<Product>();
        private static int id;

        public int Deposit { get; set; }
        public static int Id
        {
            get { return id; }
            set { id = value; }
        }

        public static int NextProductId()
        {
            return id++;
        }

        public List<Product> ListOfProduct()
        {
            productList.Add(new Drink(NextProductId(), "Tonic", 21, "Drink"));
            productList.Add(new Drink(NextProductId(), "Coke", 16, "Soda"));
            productList.Add(new Food(NextProductId(), "Sendwich", 20, "Lunch"));
            productList.Add(new Food(NextProductId(), "Chips", 30, "Lunch"));
            productList.Add(new Candy(NextProductId(), "Mars", 3, "Chocolated"));
            productList.Add(new Candy(NextProductId(), "Mars", 4, "Chupa"));
            return productList;
        }
        public void Clear()
        {
            productList.Clear();
        }

        private void ShowAll()
        {
            Console.Clear();
            foreach (Product product in productList)
            {
                Console.WriteLine("\n" + product.Examine());
            }
            Console.WriteLine("\n\nPress any key to back to menu");
        }

        public void Details()
        {
            Console.Clear();
            Console.Write("Select product number ");
            var productNumber = Int32.Parse(Console.ReadLine()) - 1;
            while (productNumber < 0 || productNumber > productList.Count)
            {
                Console.WriteLine("Invalid number, please enter again");
                productNumber = Int32.Parse(Console.ReadLine()) - 1;
            }
            var product = productList[productNumber];
            Id = productNumber;
            Console.WriteLine("\n" + product.Examine() + "\n" + product.Use());
            Console.WriteLine("\n\n\nChoose option: \n1 - Make a purchase\n2 - Choose another product\n3 - Back to menu");
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                InsertMoney();

            }
            if (input == "2") Details();
            if (input == "3") RunVendingMashin();
        }

        public void InsertMoney()
        {

            Console.Write("Insert money ");
            var addedMoney = Int32.Parse(Console.ReadLine());
            Console.Clear();

            if (moneyDenominations.Contains(addedMoney))
            {
                Deposit += addedMoney;
            }
            else
            {
                Console.WriteLine("Your balance: {0}\n\n\nChoose option:\n1 - Add money\n2 - Get product", Deposit);
                Console.WriteLine("Wrong sum, try again");
                InsertMoney();
                return;
            }

            Console.WriteLine("Your balance: {0}\n\n\nChoose option:\n1 - Add money\n2 - Get product", Deposit);
            var input = Console.ReadLine();
            if (input == "1") InsertMoney();
            else if (input == "2") Purchase(Id);
        }

        public Product Purchase(int id)
        {
            var product = productList[id];
            if (Deposit >= product.PriceOfProduct)
            {
                Console.Clear();
                Console.WriteLine("You got {0}\n\nPress enter to continue", product.ProductName);
                Console.ReadLine();
                EndTransaction();
                return product;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money\nYou got your money back\nPress any key to back to menu");
                Deposit = 0;
            }
            return null;
        }


        public Dictionary<int, int> EndTransaction()
        {
            Console.Clear();
            Dictionary<int, int> result = new Dictionary<int, int>();
            var change = Deposit - productList[Id].PriceOfProduct;
            Console.WriteLine("You change is $" + change.ToString() + "\nPress any key to back to menu");
            Deposit = 0;
            foreach (int moneyType in moneyDenominations)
            {
                result.Add(moneyType, change / moneyType);
                change %= moneyType;
            }
            return result;
        }
        public void RunVendingMashin()
        {
            ListOfProduct();
            bool run = true;
            while (run)
            {
                try
                {
                    Console.Clear();
                    WelcomesMenu();
                    string? user = Console.ReadLine();

                    switch (user)
                    {
                        case "1":
                            ShowAll();
                            break;
                        case "2":
                            Details();
                            break;
                        case "3":
                            Console.WriteLine("Now you are finished, Thanks");
                            run = false;
                            break;
                        default:
                            break;
                    }
                    Console.ReadKey(true);
                    Console.Clear();
                }
                catch (ArgumentException)
                {
                    throw new ArgumentException("Not working");
                }


            }
        }
        public static void WelcomesMenu()
        {
            Console.Clear();
            Console.WriteLine("\n---Vending mashine---\n");
            Console.WriteLine("\nChoose options: ");
            Console.WriteLine("\n1 - Show product.");
            Console.WriteLine("\n2 - Choose a product.");
            Console.WriteLine("\n3 - Quit.");
        }
    }
}





