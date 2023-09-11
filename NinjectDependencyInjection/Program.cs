using System;
using Ninject;
using System.Reflection;
using NinjectDependencyInjection;

namespace NinjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
             StandardKernel _Kernal = new StandardKernel();
            _Kernal.Load(Assembly.GetExecutingAssembly());            
            IProduct _products = _Kernal.Get<IProduct>();           
            BL objbl = new BL(_products);           
            objbl.Add();
            Console.ReadLine();
        }
    }
}
