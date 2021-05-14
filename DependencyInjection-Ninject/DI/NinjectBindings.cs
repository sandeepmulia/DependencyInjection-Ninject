using DependencyInjection_Ninject.Implementation;
using DependencyInjection_Ninject.Interface;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Ninject.DI
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IInterface>().To<Implementor>();
        }

    }
}
