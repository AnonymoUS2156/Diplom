namespace Diploma
{
    partial class AddBookForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.textBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.disciplinesComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxISBN = new System.Windows.Forms.MaskedTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.author_SignTextBox = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.publishersComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Depth = 0;
            this.buttonBack.Location = new System.Drawing.Point(78, 354);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(127, 45);
            this.buttonBack.TabIndex = 41;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click_1);
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(425, 207);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(139, 21);
            this.comboBoxAuthors.TabIndex = 64;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(426, 245);
            this.textBoxYear.Mask = "0000";
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(35, 20);
            this.textBoxYear.TabIndex = 60;
            // 
            // disciplinesComboBox
            // 
            this.disciplinesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplinesComboBox.FormattingEnabled = true;
            this.disciplinesComboBox.Location = new System.Drawing.Point(426, 164);
            this.disciplinesComboBox.Name = "disciplinesComboBox";
            this.disciplinesComboBox.Size = new System.Drawing.Size(139, 21);
            this.disciplinesComboBox.TabIndex = 57;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(92, 229);
            this.textBoxISBN.Mask = "00000000000";
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(84, 20);
            this.textBoxISBN.TabIndex = 53;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(426, 76);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 20);
            this.textBoxName.TabIndex = 51;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Location = new System.Drawing.Point(398, 354);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = true;
            this.buttonAdd.Size = new System.Drawing.Size(127, 45);
            this.buttonAdd.TabIndex = 65;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(92, 304);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(51, 20);
            this.priceTextBox.TabIndex = 67;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(426, 287);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(35, 20);
            this.maskedTextBox1.TabIndex = 69;
            // 
            // author_SignTextBox
            // 
            this.author_SignTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author_Sign", true));
            this.author_SignTextBox.Location = new System.Drawing.Point(155, 267);
            this.author_SignTextBox.Name = "author_SignTextBox";
            this.author_SignTextBox.Size = new System.Drawing.Size(100, 20);
            this.author_SignTextBox.TabIndex = 70;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(35, 230);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 18);
            this.materialLabel1.TabIndex = 71;
            this.materialLabel1.Text = "ISBN:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(26, 268);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 18);
            this.materialLabel2.TabIndex = 72;
            this.materialLabel2.Text = "Авторский знак";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(34, 304);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(43, 18);
            this.materialLabel3.TabIndex = 73;
            this.materialLabel3.Text = "Цена";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(335, 76);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(84, 18);
            this.materialLabel4.TabIndex = 74;
            this.materialLabel4.Text = "Заголовок";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(343, 118);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(76, 18);
            this.materialLabel5.TabIndex = 75;
            this.materialLabel5.Text = "Издатель";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(337, 164);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(81, 18);
            this.materialLabel6.TabIndex = 76;
            this.materialLabel6.Text = "Предметы";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(367, 207);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(49, 18);
            this.materialLabel7.TabIndex = 77;
            this.materialLabel7.Text = "Автор";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(379, 244);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(35, 18);
            this.materialLabel8.TabIndex = 78;
            this.materialLabel8.Text = "Год";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(335, 287);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(77, 18);
            this.materialLabel9.TabIndex = 79;
            this.materialLabel9.Text = "Страницы";
            // 
            // publishersComboBox
            // 
            this.publishersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publishersComboBox.FormattingEnabled = true;
            this.publishersComboBox.Location = new System.Drawing.Point(427, 116);
            this.publishersComboBox.Name = "publishersComboBox";
            this.publishersComboBox.Size = new System.Drawing.Size(139, 21);
            this.publishersComboBox.TabIndex = 80;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Location = new System.Drawing.Point(59, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Diploma.Models.Book);
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(Diploma.Models.Author);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(Diploma.Models.Model1);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 420);
            this.Controls.Add(this.publishersComboBox);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.author_SignTextBox);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.disciplinesComboBox);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonBack);
            this.MaximumSize = new System.Drawing.Size(614, 420);
            this.MinimumSize = new System.Drawing.Size(614, 420);
            this.Name = "AddBookForm";
            this.Text = "Добавить книгу";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.MaskedTextBox textBoxYear;
        private System.Windows.Forms.ComboBox disciplinesComboBox;
        private System.Windows.Forms.MaskedTextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAdd;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox author_SignTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.ComboBox publishersComboBox;
    }
}