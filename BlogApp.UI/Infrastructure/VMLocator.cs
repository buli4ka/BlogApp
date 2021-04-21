using BLL.Modules;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.UI.Infrastructure
{
    public class VMLocator
    {
        IKernel kernel;
        public VMLocator()
        {
            kernel = new StandardKernel(new BlogAppModule());
        }
    }
}
