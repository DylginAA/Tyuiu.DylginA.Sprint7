namespace Tyuiu.DylginA.Sprint7.Project.V5
{
    partial class SortForm
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
            cmbColumns = new ComboBox();
            label1 = new Label();
            rbtnAscending = new RadioButton();
            rbtnDescending = new RadioButton();
            btnApplySort = new Button();
            btnCancelSort = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbColumns
            // 
            cmbColumns.FormattingEnabled = true;
            cmbColumns.Location = new Point(115, 28);
            cmbColumns.Name = "cmbColumns";
            cmbColumns.Size = new Size(121, 23);
            cmbColumns.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 31);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Сортировать по: ";
            // 
            // rbtnAscending
            // 
            rbtnAscending.AutoSize = true;
            rbtnAscending.Location = new Point(12, 75);
            rbtnAscending.Name = "rbtnAscending";
            rbtnAscending.Size = new Size(116, 19);
            rbtnAscending.TabIndex = 2;
            rbtnAscending.TabStop = true;
            rbtnAscending.Text = "По возрастанию";
            rbtnAscending.UseVisualStyleBackColor = true;
            // 
            // rbtnDescending
            // 
            rbtnDescending.AutoSize = true;
            rbtnDescending.Location = new Point(134, 75);
            rbtnDescending.Name = "rbtnDescending";
            rbtnDescending.Size = new Size(102, 19);
            rbtnDescending.TabIndex = 3;
            rbtnDescending.TabStop = true;
            rbtnDescending.Text = "По убыванию";
            rbtnDescending.UseVisualStyleBackColor = true;
            // 
            // btnApplySort
            // 
            btnApplySort.Location = new Point(348, 126);
            btnApplySort.Name = "btnApplySort";
            btnApplySort.Size = new Size(91, 23);
            btnApplySort.TabIndex = 4;
            btnApplySort.Text = "Применить";
            btnApplySort.UseVisualStyleBackColor = true;
            btnApplySort.Click += btnApplySort_Click;
            // 
            // btnCancelSort
            // 
            btnCancelSort.Location = new Point(251, 126);
            btnCancelSort.Name = "btnCancelSort";
            btnCancelSort.Size = new Size(91, 23);
            btnCancelSort.TabIndex = 5;
            btnCancelSort.Text = "Отмена";
            btnCancelSort.UseVisualStyleBackColor = true;
            btnCancelSort.Click += btnCancelSort_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(251, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 75);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // SortForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(451, 161);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelSort);
            Controls.Add(btnApplySort);
            Controls.Add(rbtnDescending);
            Controls.Add(rbtnAscending);
            Controls.Add(label1);
            Controls.Add(cmbColumns);
            Name = "SortForm";
            Text = "Сортировка";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbColumns;
        private Label label1;
        private RadioButton rbtnAscending;
        private RadioButton rbtnDescending;
        private Button btnApplySort;
        private Button btnCancelSort;
        private PictureBox pictureBox1;
    }
}