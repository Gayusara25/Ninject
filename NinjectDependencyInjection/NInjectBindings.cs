﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDependencyInjection
{
    public class NInjectBindings:Ninject.Modules.NinjectModule
    { 
        public override void Load()
        {
            Bind<IProduct>().To<DL>();
        }
    }
}
