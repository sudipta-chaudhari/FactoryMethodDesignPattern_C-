using System;

namespace FactoryPattern
{
    internal class Button : IControl
    {
        public void Display()
        {
            Console.WriteLine("Button displayed.");
        }
    }
}
