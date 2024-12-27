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

namespace Tyuiu.DylginA.Sprint7.Project.V5
{
    public partial class AddProductForm : Form
    {
        public string ProductName { get; private set; }
        public string ProductQuantity { get; private set; }
        public string ProductPrice { get; private set; }
        public string ProductNote { get; private set; }

        public AddProductForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductName = txtName.Text;
            ProductQuantity = txtQuantity.Text;
            ProductPrice = txtPrice.Text;
            ProductNote = txtNote.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
