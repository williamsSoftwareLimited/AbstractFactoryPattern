using System;

namespace AbstractFactoryPattern {
    abstract class ContainerBox {
        public void Contains(MenuBar menuBar) {
            Console.WriteLine(this.GetType().Name +" contains " + menuBar.GetType().Name);
        }
    }
}