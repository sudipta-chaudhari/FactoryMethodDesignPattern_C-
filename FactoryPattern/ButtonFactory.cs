namespace FactoryPattern
{
    internal class ButtonFactory
    {
        internal static IControl GetButton(int buttonType)
        {
            IControl objButton;

            switch (buttonType)
            {
                case 1:
                    objButton = new Button();
                    break;
                case 2:
                    objButton = new RadioButton();
                    break;
                default:
                    objButton = null;
                    break;
            }

            return objButton;
        }

        //internal static object GetButton(int buttonType)
        //{
        //    object objButton;

        //    switch (buttonType)
        //    {
        //        case 1:
        //            objButton = new Button();
        //            break;
        //        case 2:
        //            objButton = new RadioButton();
        //            break;
        //        default:
        //            objButton = null;
        //            break;
        //    }

        //    return objButton;
        //}
    }
}
