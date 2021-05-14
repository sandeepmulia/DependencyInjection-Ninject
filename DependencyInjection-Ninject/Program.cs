using DependencyInjection_Ninject.BusinessLogic;
using DependencyInjection_Ninject.Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Ninject
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
            IInterface intfc = _kernel.Get<IInterface>();

            var bl = new BusinessLogicLayer(intfc);
            bl.BusinessLogicInvoke();

            Console.ReadKey();
        }
    }
}
