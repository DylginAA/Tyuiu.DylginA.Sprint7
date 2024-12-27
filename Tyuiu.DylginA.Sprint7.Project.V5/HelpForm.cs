using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.DylginA.Sprint7.Project.V5
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            this.Text = "Справка";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Visible = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Visible = false;
                }
            }
            textBoxAdd.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Visible = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Visible = false;
                }
            }
            textBoxDelete.Visible = true;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Visible = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Visible = false;
                }
            }
            textBoxEdit.Visible = true;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Visible = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Visible = false;
                }
            }
            textBoxSearch.Visible = true;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Visible = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Visible = false;
                }
            }
            textBoxSort.Visible = true;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Visible = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Visible = false;
                }
            }
            textBox1.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
