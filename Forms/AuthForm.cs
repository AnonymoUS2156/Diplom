using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diploma.Models;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Diploma
{
    public partial class AuthForm : MaterialForm
    {
        public AuthForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue400, Accent.LightBlue100, TextShade.WHITE);
        }
        

        

        private void buttonEnter_Click_1(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();

            
            if (String.IsNullOrWhiteSpace(loginTextBox.Text)
                || String.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            AuthArchivist authArchivist;

            authArchivist = model1.AuthArchivist.FirstOrDefault(item => item.Login == loginTextBox.Text && item.Password == passwordTextBox.Text);
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            if (authArchivist == null)
            {
                MessageBox.Show("Не найден!");
                return;
            }
            
        }
    }
}
