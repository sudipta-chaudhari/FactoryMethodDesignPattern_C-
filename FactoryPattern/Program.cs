using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Button b = new Button();
            //RadioButton rb = new RadioButton();

            //b.Display();
            //rb.Display();

            Console.Write("Enter choice (1-2) : ");
            int buttonType = Int16.Parse(Console.ReadLine());

            //object objButton = ButtonFactory.GetButton(buttonType);
            //Display(objButton);

            IControl objButton = ButtonFactory.GetButton(buttonType);
            objButton.Display();
            
            Console.ReadLine();
        }
        //private static void Display(object objButtonControl)
        //{
        //    Button objButton;
        //    RadioButton objRadioButton;

        //    if (objButtonControl == null)
        //    {
        //        Console.WriteLine("Wrong Choice");
        //        Console.ReadLine();
        //        Environment.Exit(-1);
        //    }
        //    else
        //    {
        //        switch (objButtonControl.GetType().Name)
        //        {
        //            case "Button":
        //                objButton = (Button)objButtonControl;
        //                objButton.Display();
        //                break;
        //            case "RadioButton":
        //                objRadioButton = (RadioButton)objButtonControl;
        //                objRadioButton.Display();
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}
    }
}
