using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class FancyLayout : LayoutFactory {
        public override ContainerBox CreateContainerBox() {
            return new FancyContainerBox();
        }

        public override MenuBar CreateMenuBar() {
            return new FancyMenuBar();
        }
    }
}
