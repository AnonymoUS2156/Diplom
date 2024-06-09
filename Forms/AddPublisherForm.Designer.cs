namespace Diploma.Forms
{
    partial class AddPublisherForm
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
            this.buttonAddEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Адрес = new MaterialSkin.Controls.MaterialLabel();
            this.Название = new MaterialSkin.Controls.MaterialLabel();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.siteTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Depth = 0;
            this.buttonAddEmployee.Location = new System.Drawing.Point(172, 248);
            this.buttonAddEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Primary = true;
            this.buttonAddEmployee.Size = new System.Drawing.Size(109, 32);
            this.buttonAddEmployee.TabIndex = 59;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Depth = 0;
            this.buttonBack.Location = new System.Drawing.Point(12, 248);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(109, 32);
            this.buttonBack.TabIndex = 58;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(47, 167);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(72, 18);
            this.materialLabel5.TabIndex = 55;
            this.materialLabel5.Text = "Телефон";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(60, 202);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(49, 18);
            this.materialLabel4.TabIndex = 54;
            this.materialLabel4.Text = "Email:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(68, 133);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(42, 18);
            this.materialLabel3.TabIndex = 53;
            this.materialLabel3.Text = "Сайт";
            // 
            // Адрес
            // 
            this.Адрес.AutoSize = true;
            this.Адрес.Depth = 0;
            this.Адрес.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Адрес.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Адрес.Location = new System.Drawing.Point(51, 104);
            this.Адрес.MouseState = MaterialSkin.MouseState.HOVER;
            this.Адрес.Name = "Адрес";
            this.Адрес.Size = new System.Drawing.Size(50, 18);
            this.Адрес.TabIndex = 52;
            this.Адрес.Text = "Адрес";
            // 
            // Название
            // 
            this.Название.AutoSize = true;
            this.Название.Depth = 0;
            this.Название.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Название.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Название.Location = new System.Drawing.Point(36, 73);
            this.Название.MouseState = MaterialSkin.MouseState.HOVER;
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(75, 18);
            this.Название.TabIndex = 51;
            this.Название.Text = "Название";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(125, 167);
            this.phoneMaskedTextBox.Mask = "+7 (999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(109, 20);
            this.phoneMaskedTextBox.TabIndex = 48;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(125, 201);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(109, 20);
            this.emailTextBox.TabIndex = 47;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Surname", true));
            this.nameTextBox.Location = new System.Drawing.Point(125, 74);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(109, 20);
            this.nameTextBox.TabIndex = 46;
            // 
            // siteTextBox
            // 
            this.siteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "SecondName", true));
            this.siteTextBox.Location = new System.Drawing.Point(125, 132);
            this.siteTextBox.Name = "siteTextBox";
            this.siteTextBox.Size = new System.Drawing.Size(109, 20);
            this.siteTextBox.TabIndex = 45;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.adressTextBox.Location = new System.Drawing.Point(125, 103);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(109, 20);
            this.adressTextBox.TabIndex = 44;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Diploma.Models.Employee);
            // 
            // AddPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 301);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.Адрес);
            this.Controls.Add(this.Название);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.siteTextBox);
            this.Controls.Add(this.adressTextBox);
            this.MaximumSize = new System.Drawing.Size(301, 301);
            this.MinimumSize = new System.Drawing.Size(301, 301);
            this.Name = "AddPublisherForm";
            this.Text = "AddPublisherForm";
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAddEmployee;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel Адрес;
        private MaterialSkin.Controls.MaterialLabel Название;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox siteTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
    }
}