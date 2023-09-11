using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDependencyInjection
{
    public class BL
    {
        IProduct Product;

        public BL(IProduct objIproduct)
        {
            Product = objIproduct;
        }

        public void Add()
        {
            Product.AddProduct();
        }
    }
}
