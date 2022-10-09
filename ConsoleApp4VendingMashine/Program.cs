
using ConsoleApp4VendingMashine.Model;
using ConsoleApp4VendingMashine.Service;

namespace ConsoleApp4VendingMashine
{


    public class Program
    {
        static void Main(string[] args)
        {
            
            VendingMashineService vendingMashineService = new VendingMashineService();
            //VendingMashineService vendingMashineService = vendingMashineService1;
            vendingMashineService.RunVendingMashin();
        }
    }

}