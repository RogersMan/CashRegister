using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;

namespace Display
{
    public class GenericDisplay : UserControl
    {
        public virtual void SetDisplay(string TheText)
        {
            //TODO: Set the display to the passed in string value
        }
        public virtual void SetDisplay(decimal TheAmount)
        {
            string temp = string.Format("{0:C}", TheAmount);
	        SetDisplay(temp);
        }


    }
}
