using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Color_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_BTN_Click(object sender, EventArgs e)
        {
            //we take the inputs from the 3 textboxes for the colors and add to the listbox
            //first we check if any one of the texboxes is empty
            if (Color_1_TB.Text == "" || Color_2_TB.Text == "" || Color_3_TB.Text == "")
            {
                MessageBox.Show("Error! The input for the colors cannot be empty! Try again!");
            }
            else
            { 
                //now we can add the inputs to the listbox
                Colors.Items.Add(Color_1_TB.Text.ToUpper());
                Colors.Items.Add(Color_2_TB.Text.ToUpper());
                Colors.Items.Add(Color_3_TB.Text.ToUpper());
            }
        }

        private void Colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //first we check if the user selected any item
            if (Colors.SelectedIndex != -1)
            {
                //not we show the selection in a message box
                MessageBox.Show("You have selected: " + Colors.SelectedItem.ToString());
            }
        }
    }
}
