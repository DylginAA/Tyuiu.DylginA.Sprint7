namespace Tyuiu.DylginA.Sprint7.Project.V5
{
    partial class FormMain_AD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_AD));
            menuStrip1 = new MenuStrip();
            FileToolItem_AD = new ToolStripMenuItem();
            OpenFileTool_AD = new ToolStripMenuItem();
            SaveFileToll_AD = new ToolStripMenuItem();
            InfoTool_AD = new ToolStripMenuItem();
            fAQToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            ExitTool_AD = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            AddDatainFile_AD = new ToolStripButton();
            EditDataInFile_AD = new ToolStripButton();
            DeleteDataInFile_AD = new ToolStripButton();
            SortDataInFile_AD = new ToolStripButton();
            txtSearch_AD = new TextBox();
            label1 = new Label();
            dataGridFile_AD = new DataGridView();
            labelInfoFile_AD = new Label();
            btnSearch_AD = new Button();
            cmbSearchColumns = new ComboBox();
            btnReset_AD = new Button();
            btnShowChart = new Button();
            lblTotalQuantity = new Label();
            lblTotalAmount = new Label();
            lblAveragePrice = new Label();
            lblMinPrice = new Label();
            lblMaxPrice = new Label();
            lblMinQuantity = new Label();
            lblMaxQuantity = new Label();
            groupBoxStatistis_AD = new GroupBox();
            statifnolb = new Label();
            pictureInfo = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFile_AD).BeginInit();
            groupBoxStatistis_AD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureInfo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolItem_AD, InfoTool_AD, ExitTool_AD });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(914, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileToolItem_AD
            // 
            FileToolItem_AD.DropDownItems.AddRange(new ToolStripItem[] { OpenFileTool_AD, SaveFileToll_AD });
            FileToolItem_AD.Name = "FileToolItem_AD";
            FileToolItem_AD.Size = new Size(48, 20);
            FileToolItem_AD.Text = "Файл";
            // 
            // OpenFileTool_AD
            // 
            OpenFileTool_AD.Name = "OpenFileTool_AD";
            OpenFileTool_AD.Size = new Size(153, 22);
            OpenFileTool_AD.Text = "Открыть файл";
            OpenFileTool_AD.Click += открытьФайлToolStripMenuItem_Click;
            // 
            // SaveFileToll_AD
            // 
            SaveFileToll_AD.Name = "SaveFileToll_AD";
            SaveFileToll_AD.Size = new Size(153, 22);
            SaveFileToll_AD.Text = "Сохранить";
            SaveFileToll_AD.Click += сохранитьToolStripMenuItem_Click;
            // 
            // InfoTool_AD
            // 
            InfoTool_AD.DropDownItems.AddRange(new ToolStripItem[] { fAQToolStripMenuItem, оПрограммеToolStripMenuItem });
            InfoTool_AD.Name = "InfoTool_AD";
            InfoTool_AD.Size = new Size(65, 20);
            InfoTool_AD.Text = "Справка";
            // 
            // fAQToolStripMenuItem
            // 
            fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            fAQToolStripMenuItem.Size = new Size(149, 22);
            fAQToolStripMenuItem.Text = "FAQ";
            fAQToolStripMenuItem.Click += fAQToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // ExitTool_AD
            // 
            ExitTool_AD.Name = "ExitTool_AD";
            ExitTool_AD.Size = new Size(54, 20);
            ExitTool_AD.Text = "Выход";
            ExitTool_AD.Click += выходToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.MintCream;
            toolStrip1.BackgroundImageLayout = ImageLayout.Center;
            toolStrip1.Enabled = false;
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStrip1.GripMargin = new Padding(10);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddDatainFile_AD, EditDataInFile_AD, DeleteDataInFile_AD, SortDataInFile_AD });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 2, 2, 2);
            toolStrip1.Size = new Size(914, 41);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddDatainFile_AD
            // 
            AddDatainFile_AD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AddDatainFile_AD.Image = (Image)resources.GetObject("AddDatainFile_AD.Image");
            AddDatainFile_AD.ImageTransparentColor = Color.Magenta;
            AddDatainFile_AD.Name = "AddDatainFile_AD";
            AddDatainFile_AD.Size = new Size(34, 34);
            AddDatainFile_AD.Text = "Новый товар";
            AddDatainFile_AD.Click += toolStripLabel1_Click;
            // 
            // EditDataInFile_AD
            // 
            EditDataInFile_AD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            EditDataInFile_AD.Image = (Image)resources.GetObject("EditDataInFile_AD.Image");
            EditDataInFile_AD.ImageTransparentColor = Color.Magenta;
            EditDataInFile_AD.Name = "EditDataInFile_AD";
            EditDataInFile_AD.Size = new Size(34, 34);
            EditDataInFile_AD.Text = "Редактировать товар";
            EditDataInFile_AD.Click += toolStripLabel2_Click;
            // 
            // DeleteDataInFile_AD
            // 
            DeleteDataInFile_AD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DeleteDataInFile_AD.Image = (Image)resources.GetObject("DeleteDataInFile_AD.Image");
            DeleteDataInFile_AD.ImageTransparentColor = Color.Magenta;
            DeleteDataInFile_AD.Name = "DeleteDataInFile_AD";
            DeleteDataInFile_AD.Size = new Size(34, 34);
            DeleteDataInFile_AD.Text = "Удалить товар";
            DeleteDataInFile_AD.Click += toolStripLabel3_Click;
            // 
            // SortDataInFile_AD
            // 
            SortDataInFile_AD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SortDataInFile_AD.Image = (Image)resources.GetObject("SortDataInFile_AD.Image");
            SortDataInFile_AD.ImageTransparentColor = Color.Magenta;
            SortDataInFile_AD.Name = "SortDataInFile_AD";
            SortDataInFile_AD.Size = new Size(34, 34);
            SortDataInFile_AD.Text = "Сортировка";
            SortDataInFile_AD.Click += toolStripDropDownButton1_Click;
            // 
            // txtSearch_AD
            // 
            txtSearch_AD.Enabled = false;
            txtSearch_AD.Location = new Point(14, 89);
            txtSearch_AD.Name = "txtSearch_AD";
            txtSearch_AD.Size = new Size(138, 25);
            txtSearch_AD.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(14, 67);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 6;
            label1.Text = "Поиск:";
            // 
            // dataGridFile_AD
            // 
            dataGridFile_AD.BorderStyle = BorderStyle.Fixed3D;
            dataGridFile_AD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFile_AD.GridColor = SystemColors.Desktop;
            dataGridFile_AD.Location = new Point(195, 89);
            dataGridFile_AD.Name = "dataGridFile_AD";
            dataGridFile_AD.ReadOnly = true;
            dataGridFile_AD.RowHeadersVisible = false;
            dataGridFile_AD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridFile_AD.Size = new Size(707, 352);
            dataGridFile_AD.TabIndex = 8;
            dataGridFile_AD.Visible = false;
            // 
            // labelInfoFile_AD
            // 
            labelInfoFile_AD.AutoSize = true;
            labelInfoFile_AD.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInfoFile_AD.Location = new Point(342, 181);
            labelInfoFile_AD.Name = "labelInfoFile_AD";
            labelInfoFile_AD.Size = new Size(450, 30);
            labelInfoFile_AD.TabIndex = 9;
            labelInfoFile_AD.Text = "Откройте таблицу для начала работы";
            // 
            // btnSearch_AD
            // 
            btnSearch_AD.Enabled = false;
            btnSearch_AD.Location = new Point(14, 181);
            btnSearch_AD.Name = "btnSearch_AD";
            btnSearch_AD.Size = new Size(75, 23);
            btnSearch_AD.TabIndex = 10;
            btnSearch_AD.Text = "Поиск";
            btnSearch_AD.UseVisualStyleBackColor = true;
            btnSearch_AD.Click += btnSearch_AD_Click;
            // 
            // cmbSearchColumns
            // 
            cmbSearchColumns.Enabled = false;
            cmbSearchColumns.FormattingEnabled = true;
            cmbSearchColumns.Location = new Point(14, 134);
            cmbSearchColumns.Name = "cmbSearchColumns";
            cmbSearchColumns.Size = new Size(138, 25);
            cmbSearchColumns.TabIndex = 11;
            // 
            // btnReset_AD
            // 
            btnReset_AD.Enabled = false;
            btnReset_AD.Location = new Point(14, 229);
            btnReset_AD.Name = "btnReset_AD";
            btnReset_AD.Size = new Size(75, 23);
            btnReset_AD.TabIndex = 12;
            btnReset_AD.Text = "Сброс";
            btnReset_AD.UseVisualStyleBackColor = true;
            btnReset_AD.Click += btnReset_AD_Click;
            // 
            // btnShowChart
            // 
            btnShowChart.Enabled = false;
            btnShowChart.Location = new Point(783, 447);
            btnShowChart.Name = "btnShowChart";
            btnShowChart.Size = new Size(119, 23);
            btnShowChart.TabIndex = 13;
            btnShowChart.Text = "Графики";
            btnShowChart.UseVisualStyleBackColor = true;
            btnShowChart.Click += btnShowChart_Click;
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.AutoSize = true;
            lblTotalQuantity.Location = new Point(11, 18);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(0, 17);
            lblTotalQuantity.TabIndex = 14;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(11, 49);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 17);
            lblTotalAmount.TabIndex = 15;
            // 
            // lblAveragePrice
            // 
            lblAveragePrice.AutoSize = true;
            lblAveragePrice.Location = new Point(192, 21);
            lblAveragePrice.Name = "lblAveragePrice";
            lblAveragePrice.Size = new Size(0, 17);
            lblAveragePrice.TabIndex = 16;
            // 
            // lblMinPrice
            // 
            lblMinPrice.AutoSize = true;
            lblMinPrice.Location = new Point(192, 49);
            lblMinPrice.Name = "lblMinPrice";
            lblMinPrice.Size = new Size(0, 17);
            lblMinPrice.TabIndex = 17;
            // 
            // lblMaxPrice
            // 
            lblMaxPrice.AutoSize = true;
            lblMaxPrice.Location = new Point(400, 21);
            lblMaxPrice.Name = "lblMaxPrice";
            lblMaxPrice.Size = new Size(0, 17);
            lblMaxPrice.TabIndex = 18;
            // 
            // lblMinQuantity
            // 
            lblMinQuantity.AutoSize = true;
            lblMinQuantity.Location = new Point(400, 49);
            lblMinQuantity.Name = "lblMinQuantity";
            lblMinQuantity.Size = new Size(0, 17);
            lblMinQuantity.TabIndex = 19;
            // 
            // lblMaxQuantity
            // 
            lblMaxQuantity.AutoSize = true;
            lblMaxQuantity.Location = new Point(585, 456);
            lblMaxQuantity.Name = "lblMaxQuantity";
            lblMaxQuantity.Size = new Size(0, 17);
            lblMaxQuantity.TabIndex = 20;
            // 
            // groupBoxStatistis_AD
            // 
            groupBoxStatistis_AD.Controls.Add(statifnolb);
            groupBoxStatistis_AD.Controls.Add(lblTotalQuantity);
            groupBoxStatistis_AD.Controls.Add(lblMinQuantity);
            groupBoxStatistis_AD.Controls.Add(lblTotalAmount);
            groupBoxStatistis_AD.Controls.Add(lblMaxPrice);
            groupBoxStatistis_AD.Controls.Add(lblAveragePrice);
            groupBoxStatistis_AD.Controls.Add(lblMinPrice);
            groupBoxStatistis_AD.Location = new Point(0, 435);
            groupBoxStatistis_AD.Name = "groupBoxStatistis_AD";
            groupBoxStatistis_AD.Size = new Size(777, 110);
            groupBoxStatistis_AD.TabIndex = 21;
            groupBoxStatistis_AD.TabStop = false;
            groupBoxStatistis_AD.Text = "Статистика:";
            // 
            // statifnolb
            // 
            statifnolb.AutoSize = true;
            statifnolb.Location = new Point(321, 38);
            statifnolb.Name = "statifnolb";
            statifnolb.Size = new Size(140, 17);
            statifnolb.TabIndex = 20;
            statifnolb.Text = "Статистка отсутсвует";
            // 
            // pictureInfo
            // 
            pictureInfo.BackColor = Color.Transparent;
            pictureInfo.Image = (Image)resources.GetObject("pictureInfo.Image");
            pictureInfo.Location = new Point(439, 214);
            pictureInfo.Name = "pictureInfo";
            pictureInfo.Size = new Size(249, 215);
            pictureInfo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureInfo.TabIndex = 22;
            pictureInfo.TabStop = false;
            // 
            // FormMain_AD
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(914, 510);
            Controls.Add(pictureInfo);
            Controls.Add(lblMaxQuantity);
            Controls.Add(btnShowChart);
            Controls.Add(btnReset_AD);
            Controls.Add(cmbSearchColumns);
            Controls.Add(btnSearch_AD);
            Controls.Add(labelInfoFile_AD);
            Controls.Add(dataGridFile_AD);
            Controls.Add(label1);
            Controls.Add(txtSearch_AD);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(groupBoxStatistis_AD);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.InfoText;
            Name = "FormMain_AD";
            Text = "Главная";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFile_AD).EndInit();
            groupBoxStatistis_AD.ResumeLayout(false);
            groupBoxStatistis_AD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolItem_AD;
        private ToolStripMenuItem OpenFileTool_AD;
        private ToolStripMenuItem SaveFileToll_AD;
        private ToolStripMenuItem InfoTool_AD;
        private ToolStripMenuItem fAQToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem ExitTool_AD;
        private ToolStrip toolStrip1;
        private ToolStripButton AddDatainFile_AD;
        private ToolStripButton EditDataInFile_AD;
        private ToolStripButton DeleteDataInFile_AD;
        private TextBox txtSearch_AD;
        private Label label1;
        private DataGridView dataGridFile_AD;
        private ToolStripButton SortDataInFile_AD;
        private Label labelInfoFile_AD;
        private Button btnSearch_AD;
        private ComboBox cmbSearchColumns;
        private Button btnReset_AD;
        private Button btnShowChart;
        private Label lblTotalQuantity;
        private Label lblTotalAmount;
        private Label lblAveragePrice;
        private Label lblMinPrice;
        private Label lblMaxPrice;
        private Label lblMinQuantity;
        private Label lblMaxQuantity;
        private GroupBox groupBoxStatistis_AD;
        private Label statifnolb;
        private PictureBox pictureInfo;
    }
}
