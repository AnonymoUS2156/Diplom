using Diploma.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma.Forms
{
    public partial class UserAuthForm : Form
    {
        public UserAuthForm()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();


            if (String.IsNullOrWhiteSpace(loginTextBox.Text)
                || String.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            AuthArchivist authArchivist;

            authArchivist = model1.AuthArchivist.FirstOrDefault(item => item.Login == loginTextBox.Text && item.Password == passwordTextBox.Text && item.Roles.ID == 1);



            if (authArchivist == null)
            {
                MessageBox.Show("Не найден или неверно введены данные!");
                return;
            }
            
            Hide();
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }
    }
}
