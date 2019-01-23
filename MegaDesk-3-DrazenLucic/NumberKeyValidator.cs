using System.Windows.Forms;

namespace MegaDesk_3_DrazenLucic
{
    //The code in this class is inspired by 
    //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.keypress?view=netframework-4.7.2

    public class NumberKeyValidator
    {
        // Handle the KeyDown event to determine the type of character entered into the control.
        public static bool CheckKeyDown(object sender, KeyEventArgs e)
        {
            // Boolean flag used to determine when a character other than a number is entered.
            bool nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
            return nonNumberEntered;
        }
    }
}
