namespace Tyuiu.DylginA.Sprint7.Project.V5
{
    partial class AddProductForm
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
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtNote = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(78, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(156, 23);
            txtName.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(78, 176);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(156, 23);
            txtQuantity.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(78, 241);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(156, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(78, 302);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(156, 23);
            txtNote.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(82, 369);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 96);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 6;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 158);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 7;
            label2.Text = "Количетсво";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 223);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 8;
            label3.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 284);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 9;
            label4.Text = "Примечание";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(312, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtNote);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Name = "AddProductForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtNote;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}