namespace Tyuiu.DylginA.Sprint7.Project.V5
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            linkLabel6 = new LinkLabel();
            linkLabel7 = new LinkLabel();
            textBoxAdd = new TextBox();
            textBoxDelete = new TextBox();
            textBoxEdit = new TextBox();
            textBoxSearch = new TextBox();
            textBoxSort = new TextBox();
            textBox1 = new TextBox();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(549, 330);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(15, 17);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Общая информация";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(32, 44);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(93, 15);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Добавить товар";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(32, 69);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(85, 15);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Удалить товар";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(32, 101);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(96, 15);
            linkLabel4.TabIndex = 4;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Редактирование";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Location = new Point(32, 127);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(73, 15);
            linkLabel5.TabIndex = 5;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Сортировка";
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            // 
            // linkLabel6
            // 
            linkLabel6.AutoSize = true;
            linkLabel6.Location = new Point(32, 156);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(42, 15);
            linkLabel6.TabIndex = 6;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "Поиск";
            linkLabel6.LinkClicked += linkLabel6_LinkClicked;
            // 
            // linkLabel7
            // 
            linkLabel7.AutoSize = true;
            linkLabel7.Location = new Point(32, 183);
            linkLabel7.Name = "linkLabel7";
            linkLabel7.Size = new Size(48, 15);
            linkLabel7.TabIndex = 7;
            linkLabel7.TabStop = true;
            linkLabel7.Text = "График";
            linkLabel7.LinkClicked += linkLabel7_LinkClicked;
            // 
            // textBoxAdd
            // 
            textBoxAdd.Location = new Point(239, 17);
            textBoxAdd.Multiline = true;
            textBoxAdd.Name = "textBoxAdd";
            textBoxAdd.ReadOnly = true;
            textBoxAdd.Size = new Size(463, 150);
            textBoxAdd.TabIndex = 8;
            textBoxAdd.Text = resources.GetString("textBoxAdd.Text");
            // 
            // textBoxDelete
            // 
            textBoxDelete.Location = new Point(239, 17);
            textBoxDelete.Multiline = true;
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.ReadOnly = true;
            textBoxDelete.Size = new Size(463, 150);
            textBoxDelete.TabIndex = 9;
            textBoxDelete.Text = resources.GetString("textBoxDelete.Text");
            textBoxDelete.Visible = false;
            // 
            // textBoxEdit
            // 
            textBoxEdit.Location = new Point(239, 17);
            textBoxEdit.Multiline = true;
            textBoxEdit.Name = "textBoxEdit";
            textBoxEdit.ReadOnly = true;
            textBoxEdit.Size = new Size(463, 150);
            textBoxEdit.TabIndex = 10;
            textBoxEdit.Text = resources.GetString("textBoxEdit.Text");
            textBoxEdit.Visible = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(239, 17);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.ReadOnly = true;
            textBoxSearch.Size = new Size(463, 175);
            textBoxSearch.TabIndex = 11;
            textBoxSearch.Text = resources.GetString("textBoxSearch.Text");
            textBoxSearch.Visible = false;
            // 
            // textBoxSort
            // 
            textBoxSort.Location = new Point(239, 17);
            textBoxSort.Multiline = true;
            textBoxSort.Name = "textBoxSort";
            textBoxSort.ReadOnly = true;
            textBoxSort.Size = new Size(463, 181);
            textBoxSort.TabIndex = 12;
            textBoxSort.Text = resources.GetString("textBoxSort.Text");
            textBoxSort.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 17);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(463, 181);
            textBox1.TabIndex = 13;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.Visible = false;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(15, 243);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 14;
            buttonClose.Text = "Назад";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 377);
            Controls.Add(buttonClose);
            Controls.Add(textBoxSort);
            Controls.Add(linkLabel7);
            Controls.Add(linkLabel6);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(textBoxDelete);
            Controls.Add(textBoxAdd);
            Controls.Add(textBoxEdit);
            Controls.Add(textBoxSearch);
            Controls.Add(textBox1);
            Name = "HelpForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel6;
        private LinkLabel linkLabel7;
        private TextBox textBoxAdd;
        private TextBox textBoxDelete;
        private TextBox textBoxEdit;
        private TextBox textBoxSearch;
        private TextBox textBoxSort;
        private TextBox textBox1;
        private Button buttonClose;
    }
}