using DependencyInjection_Ninject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Ninject.Implementation
{
    public class Implementor : IInterface
    {
        public void Get()
        {
            Console.WriteLine("Implementor::Get() called");
        }
    }
}
