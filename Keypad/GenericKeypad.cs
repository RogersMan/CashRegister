using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;

namespace Keypad
{
    public class GenericKeypad : UserControl
    {

        #region Events
        public event KeyEventHandler ButtonPressed;
        #endregion Events

        #region Methods
        public void RaiseButtonPressed(Key WhatToSend)
        {
            KeyEventHandler handler = ButtonPressed;
            if (handler != null)
            {
                handler(this, new KeyEventArgs(Keyboard.PrimaryDevice, Keyboard.PrimaryDevice.ActiveSource, 0, WhatToSend));
            }
        }

        #endregion Methods
    }

}