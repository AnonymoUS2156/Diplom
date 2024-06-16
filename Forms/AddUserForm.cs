using Diploma.Models;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Diploma.Forms
{
    public partial class AddUserForm : MaterialForm
    {
        public AddUserForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue400, Accent.LightBlue100, TextShade.WHITE);

        }

        private Model1 model1 = MainForm.model;
        AuthArchivist authArchivist = new AuthArchivist();
        private void addButton_Click(object sender, EventArgs e)
        {
            authArchivist.Person = textBox3.Text;
            authArchivist.Login = textBox1.Text;
            authArchivist.Password = textBox2.Text;
            model1.AuthArchivist.Add(authArchivist);
            authArchivist.Role = 2;
            model1.SaveChanges();
            MessageBox.Show("Пользователь добавлен!");
        }
    }
}
