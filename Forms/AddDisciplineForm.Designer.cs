namespace Diploma.Forms
{
    partial class AddDisciplineForm
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
            System.Windows.Forms.Label classLabel;
            System.Windows.Forms.Label nameLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.disciplinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maskedTextBoxClass = new System.Windows.Forms.MaskedTextBox();
            classLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new System.Drawing.Point(12, 19);
            classLabel.Name = "classLabel";
            classLabel.Size = new System.Drawing.Size(38, 13);
            classLabel.TabIndex = 1;
            classLabel.Text = "Класс";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(104, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(57, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Название";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(167, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // disciplinesBindingSource
            // 
            this.disciplinesBindingSource.DataSource = typeof(Diploma.Disciplines);
            // 
            // maskedTextBoxClass
            // 
            this.maskedTextBoxClass.Location = new System.Drawing.Point(56, 16);
            this.maskedTextBoxClass.Mask = "00";
            this.maskedTextBoxClass.Name = "maskedTextBoxClass";
            this.maskedTextBoxClass.Size = new System.Drawing.Size(22, 20);
            this.maskedTextBoxClass.TabIndex = 6;
            // 
            // AddDisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 93);
            this.Controls.Add(this.maskedTextBoxClass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(classLabel);
            this.Name = "AddDisciplineForm";
            this.Text = "AddDisciplineForm";
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource disciplinesBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxClass;
    }
}