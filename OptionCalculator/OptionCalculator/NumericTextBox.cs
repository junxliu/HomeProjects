using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace OptionCalculator
{
    public class NumericTextBox : TextBox
    {
        bool allowNegative          = true;

        // Restricts the entry of characters to digits (including hex), the negative sign,
        // the decimal point, and editing keystrokes (backspace).
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            NumberFormatInfo numberFormatInfo   = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator             = numberFormatInfo.NumberDecimalSeparator;
            string negativeSign                 = numberFormatInfo.NegativeSign;
            string keyInput                     = e.KeyChar.ToString();

            if (Char.IsDigit(e.KeyChar))
            {
                // Digits are OK
            }
            else if (keyInput.Equals(decimalSeparator))
            {
                // only if there is no previous decimal separator
                if (this.Text.IndexOf(e.KeyChar) != -1) // if we can find the decimal separator already in the string
                    e.Handled = true;
            }
            else if (this.allowNegative && keyInput.Equals(negativeSign) && (this.Text.Length == 0 || this.SelectionStart == 0) )            // only allow leading negative sign
            {
                // Decimal separator is OK
            }
            else if (e.KeyChar == '\b')
            {
                // Backspace key is OK
            }
            else if ((ModifierKeys & (Keys.Control | Keys.Alt)) != 0)
            {
                // Let the edit control handle control and alt key combinations
            }
            else
            {
                // Swallow this invalid key and beep
                e.Handled = true;
            }
        }

        public double DoubleValue
        {
            get
            {
                if (this.Text.Length == 0)
                    return 0.0;
                return Double.Parse(this.Text);
            }
        }

       

        public bool AllowNegative
        {
            set
            {
                this.allowNegative = value;
            }
            get
            {
                return this.allowNegative;
            }
        }

    }
}
