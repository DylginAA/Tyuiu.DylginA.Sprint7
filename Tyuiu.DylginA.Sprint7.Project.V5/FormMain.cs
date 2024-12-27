using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Text;
using System.Windows.Forms;

namespace Tyuiu.DylginA.Sprint7.Project.V5
{
    public partial class FormMain_AD : Form
    {
        private int idCounter = 1;
        private bool isEditingEnabled = false;
        public FormMain_AD()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void PopulateSearchColumns()
        {
            cmbSearchColumns.Items.Clear();
            cmbSearchColumns.Items.Add("��� �������");

            foreach (DataGridViewColumn column in dataGridFile_AD.Columns)
            {
                cmbSearchColumns.Items.Add(column.HeaderText);
            }

            cmbSearchColumns.SelectedIndex = 0;

        }
        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "�������� ���� CSV"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    var lines = File.ReadAllLines(filePath);
                    dataGridFile_AD.Rows.Clear();
                    dataGridFile_AD.Columns.Clear();

                    if (lines.Length == 0)
                    {
                        MessageBox.Show("���� ������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var headers = lines[0].Split(';');
                    foreach (var header in headers)
                    {
                        if (!string.IsNullOrWhiteSpace(header))
                        {
                            dataGridFile_AD.Columns.Add(header.Trim(), header.Trim());
                        }
                    }
                    for (int i = 1; i < lines.Length; i++)
                    {
                        var cells = lines[i].Split(';');
                        if (cells.Length == headers.Length)
                        {
                            dataGridFile_AD.Rows.Add(cells);
                        }
                    }

                    MessageBox.Show("������ ������� ���������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelInfoFile_AD.Visible = false;
                    dataGridFile_AD.Visible = true;
                    PopulateSearchColumns();
                    statifnolb.Visible = false;
                    btnShowChart.Enabled = true;
                    txtSearch_AD.Enabled = true;
                    cmbSearchColumns.Enabled = true;
                    btnSearch_AD.Enabled = true;
                    btnReset_AD.Enabled = true;
                    toolStrip1.Enabled = true;
                    pictureInfo.Visible = false;
                    CalculateStatistics();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� �������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (dataGridFile_AD.Rows.Count > 0)
            {
                int maxId = dataGridFile_AD.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[0].Value != null)
                    .Max(r => int.Parse(r.Cells[0].Value.ToString()));

                idCounter = maxId + 1;
            }

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddProductForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {

                    dataGridFile_AD.Rows.Add(idCounter.ToString(), addForm.ProductName, addForm.ProductQuantity, addForm.ProductPrice, addForm.ProductNote);

                    idCounter++;

                    MessageBox.Show("����� ������� ��������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CalculateStatistics();
                }

            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridFile_AD.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridFile_AD.SelectedRows)
                    {
                        dataGridFile_AD.Rows.Remove(row);
                    }

                    MessageBox.Show("����� ������� ������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CalculateStatistics();
                }
                else
                {
                    MessageBox.Show("����������, �������� ������ ��� ��������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "��������� ���� CSV"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    List<string> csvLines = new List<string>();

                    var columnHeaders = dataGridFile_AD.Columns.Cast<DataGridViewColumn>()
                                                             .Select(c => c.HeaderText)
                                                             .ToArray();
                    csvLines.Add(string.Join(";", columnHeaders));

                    foreach (DataGridViewRow row in dataGridFile_AD.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            var cells = row.Cells.Cast<DataGridViewCell>()
                                                  .Select(cell => cell.Value?.ToString() ?? string.Empty)
                                                  .ToArray();
                            csvLines.Add(string.Join(";", cells));
                        }
                    }
                    File.WriteAllLines(filePath, csvLines, Encoding.UTF8);

                    MessageBox.Show("������ ������� ���������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� ���������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool IsDataModified()
        {
            foreach (DataGridViewRow row in dataGridFile_AD.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString())))
                {
                    return true;
                }
            }

            if (dataGridFile_AD.Rows.Cast<DataGridViewRow>().Any(row => row.IsNewRow))
            {
                return false;
            }

            return false;
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsDataModified())
            {
                var result = MessageBox.Show("� ��� ���� ������������ ���������. ��������� ���������?",
                                             "�������������",
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ���������ToolStripMenuItem_Click(sender, e);
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            isEditingEnabled = !isEditingEnabled;

            dataGridFile_AD.ReadOnly = !isEditingEnabled;
            dataGridFile_AD.AllowUserToAddRows = isEditingEnabled;
            dataGridFile_AD.AllowUserToDeleteRows = isEditingEnabled;

            if (isEditingEnabled)
            {
                dataGridFile_AD.BackgroundColor = Color.LightYellow;
                dataGridFile_AD.DefaultCellStyle.BackColor = Color.LightYellow;
                dataGridFile_AD.DefaultCellStyle.ForeColor = Color.Black;
                dataGridFile_AD.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
                MessageBox.Show("����� �������������� �������. �� ������ �������� ������ � �������.",
                                "�������������� ��������",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                dataGridFile_AD.BackgroundColor = Color.White;
                dataGridFile_AD.DefaultCellStyle.BackColor = Color.White;
                dataGridFile_AD.DefaultCellStyle.ForeColor = Color.Black;
                dataGridFile_AD.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                MessageBox.Show("����� �������������� ��������. ������ ������ ������ ��������.",
                                "�������������� ���������",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                CalculateStatistics();
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            if (dataGridFile_AD.Columns.Count == 0)
            {
                MessageBox.Show("��� ������ ���������� ����� ������� ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var sortForm = new SortForm(dataGridFile_AD.Columns))
            {
                if (sortForm.ShowDialog() == DialogResult.OK)
                {
                    string columnName = sortForm.SelectedColumn;
                    var column = dataGridFile_AD.Columns[columnName];
                    if (column == null)
                    {
                        MessageBox.Show("��������� ������� ����������� � �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dataGridFile_AD.Sort(column, sortForm.SortDirection);

                    MessageBox.Show($"������� ������������� �� ������� '{columnName}' ({(sortForm.SortDirection == ListSortDirection.Ascending ? "�� �����������" : "�� ��������")}).",
                                    "���������� ���������",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    CalculateStatistics();
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSearch_AD_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch_AD.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("������� ����� ��� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                CalculateStatistics();
            }

            string selectedColumn = cmbSearchColumns.SelectedItem?.ToString();

            foreach (DataGridViewRow row in dataGridFile_AD.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool rowVisible = false;

                    if (selectedColumn == "��� �������")
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                rowVisible = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        var cell = row.Cells[selectedColumn];
                        if (cell?.Value != null && cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            rowVisible = true;
                        }
                        CalculateStatistics();
                    }

                    row.Visible = rowVisible;
                }
            }
        }
        private void btnReset_AD_Click(object sender, EventArgs e)
        {
            txtSearch_AD.Clear();

            foreach (DataGridViewRow row in dataGridFile_AD.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Visible = true;
                }
            }

            cmbSearchColumns.SelectedIndex = 0;
        }
        private void CalculateStatistics()
        {

            var rows = dataGridFile_AD.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow).ToList();


            int totalQuantity = 0;
            decimal totalPrice = 0;
            decimal totalAmount = 0;
            decimal minPrice = decimal.MaxValue;
            decimal maxPrice = decimal.MinValue;
            decimal minQuantity = decimal.MaxValue;
            decimal maxQuantity = decimal.MinValue;

            foreach (var row in rows)
            {

                int quantity = Convert.ToInt32(row.Cells["����������"].Value);
                decimal price = Convert.ToDecimal(row.Cells["����"].Value);

                totalQuantity += quantity;
                totalPrice += price;
                totalAmount += quantity * price;

                if (price < minPrice) minPrice = price;
                if (price > maxPrice) maxPrice = price;
                if (quantity < minQuantity) minQuantity = quantity;
                if (quantity > maxQuantity) maxQuantity = quantity;
            }
            lblTotalQuantity.Text = $"����� ����������: {totalQuantity}";
            lblTotalAmount.Text = $"����� �����: {totalAmount:C}";
            lblAveragePrice.Text = $"������� ����: {(totalPrice / rows.Count):C}";
            lblMinPrice.Text = $"���. ����: {minPrice:C}";
            lblMaxPrice.Text = $"����. ����: {maxPrice:C}";
            lblMinQuantity.Text = $"���. ����������: {minQuantity}";
            lblMaxQuantity.Text = $"����. ����������: {maxQuantity}";
        }
        private void btnShowChart_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm(dataGridFile_AD);
            chartForm.ShowDialog();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
    }
}