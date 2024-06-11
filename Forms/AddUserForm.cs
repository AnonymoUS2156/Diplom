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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
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
