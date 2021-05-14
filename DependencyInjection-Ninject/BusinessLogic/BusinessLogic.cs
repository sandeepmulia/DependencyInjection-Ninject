using DependencyInjection_Ninject.Implementation;
using DependencyInjection_Ninject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Ninject.BusinessLogic
{
    public class BusinessLogicLayer
    {
        private IInterface _implementor; 
        public BusinessLogicLayer(IInterface implementor)
        {
            _implementor = implementor;
        }

        public void BusinessLogicInvoke()
        {
            _implementor.Get();
        }
    }
}
