using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args) {

            LayoutFactory plainLayout = new PlainLayout();
            ContainerBox plainContainerBox = plainLayout.CreateContainerBox();
            MenuBar plainMenuBar = plainLayout.CreateMenuBar();

            plainContainerBox.Contains(plainMenuBar);

            LayoutFactory fancyLayout = new FancyLayout();
            ContainerBox fancyContainerBox = fancyLayout.CreateContainerBox();
            MenuBar fancyMenuBar = fancyLayout.CreateMenuBar();

            fancyContainerBox.Contains(fancyMenuBar);

            Console.ReadKey();
        }
    }
}
