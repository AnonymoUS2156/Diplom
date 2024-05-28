namespace Diploma
{
    partial class MainForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.comboBoxAtributesSort = new System.Windows.Forms.ComboBox();
            this.button2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonAddBook = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonAddPublisher = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonAddDicipline = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(581, 361);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(612, 186);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(169, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.Text = "Поиск";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.AutoCompleteCustomSource.AddRange(new string[] {
            "По уменьшению",
            "По возрастанию"});
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(612, 227);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(169, 21);
            this.comboBoxSort.TabIndex = 3;
            this.comboBoxSort.Text = "Сортировка";
            // 
            // comboBoxAtributesSort
            // 
            this.comboBoxAtributesSort.FormattingEnabled = true;
            this.comboBoxAtributesSort.Items.AddRange(new object[] {
            "По уменьшению",
            "По увеличению"});
            this.comboBoxAtributesSort.Location = new System.Drawing.Point(612, 276);
            this.comboBoxAtributesSort.Name = "comboBoxAtributesSort";
            this.comboBoxAtributesSort.Size = new System.Drawing.Size(169, 21);
            this.comboBoxAtributesSort.TabIndex = 3;
            this.comboBoxAtributesSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxAtributesSort_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Depth = 0;
            this.button2.Location = new System.Drawing.Point(639, 390);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Primary = true;
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(142, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Список читателей";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Depth = 0;
            this.buttonAddBook.Location = new System.Drawing.Point(588, 77);
            this.buttonAddBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Primary = true;
            this.buttonAddBook.Size = new System.Drawing.Size(124, 36);
            this.buttonAddBook.TabIndex = 5;
            this.buttonAddBook.Text = "Добавить книгу";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonAddPublisher
            // 
            this.buttonAddPublisher.Depth = 0;
            this.buttonAddPublisher.Location = new System.Drawing.Point(588, 132);
            this.buttonAddPublisher.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddPublisher.Name = "buttonAddPublisher";
            this.buttonAddPublisher.Primary = true;
            this.buttonAddPublisher.Size = new System.Drawing.Size(124, 35);
            this.buttonAddPublisher.TabIndex = 7;
            this.buttonAddPublisher.Text = "Добавить издательство";
            this.buttonAddPublisher.UseVisualStyleBackColor = true;
            this.buttonAddPublisher.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // buttonAddDicipline
            // 
            this.buttonAddDicipline.Depth = 0;
            this.buttonAddDicipline.Location = new System.Drawing.Point(723, 132);
            this.buttonAddDicipline.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddDicipline.Name = "buttonAddDicipline";
            this.buttonAddDicipline.Primary = true;
            this.buttonAddDicipline.Size = new System.Drawing.Size(124, 35);
            this.buttonAddDicipline.TabIndex = 8;
            this.buttonAddDicipline.Text = "Добавить предмет";
            this.buttonAddDicipline.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(723, 78);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(124, 35);
            this.materialRaisedButton4.TabIndex = 9;
            this.materialRaisedButton4.Text = "Добавить автора";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.buttonAddDicipline);
            this.Controls.Add(this.buttonAddPublisher);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxAtributesSort);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.ComboBox comboBoxAtributesSort;
        private MaterialSkin.Controls.MaterialRaisedButton button2;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAddBook;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAddPublisher;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAddDicipline;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
    }
}