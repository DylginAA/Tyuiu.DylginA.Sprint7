using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.DylginA.Sprint7.Project.V5
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;

    public partial class ChartForm : Form
    {
        private DataGridView dataGrid;

        public ChartForm(DataGridView grid)
        {
            InitializeComponent();
            dataGrid = grid;
            InitializeChart();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void InitializeChart()
        {
            cmbChartType.Items.Add("Количество на складе");
            cmbChartType.Items.Add("Количество в поставке");
            cmbChartType.SelectedIndex = 0;


            cmbChartType.SelectedIndexChanged += (s, e) => LoadChartData();

            chart1.ChartAreas.Add(new ChartArea("MainArea"));
            chart1.Series.Clear();

            LoadChartData();
        }

        private void LoadChartData()
        {
            chart1.Series.Clear();
            string selectedChart = cmbChartType.SelectedItem.ToString();
            Series series = new Series
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32,
            };

            if (selectedChart == "Количество на складе")
            {
                series.Name = "Количество на складе";
                chart1.Series.Add(series);
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var deliveryTime = row.Cells["Код товара"]?.Value?.ToString();
                        var quantityString = row.Cells["Количество"]?.Value?.ToString();

                        if (int.TryParse(quantityString, out int quantity) && !string.IsNullOrEmpty(deliveryTime))
                        {
                            series.Points.AddXY(row.Index, quantity);
                        }
                    }
                    chart1.Series["Количество на складе"].BorderWidth = 1; 
                    chart1.Series["Количество на складе"].IsXValueIndexed = true;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisY.Interval = 20;
                    chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
                    chart1.ChartAreas[0].AxisY.Minimum = 0;
                    foreach (var point in series.Points)
                    {
                        point.IsValueShownAsLabel = true; 
                        point.LabelForeColor = Color.Red;
                        point.Font = new Font("Arial", 12, FontStyle.Bold);
                    }
                    chart1.Invalidate(); 
                    chart1.Update();      
                }
            }
            else if (selectedChart == "Количество в поставке")
            {
                series.Name = "Количество в поставке";
                chart1.Series.Add(series);
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var deliveryTime = row.Cells["Срок поставки"]?.Value?.ToString();
                        var quantityString = row.Cells["Количество в поставке"]?.Value?.ToString();

                        if (int.TryParse(quantityString, out int quantity) && !string.IsNullOrEmpty(deliveryTime))
                        {
     
                            series.Points.AddXY(row.Index, quantity);
                        }
                    }
                    chart1.Series["Количество в поставке"].BorderWidth = 1;
                    chart1.Series["Количество в поставке"].IsXValueIndexed = true; 
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisY.Interval = 100;
                    chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
                    chart1.ChartAreas[0].AxisY.Minimum = 0;
                    foreach (var point in series.Points)
                    {
                        point.IsValueShownAsLabel = true;  
                        point.LabelForeColor = Color.Red;
                        point.Font = new Font("Arial", 12, FontStyle.Bold);
                    }
                    chart1.Invalidate(); 
                    chart1.Update();     
                } 
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
