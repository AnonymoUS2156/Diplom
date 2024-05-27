namespace Diploma.Forms
{
    partial class Readers
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label secondNameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label labelName;
            System.Windows.Forms.Label labelSecondName;
            System.Windows.Forms.Label labelPhone;
            System.Windows.Forms.Label labelEmail;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label labelDepartment;
            System.Windows.Forms.Label reservedBookIDLabel;
            System.Windows.Forms.Label labelReservedBookName;
            System.Windows.Forms.Label isReservedLabel;
            this.isReservedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            secondNameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            labelSecondName = new System.Windows.Forms.Label();
            labelPhone = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            labelDepartment = new System.Windows.Forms.Label();
            reservedBookIDLabel = new System.Windows.Forms.Label();
            labelReservedBookName = new System.Windows.Forms.Label();
            isReservedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(183, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(29, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Имя";
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.Location = new System.Drawing.Point(305, 11);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new System.Drawing.Size(54, 13);
            secondNameLabel.TabIndex = 2;
            secondNameLabel.Text = "Отчество";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(10, 11);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(56, 13);
            surnameLabel.TabIndex = 4;
            surnameLabel.Text = "Фамилия";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(177, 40);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(14, 40);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(52, 13);
            phoneLabel1.TabIndex = 12;
            phoneLabel1.Text = "Телефон";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(218, 11);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(29, 13);
            labelName.TabIndex = 14;
            labelName.Text = "Имя";
            // 
            // labelSecondName
            // 
            labelSecondName.AutoSize = true;
            labelSecondName.Location = new System.Drawing.Point(365, 11);
            labelSecondName.Name = "labelSecondName";
            labelSecondName.Size = new System.Drawing.Size(54, 13);
            labelSecondName.TabIndex = 15;
            labelSecondName.Text = "Отчество";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new System.Drawing.Point(76, 40);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new System.Drawing.Size(52, 13);
            labelPhone.TabIndex = 16;
            labelPhone.Text = "Телефон";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new System.Drawing.Point(218, 40);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(35, 13);
            labelEmail.TabIndex = 17;
            labelEmail.Text = "Email:";
            labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(311, 40);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(38, 13);
            label6.TabIndex = 18;
            label6.Text = "Отдел";
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Location = new System.Drawing.Point(352, 40);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new System.Drawing.Size(35, 13);
            labelDepartment.TabIndex = 19;
            labelDepartment.Text = "пусто";
            // 
            // reservedBookIDLabel
            // 
            reservedBookIDLabel.AutoSize = true;
            reservedBookIDLabel.Location = new System.Drawing.Point(421, 40);
            reservedBookIDLabel.Name = "reservedBookIDLabel";
            reservedBookIDLabel.Size = new System.Drawing.Size(89, 13);
            reservedBookIDLabel.TabIndex = 19;
            reservedBookIDLabel.Text = "Название книги";
            // 
            // labelReservedBookName
            // 
            labelReservedBookName.AutoSize = true;
            labelReservedBookName.Location = new System.Drawing.Point(516, 40);
            labelReservedBookName.Name = "labelReservedBookName";
            labelReservedBookName.Size = new System.Drawing.Size(89, 13);
            labelReservedBookName.TabIndex = 20;
            labelReservedBookName.Text = "Название книги";
            // 
            // isReservedLabel
            // 
            isReservedLabel.AutoSize = true;
            isReservedLabel.Location = new System.Drawing.Point(440, 11);
            isReservedLabel.Name = "isReservedLabel";
            isReservedLabel.Size = new System.Drawing.Size(132, 13);
            isReservedLabel.TabIndex = 20;
            isReservedLabel.Text = "Резервированные книги";
            // 
            // isReservedCheckBox
            // 
            this.isReservedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeeBindingSource, "IsReserved", true));
            this.isReservedCheckBox.Location = new System.Drawing.Point(578, 6);
            this.isReservedCheckBox.Name = "isReservedCheckBox";
            this.isReservedCheckBox.Size = new System.Drawing.Size(17, 24);
            this.isReservedCheckBox.TabIndex = 21;
            this.isReservedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "labelSurname";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Diploma.Employee);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "label3";
            // 
            // Readers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(isReservedLabel);
            this.Controls.Add(this.isReservedCheckBox);
            this.Controls.Add(labelReservedBookName);
            this.Controls.Add(reservedBookIDLabel);
            this.Controls.Add(labelDepartment);
            this.Controls.Add(label6);
            this.Controls.Add(labelEmail);
            this.Controls.Add(labelPhone);
            this.Controls.Add(labelSecondName);
            this.Controls.Add(labelName);
            this.Controls.Add(phoneLabel1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(secondNameLabel);
            this.Controls.Add(nameLabel);
            this.Name = "Readers";
            this.Size = new System.Drawing.Size(649, 69);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.CheckBox isReservedCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
