using ConsoleApp4VendingMashine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4VendingMashine.Service
{
    public interface IVending
    {
        Product Purchase(int id);
        List<Product> ListOfProduct();
         void Details();
        
        Dictionary<int, int> EndTransaction();
        
    }
}

   

      

