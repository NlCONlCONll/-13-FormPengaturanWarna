using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13__Form_Pengaturan_Warna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if(label.Text == "[EMPTY]")
            {
                label.Text = textBox.Text;
            }
            if (textBox.Text == "DELETE")
            {
                label.Text = "[EMPTY]";
            }
            else
            {
                if (textBox.Text == "SHOWN")
                {
                    label.Visible = true;
                }
                if (textBox.Text == "HIDE")
                {
                    label.Visible = false;
                }
                if (textBox.Text == "RED")
                {
                    label.ForeColor = System.Drawing.Color.Red;
                }
                if (textBox.Text == "GREEN")
                {
                    label.ForeColor = System.Drawing.Color.Green;
                }
                if (textBox.Text == "BLUE")
                {
                    label.ForeColor = System.Drawing.Color.Blue;
                }
                else
                {
                    label.Text = textBox.Text;
                }

            }
            
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Click(sender, e); //enter untuk input mengganti tekan button
            }
        }
    }
}
