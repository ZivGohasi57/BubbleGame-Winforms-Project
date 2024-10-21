// Ziv Gohasi 211541271




using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public static class MyExt
    {
        // Extension method for RichTextBox to apply text styles.
        // Takes a delegate as a parameter to determine the style.
        public static void MyText(this RichTextBox ab, Form4.StyleDelegate styleDelegate)
        {
            styleDelegate(); // Execute the delegate to set text, font, and color.


            // Apply the text, font, and color from Form4 to the RichTextBox if it's not null.

            if (ab != null)
            {
                ab.Text = Form4.MainText;  // Set the RichTextBox text.
                ab.Font = Form4.MainFont; // Set the RichTextBox font.
                ab.ForeColor = Form4.MainTextColor; // Set the RichTextBox text color.
            }
        }
    }
}
