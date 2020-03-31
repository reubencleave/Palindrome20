using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnarray_Click(object sender, EventArgs e)
        {
            textToCheck.Text  = CheckPalindrome(textToCheck.Text);
        }

        /// <summary>
        /// Checks if the text entered is a palindrome returns a true false string
        /// </summary>
        
        private string CheckPalindrome(string textIn)
        {
            // keep a copy of the text that is entered to compare
            string oldtext = textIn;

            //Remove spaces and convert to lowercase
            textIn = textIn.Replace("", "");
            textIn = textIn.ToLower();

            // Convert to an array
            char[] text = textIn.ToCharArray();

            //Reverse the text array
            Array.Reverse(text);

            // Convert the array back to a string and check if reverse string is the same.
            if (textIn == new string(text))
            {
                return oldtext + "is a palindrome.";
            }
            else
            {
                return oldtext + "is not a palindrome.";
            }
          }
    }

}
