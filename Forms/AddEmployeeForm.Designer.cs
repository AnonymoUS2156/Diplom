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
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.reservedBookIDTextBox = new System.Windows.Forms.TextBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.isReservedCheckBox = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonAddEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(278, 72);
            this.phoneMaskedTextBox.Mask = "+7 (999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneMaskedTextBox.TabIndex = 25;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(261, 105);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 24;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(94, 73);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 21;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "SecondName", true));
            this.secondNameTextBox.Location = new System.Drawing.Point(94, 131);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondNameTextBox.TabIndex = 19;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(85, 103);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 18;
            // 
            // reservedBookIDTextBox
            // 
            this.reservedBookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ReservedBookID", true));
            this.reservedBookIDTextBox.Location = new System.Drawing.Point(501, 105);
            this.reservedBookIDTextBox.Name = "reservedBookIDTextBox";
            this.reservedBookIDTextBox.ReadOnly = true;
            this.reservedBookIDTextBox.Size = new System.Drawing.Size(29, 20);
            this.reservedBookIDTextBox.TabIndex = 28;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Department1.Name", true));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(585, 102);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(114, 21);
            this.nameComboBox.TabIndex = 32;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 18);
            this.materialLabel1.TabIndex = 33;
            this.materialLabel1.Text = "Фамилия";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(28, 105);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(38, 18);
            this.materialLabel2.TabIndex = 34;
            this.materialLabel2.Text = "Имя";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 132);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 18);
            this.materialLabel3.TabIndex = 35;
            this.materialLabel3.Text = "Отчество";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(205, 107);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(49, 18);
            this.materialLabel4.TabIndex = 36;
            this.materialLabel4.Text = "Email:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(200, 72);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(72, 18);
            this.materialLabel5.TabIndex = 37;
            this.materialLabel5.Text = "Телефон";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(581, 75);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(129, 18);
            this.materialLabel6.TabIndex = 38;
            this.materialLabel6.Text = "Название отдела";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // isReservedCheckBox
            // 
            this.isReservedCheckBox.AutoSize = true;
            this.isReservedCheckBox.Depth = 0;
            this.isReservedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isReservedCheckBox.Location = new System.Drawing.Point(381, 67);
            this.isReservedCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.isReservedCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.isReservedCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.isReservedCheckBox.Name = "isReservedCheckBox";
            this.isReservedCheckBox.Ripple = true;
            this.isReservedCheckBox.Size = new System.Drawing.Size(184, 30);
            this.isReservedCheckBox.TabIndex = 39;
            this.isReservedCheckBox.TabStop = true;
            this.isReservedCheckBox.Text = "Зарезервирована книга";
            this.isReservedCheckBox.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(370, 107);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(120, 18);
            this.materialLabel7.TabIndex = 40;
            this.materialLabel7.Text = "ID резерв. книги";
            // 
            // buttonBack
            // 
            this.buttonBack.Depth = 0;
            this.buttonBack.Location = new System.Drawing.Point(235, 139);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(109, 32);
            this.buttonBack.TabIndex = 41;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Depth = 0;
            this.buttonAddEmployee.Location = new System.Drawing.Point(421, 139);
            this.buttonAddEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Primary = true;
            this.buttonAddEmployee.Size = new System.Drawing.Size(109, 32);
            this.buttonAddEmployee.TabIndex = 42;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Diploma.Employee);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 179);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.isReservedCheckBox);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.reservedBookIDTextBox);
            this.Name = "AddEmployeeForm";
            this.Text = "Добавить читателя";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
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
        private System.Windows.Forms.TextBox reservedBookIDTextBox;
        private System.Windows.Forms.ComboBox nameComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRadioButton isReservedCheckBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAddEmployee;
    }
}