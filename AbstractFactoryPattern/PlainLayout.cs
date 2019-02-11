using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class PlainLayout : LayoutFactory {
        public override ContainerBox CreateContainerBox() {
            return new PlainContainerBox();
        }

        public override MenuBar CreateMenuBar() {
            return new PlainMenuBar();
        }
    }
}
