using MaterialSkin;
using MaterialSkin.Controls;
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
namespace Diploma.Forms
{
    public partial class AddAuthorForm : MaterialForm
    {
        public AddAuthorForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue400, Accent.LightBlue100, TextShade.WHITE);

        }

        private Model1 model = MainForm.model;
        private Author author = new Author();
        public Book book = new Book();
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            author.Surname = surnameTextBox.Text;
            author.Name = nameTextBox.Text;
            author.SecondName = secondNameTextBox.Text;
            author.Birthday = birthdayDateTimePicker.Value ;
            author.Gender = genderComboBox.SelectedIndex;
            author.Abbreviation = abbreviationTextBox.Text;
            model.Book.Add(book);
            model.SaveChanges();
            MessageBox.Show("Данные сохранены");
            Close();
        }
    }
}
