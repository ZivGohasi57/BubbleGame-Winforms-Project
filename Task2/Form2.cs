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
using System.Xml.Linq;

namespace Task2
{
    public partial class Form2 : Form
    {
        // Property to store the player's name entered in the form.
        public string PlayerName { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the text box is empty or the name entered is less than 1 character.
            if (string.IsNullOrEmpty(txtName.Text) || txtName.Text.Length < 1)
            {
                // Show an error message if the name is invalid.
                MessageBox.Show("Name must be at least one character long.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the function without setting the player's name.
            }

            // Set the player's name and close the form with a successful result.
            PlayerName = txtName.Text;
            DialogResult = DialogResult.OK; // Indicates that the input was successful.
            this.Close(); 
        }
    }
}
