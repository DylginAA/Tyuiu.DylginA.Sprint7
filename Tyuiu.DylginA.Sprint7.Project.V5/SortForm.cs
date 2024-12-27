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
    public partial class SortForm : Form
    {
        public string SelectedColumn { get; private set; }
        public ListSortDirection SortDirection { get; private set; }
        public SortForm(DataGridViewColumnCollection columns)
        {
            InitializeComponent();
            foreach (DataGridViewColumn column in columns)
            {
                cmbColumns.Items.Add(column.HeaderText);
            }

            if (cmbColumns.Items.Count > 0)
            {
                cmbColumns.SelectedIndex = 0;
            }
            rbtnAscending.Checked = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnApplySort_Click(object sender, EventArgs e)
        {
            if (cmbColumns.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите столбец для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectedColumn = cmbColumns.SelectedItem.ToString();
            SortDirection = rbtnAscending.Checked ? ListSortDirection.Ascending : ListSortDirection.Descending;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelSort_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
