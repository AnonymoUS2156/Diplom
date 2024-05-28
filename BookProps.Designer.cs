namespace Diploma
{
    partial class BookProps
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.labelBookName = new MaterialSkin.Controls.MaterialLabel();
            this.labelPublisher = new MaterialSkin.Controls.MaterialLabel();
            this.labelAuthorScypher = new MaterialSkin.Controls.MaterialLabel();
            this.labelAuthor = new MaterialSkin.Controls.MaterialLabel();
            this.labelISBN = new MaterialSkin.Controls.MaterialLabel();
            this.labelDiscipline = new MaterialSkin.Controls.MaterialLabel();
            this.buttonProps = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(80, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Заголовок";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(88, 30);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Издатель";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(80, 53);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(130, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Авторский шифр";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(312, 1);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(52, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Автор";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(322, 28);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(42, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "ISBN";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(303, 53);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(71, 19);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "Предмет";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Depth = 0;
            this.labelBookName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBookName.Location = new System.Drawing.Point(171, 3);
            this.labelBookName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(49, 19);
            this.labelBookName.TabIndex = 10;
            this.labelBookName.Text = "пусто";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Depth = 0;
            this.labelPublisher.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPublisher.Location = new System.Drawing.Point(171, 30);
            this.labelPublisher.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(49, 19);
            this.labelPublisher.TabIndex = 11;
            this.labelPublisher.Text = "пусто";
            // 
            // labelAuthorScypher
            // 
            this.labelAuthorScypher.AutoSize = true;
            this.labelAuthorScypher.Depth = 0;
            this.labelAuthorScypher.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAuthorScypher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAuthorScypher.Location = new System.Drawing.Point(216, 54);
            this.labelAuthorScypher.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAuthorScypher.Name = "labelAuthorScypher";
            this.labelAuthorScypher.Size = new System.Drawing.Size(49, 19);
            this.labelAuthorScypher.TabIndex = 12;
            this.labelAuthorScypher.Text = "пусто";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Depth = 0;
            this.labelAuthor.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAuthor.Location = new System.Drawing.Point(370, 0);
            this.labelAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(49, 19);
            this.labelAuthor.TabIndex = 13;
            this.labelAuthor.Text = "пусто";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Depth = 0;
            this.labelISBN.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelISBN.Location = new System.Drawing.Point(370, 28);
            this.labelISBN.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(49, 19);
            this.labelISBN.TabIndex = 14;
            this.labelISBN.Text = "пусто";
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.Depth = 0;
            this.labelDiscipline.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDiscipline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDiscipline.Location = new System.Drawing.Point(380, 53);
            this.labelDiscipline.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(49, 19);
            this.labelDiscipline.TabIndex = 15;
            this.labelDiscipline.Text = "пусто";
            // 
            // buttonProps
            // 
            this.buttonProps.Depth = 0;
            this.buttonProps.Location = new System.Drawing.Point(478, 3);
            this.buttonProps.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonProps.Name = "buttonProps";
            this.buttonProps.Primary = true;
            this.buttonProps.Size = new System.Drawing.Size(90, 23);
            this.buttonProps.TabIndex = 17;
            this.buttonProps.Text = "Свойство";
            this.buttonProps.UseVisualStyleBackColor = true;
            this.buttonProps.Click += new System.EventHandler(this.buttonProps_Click_1);
            // 
            // BookProps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.buttonProps);
            this.Controls.Add(this.labelDiscipline);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelAuthorScypher);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BookProps";
            this.Size = new System.Drawing.Size(580, 79);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel labelBookName;
        private MaterialSkin.Controls.MaterialLabel labelPublisher;
        private MaterialSkin.Controls.MaterialLabel labelAuthorScypher;
        private MaterialSkin.Controls.MaterialLabel labelAuthor;
        private MaterialSkin.Controls.MaterialLabel labelISBN;
        private MaterialSkin.Controls.MaterialLabel labelDiscipline;
        private MaterialSkin.Controls.MaterialRaisedButton buttonProps;
    }
}
