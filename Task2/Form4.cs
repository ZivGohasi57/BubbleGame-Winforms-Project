// Ziv Gohasi 211541271





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2;

namespace Task2
{
    public partial class Form4 : Form
    {
        // Properties to store the main text, font, and color for the form.
        public static string MainText { get; set; }
        public static Font MainFont { get; set; }
        public static Color MainTextColor { get; set; }

        // Delegate definition for text styling functions.
        public delegate void StyleDelegate();

        public Form4()
        {
            InitializeComponent();
            this.Text = "About HW2"; // Set the form title.
            ApplyRandomStyle(); // Apply a random text style when the form is created.
        }

        // Applies a random text style by selecting one of the styling delegates (S1, S2, S3).
        private void ApplyRandomStyle()
        {
            StyleDelegate d = S1;  // Default to style S1.

            // Generate a random number between 0 and 2 to pick a style.
            Random rnd = new Random();
            int delegateIndex = rnd.Next(0, 3);

            // Choose a style based on the random number.
            switch (delegateIndex)
            {
                case 0:
                    d = S1;
                    break;
                case 1:
                    d = S2;
                    break;
                case 2:
                    d = S3;
                    break;
            }

            ab.MyText(d); // Apply the selected style using MyText extension method.
        }



        // Styling function S1: Sets specific text, font, and color.
        public void S1()
        {
            MainText = "HW2!";
            MainFont = new Font("Arial", 45, FontStyle.Italic);
            MainTextColor = Color.Red;
        }


        // Styling function S2: Sets specific text, font, and color.
        public void S2()
        {
            MainText = "MY HOME WORK";
            MainFont = new Font("Times New Roman", 45, FontStyle.Bold);
            MainTextColor = Color.Green;
        }


        // Styling function S3: Sets specific text, font, and color.
        public void S3()
        {
            MainText = "HW2!!!";
            MainFont = new Font("Verdana", 45, FontStyle.Underline);
            MainTextColor = Color.Blue;
        }


        // Handles the "OK" button click event.
        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ab_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
