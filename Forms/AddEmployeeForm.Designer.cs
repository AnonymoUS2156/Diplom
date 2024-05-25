namespace Diploma.Forms
{
    partial class AddEmployeeForm
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
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label secondNameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label reservedBookIDLabel;
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.isReservedCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservedBookIDTextBox = new System.Windows.Forms.TextBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            phoneLabel1 = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            secondNameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            reservedBookIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(190, 15);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(52, 13);
            phoneLabel1.TabIndex = 23;
            phoneLabel1.Text = "Телефон";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(248, 12);
            this.phoneMaskedTextBox.Mask = "+7 (999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneMaskedTextBox.TabIndex = 25;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(207, 41);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(248, 38);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 24;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(13, 15);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(56, 13);
            surnameLabel.TabIndex = 20;
            surnameLabel.Text = "Фамилия";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(71, 12);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 21;
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.Location = new System.Drawing.Point(11, 73);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new System.Drawing.Size(54, 13);
            secondNameLabel.TabIndex = 17;
            secondNameLabel.Text = "Отчество";
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "SecondName", true));
            this.secondNameTextBox.Location = new System.Drawing.Point(71, 70);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondNameTextBox.TabIndex = 19;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(36, 47);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(29, 13);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Имя";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(71, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 18;
            // 
            // isReservedCheckBox
            // 
            this.isReservedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeeBindingSource, "IsReserved", true));
            this.isReservedCheckBox.Location = new System.Drawing.Point(382, 10);
            this.isReservedCheckBox.Name = "isReservedCheckBox";
            this.isReservedCheckBox.Size = new System.Drawing.Size(154, 24);
            this.isReservedCheckBox.TabIndex = 27;
            this.isReservedCheckBox.Text = "Зарезервирована книга";
            this.isReservedCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(478, 78);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(101, 28);
            this.buttonAddEmployee.TabIndex = 29;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(247, 78);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(101, 28);
            this.buttonBack.TabIndex = 30;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Diploma.Employee);
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(554, 15);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(95, 13);
            nameLabel1.TabIndex = 31;
            nameLabel1.Text = "Название отдела";
            // 
            // reservedBookIDTextBox
            // 
            this.reservedBookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ReservedBookID", true));
            this.reservedBookIDTextBox.Location = new System.Drawing.Point(487, 38);
            this.reservedBookIDTextBox.Name = "reservedBookIDTextBox";
            this.reservedBookIDTextBox.ReadOnly = true;
            this.reservedBookIDTextBox.Size = new System.Drawing.Size(29, 20);
            this.reservedBookIDTextBox.TabIndex = 28;
            // 
            // reservedBookIDLabel
            // 
            reservedBookIDLabel.AutoSize = true;
            reservedBookIDLabel.Location = new System.Drawing.Point(383, 43);
            reservedBookIDLabel.Name = "reservedBookIDLabel";
            reservedBookIDLabel.Size = new System.Drawing.Size(98, 13);
            reservedBookIDLabel.TabIndex = 26;
            reservedBookIDLabel.Text = "Reserved Book ID:";
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Department1.Name", true));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(557, 38);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(92, 21);
            this.nameComboBox.TabIndex = 32;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 116);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(phoneLabel1);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(secondNameLabel);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(reservedBookIDLabel);
            this.Controls.Add(this.reservedBookIDTextBox);
            this.Controls.Add(this.isReservedCheckBox);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox isReservedCheckBox;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox reservedBookIDTextBox;
        private System.Windows.Forms.ComboBox nameComboBox;
    }
}