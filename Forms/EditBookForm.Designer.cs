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
            this.textBoxISBN = new System.Windows.Forms.MaskedTextBox();
            this.disciplinesComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iSBNLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            disciplinesLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            yearLabel1 = new System.Windows.Forms.Label();
            Заголовок = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(26, 222);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 4;
            iSBNLabel.Text = "ISBN:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(269, 128);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(56, 13);
            nameLabel1.TabIndex = 6;
            nameLabel1.Text = "Издатель";
            // 
            // disciplinesLabel1
            // 
            disciplinesLabel1.AutoSize = true;
            disciplinesLabel1.Location = new System.Drawing.Point(265, 174);
            disciplinesLabel1.Name = "disciplinesLabel1";
            disciplinesLabel1.Size = new System.Drawing.Size(60, 13);
            disciplinesLabel1.TabIndex = 9;
            disciplinesLabel1.Text = "Предметы";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(286, 217);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(37, 13);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Автор";
            // 
            // yearLabel1
            // 
            yearLabel1.AutoSize = true;
            yearLabel1.Location = new System.Drawing.Point(292, 255);
            yearLabel1.Name = "yearLabel1";
            yearLabel1.Size = new System.Drawing.Size(28, 13);
            yearLabel1.TabIndex = 14;
            yearLabel1.Text = "Год:";
            // 
            // Заголовок
            // 
            Заголовок.AutoSize = true;
            Заголовок.Location = new System.Drawing.Point(263, 86);
            Заголовок.Name = "Заголовок";
            Заголовок.Size = new System.Drawing.Size(61, 13);
            Заголовок.TabIndex = 2;
            Заголовок.Text = "Заголовок";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "ISBN", true));
            this.textBoxISBN.Location = new System.Drawing.Point(72, 219);
            this.textBoxISBN.Mask = "0000000000000";
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(84, 20);
            this.textBoxISBN.TabIndex = 5;
            // 
            // disciplinesComboBox
            // 
            this.disciplinesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Disciplines", true));
            this.disciplinesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplinesComboBox.FormattingEnabled = true;
            this.disciplinesComboBox.Location = new System.Drawing.Point(330, 171);
            this.disciplinesComboBox.Name = "disciplinesComboBox";
            this.disciplinesComboBox.Size = new System.Drawing.Size(139, 21);
            this.disciplinesComboBox.TabIndex = 10;
            // 
            // textBoxYear
            // 
            this.textBoxYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Year", true));
            this.textBoxYear.Location = new System.Drawing.Point(330, 252);
            this.textBoxYear.Mask = "0000";
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(35, 20);
            this.textBoxYear.TabIndex = 15;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(15, 291);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(141, 41);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(181, 316);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(141, 41);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Провести изменение";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Name", true));
            this.textBoxName.Location = new System.Drawing.Point(330, 83);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(341, 291);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(141, 41);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(329, 214);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(139, 21);
            this.comboBoxAuthors.TabIndex = 17;
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(331, 125);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(139, 21);
            this.comboBoxPublisher.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(15, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Diploma.Models.Book);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(Diploma.Models.Model1);
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 369);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(yearLabel1);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(nameLabel);
            this.Controls.Add(disciplinesLabel1);
            this.Controls.Add(this.comboBoxPublisher);
            this.Controls.Add(this.disciplinesComboBox);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(Заголовок);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(509, 369);
            this.MinimumSize = new System.Drawing.Size(509, 369);
            this.Name = "EditBookForm";
            this.Text = "Редактирование книги";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.MaskedTextBox textBoxISBN;
        private System.Windows.Forms.ComboBox disciplinesComboBox;
        private System.Windows.Forms.MaskedTextBox textBoxYear;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.ComboBox comboBoxPublisher;
    }
}