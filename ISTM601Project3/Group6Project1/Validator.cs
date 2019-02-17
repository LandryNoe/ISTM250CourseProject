using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group6Project1
{
    class Validator
    {
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text.Trim() == "")
            {
                MessageBox.Show(textBox.Tag.ToString() + " is a required field", "Missing Entry");
                textBox.Focus(); //the blank textbox will be focused, context-specific
                return false;
            }
            else
            {
                return true;
            }
        }




        public static bool IsSelected(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex < 0)
            {
                MessageBox.Show(comboBox.Tag.ToString() + " must be selected", "Selection Error");
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool IsInteger(TextBox textBox)
        {
            long intTempOutput = 0;
            if (Int64.TryParse(textBox.Text, out intTempOutput) == false)   //==false does false first then true (same as doing != before the statement)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be a whole number.", "Entry Error");
                textBox.Focus();
                return false;

            }
            else
                return true;
        }

        public static bool IsWithinRange(TextBox textBox, decimal decMin, decimal decMax)
        {
            decimal decCheckValue = Convert.ToDecimal(textBox.Text);
            if (decCheckValue < decMin || decCheckValue > decMax)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be between " + decMin.ToString("n2") + " and " + decMax.ToString("n2") + ".", "Range Error");
                textBox.Focus();
                return false;
            }
            else
                return true;
        }


        public static bool IsDeliverableState(ComboBox comboBox)
        {
            string strSelectedIndex = comboBox.SelectedItem.ToString();

            if (strSelectedIndex == "TX")
            {
                return true;

            }
            else
            {
                MessageBox.Show("Delivery State must be Texas (TX)");
                comboBox.Focus();
                return false;
            }
        }


        public static bool IsDeliverableCity(TextBox textBox)
        {
            if (textBox.Text.ToLower() == "college station" || textBox.Text.ToLower() == "bryan")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Delivery City must be 'College Station' or 'Bryan'");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsZipCode(TextBox textbox)
        {
            if (textbox.Text.Length == 5)
            {
                return true;
            }
            else
            {

                MessageBox.Show("Zip code must be five digits.", "Zip Code Error");
                return false;

            }

        }

        public static bool IsPhoneNumber(TextBox textbox)
        {
            if (textbox.Text.Length == 10)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Phone number must be 10 digits.", "Phone Number Error");
                return false;
            }
        }

        internal static bool IsPresent(MaskedTextBox txtDeliveryZipCode)
        {
            throw new NotImplementedException();
        }

        internal static bool IsInteger(MaskedTextBox txtDeliveryPhoneNumber)
        {
            throw new NotImplementedException();
        }

        internal static bool IsWithinRange(MaskedTextBox txtDeliveryZipCode, int v1, int v2)
        {
            throw new NotImplementedException();
        }

        internal static bool IsWithinRange(MaskedTextBox txtDeliveryPhoneNumber, int v1, long v2)
        {
            throw new NotImplementedException();
        }

        internal static bool IsPhoneNumber(MaskedTextBox txtDeliveryPhoneNumber)
        {
            throw new NotImplementedException();
        }

        internal static bool IsZipCode(MaskedTextBox txtDeliveryZipCode)
        {
            throw new NotImplementedException();
        }
    }
}
