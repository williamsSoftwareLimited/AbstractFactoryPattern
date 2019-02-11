using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    abstract class LayoutFactory
    {
        public abstract ContainerBox CreateContainerBox();
        public abstract MenuBar CreateMenuBar();
    }
}
