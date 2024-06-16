namespace Diploma.Forms
{
    partial class AddAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthorForm));
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonAddBook = new MaterialSkin.Controls.MaterialRaisedButton();
            this.abbreviationTextBox = new System.Windows.Forms.TextBox();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel6
            // 
            resources.ApplyResources(this.materialLabel6, "materialLabel6");
            this.materialLabel6.Depth = 0;
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.Depth = 0;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // buttonBack
            // 
            resources.ApplyResources(this.buttonBack, "buttonBack");
            this.buttonBack.Depth = 0;
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonAddBook
            // 
            resources.ApplyResources(this.buttonAddBook, "buttonAddBook");
            this.buttonAddBook.Depth = 0;
            this.buttonAddBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Primary = true;
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // abbreviationTextBox
            // 
            resources.ApplyResources(this.abbreviationTextBox, "abbreviationTextBox");
            this.abbreviationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "Abbreviation", true));
            this.abbreviationTextBox.Name = "abbreviationTextBox";
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(Diploma.Models.Author);
            // 
            // genderComboBox
            // 
            resources.ApplyResources(this.genderComboBox, "genderComboBox");
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Name = "genderComboBox";
            // 
            // birthdayDateTimePicker
            // 
            resources.ApplyResources(this.birthdayDateTimePicker, "birthdayDateTimePicker");
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.authorBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.MaxDate = new System.DateTime(2024, 6, 3, 0, 0, 0, 0);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Value = new System.DateTime(2024, 6, 3, 0, 0, 0, 0);
            // 
            // surnameTextBox
            // 
            resources.ApplyResources(this.surnameTextBox, "surnameTextBox");
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "Surname", true));
            this.surnameTextBox.Name = "surnameTextBox";
            // 
            // secondNameTextBox
            // 
            resources.ApplyResources(this.secondNameTextBox, "secondNameTextBox");
            this.secondNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "SecondName", true));
            this.secondNameTextBox.Name = "secondNameTextBox";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "Name", true));
            this.nameTextBox.Name = "nameTextBox";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Diploma.Models.Book);
            // 
            // AddAuthorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.abbreviationTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddAuthorForm";
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAddBook;
        private System.Windows.Forms.TextBox abbreviationTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}