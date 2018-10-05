using System;

namespace FactoryPattern
{
    internal class RadioButton : IControl
    {
        public void Display()
        {
            Console.WriteLine("Radio Buton displayed.");
        }
    }
}
