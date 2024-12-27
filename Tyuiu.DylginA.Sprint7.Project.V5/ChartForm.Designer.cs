namespace Tyuiu.DylginA.Sprint7.Project.V5
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cmbChartType = new ComboBox();
            btnClose = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.Location = new Point(319, 12);
            chart1.Name = "chart1";
            chart1.Size = new Size(469, 426);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // cmbChartType
            // 
            cmbChartType.FormattingEnabled = true;
            cmbChartType.Location = new Point(12, 84);
            cmbChartType.Name = "cmbChartType";
            cmbChartType.Size = new Size(178, 23);
            cmbChartType.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(93, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Назад";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 61);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 3;
            label1.Text = "Выберите график";
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(cmbChartType);
            Controls.Add(chart1);
            Name = "ChartForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ComboBox cmbChartType;
        private Button btnClose;
        private Label label1;
    }
}