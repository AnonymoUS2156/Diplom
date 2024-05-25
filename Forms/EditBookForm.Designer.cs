namespace Diploma.Forms
{
    partial class EditBookForm
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
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label disciplinesLabel1;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label yearLabel1;
            System.Windows.Forms.Label Заголовок;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxISBN = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.disciplinesComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            iSBNLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            disciplinesLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            yearLabel1 = new System.Windows.Forms.Label();
            Заголовок = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(12, 180);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 4;
            iSBNLabel.Text = "ISBN:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(266, 73);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(56, 13);
            nameLabel1.TabIndex = 6;
            nameLabel1.Text = "Издатель";
            // 
            // disciplinesLabel1
            // 
            disciplinesLabel1.AutoSize = true;
            disciplinesLabel1.Location = new System.Drawing.Point(262, 119);
            disciplinesLabel1.Name = "disciplinesLabel1";
            disciplinesLabel1.Size = new System.Drawing.Size(60, 13);
            disciplinesLabel1.TabIndex = 9;
            disciplinesLabel1.Text = "Предметы";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(283, 162);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(37, 13);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Автор";
            // 
            // yearLabel1
            // 
            yearLabel1.AutoSize = true;
            yearLabel1.Location = new System.Drawing.Point(289, 200);
            yearLabel1.Name = "yearLabel1";
            yearLabel1.Size = new System.Drawing.Size(32, 13);
            yearLabel1.TabIndex = 14;
            yearLabel1.Text = "Year:";
            // 
            // Заголовок
            // 
            Заголовок.AutoSize = true;
            Заголовок.Location = new System.Drawing.Point(260, 31);
            Заголовок.Name = "Заголовок";
            Заголовок.Size = new System.Drawing.Size(61, 13);
            Заголовок.TabIndex = 2;
            Заголовок.Text = "Заголовок";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Diploma.Book);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "ISBN", true));
            this.textBoxISBN.Location = new System.Drawing.Point(58, 177);
            this.textBoxISBN.Mask = "0000000000000";
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(87, 20);
            this.textBoxISBN.TabIndex = 5;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Publisher.Name", true));
            this.textBoxPublisher.Location = new System.Drawing.Point(327, 70);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(140, 20);
            this.textBoxPublisher.TabIndex = 7;
            this.textBoxPublisher.Text = " ";
            // 
            // disciplinesComboBox
            // 
            this.disciplinesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Disciplines", true));
            this.disciplinesComboBox.FormattingEnabled = true;
            this.disciplinesComboBox.Location = new System.Drawing.Point(328, 116);
            this.disciplinesComboBox.Name = "disciplinesComboBox";
            this.disciplinesComboBox.Size = new System.Drawing.Size(139, 21);
            this.disciplinesComboBox.TabIndex = 10;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author.Name", true));
            this.textBoxAuthor.Location = new System.Drawing.Point(327, 159);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(140, 20);
            this.textBoxAuthor.TabIndex = 11;
            // 
            // textBoxYear
            // 
            this.textBoxYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Year", true));
            this.textBoxYear.Location = new System.Drawing.Point(327, 197);
            this.textBoxYear.Mask = "0000";
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(35, 20);
            this.textBoxYear.TabIndex = 15;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(15, 260);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(141, 41);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "Провести изменение";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(340, 245);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(141, 41);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Name", true));
            this.textBoxName.Location = new System.Drawing.Point(327, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 358);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(yearLabel1);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(disciplinesLabel1);
            this.Controls.Add(this.disciplinesComboBox);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(Заголовок);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.MaskedTextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.ComboBox disciplinesComboBox;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.MaskedTextBox textBoxYear;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxName;
    }
}