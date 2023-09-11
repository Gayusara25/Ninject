using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDependencyInjection
{
   public class DL:IProduct
    {
        public string AddProduct()
        {
            string data = "Ninject is used to bind Interface and Data Access Layer";
            Console.WriteLine(data);
            return data;

        }
    }
}
