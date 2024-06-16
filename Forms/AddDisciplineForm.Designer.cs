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
            System.Windows.Forms.Label nameLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.disciplinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(88, 79);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(57, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Название";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(151, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 115);
            this.button1.MaximumSize = new System.Drawing.Size(110, 36);
            this.button1.MinimumSize = new System.Drawing.Size(110, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // disciplinesBindingSource
            // 
            this.disciplinesBindingSource.DataSource = typeof(Diploma.Models.Disciplines);
            // 
            // AddDisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 172);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.MaximumSize = new System.Drawing.Size(359, 172);
            this.MinimumSize = new System.Drawing.Size(359, 172);
            this.Name = "AddDisciplineForm";
            this.Text = "Добавить предмет";
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource disciplinesBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}