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
            loadCB();
        }

        private Model1 model = MainForm.model;
        private Author author = new Author();
        public Book book = new Book();
        public List<Gender> genders = new List<Gender>();

        void loadCB()
        {
            genders = model.Gender.ToList();

            foreach (var gender in genders)
                genderComboBox.Items.Add(gender.Gender1);
        }
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
                author.Surname = surnameTextBox.Text;
                author.Name = nameTextBox.Text;
                author.SecondName = secondNameTextBox.Text;
                author.Birthday = birthdayDateTimePicker.Value;
                author.Gender = genders[genderComboBox.SelectedIndex].ID;
                author.Abbreviation = abbreviationTextBox.Text;
                model.Author.Add(author);
                model.SaveChanges();
            try
            {
                if (string.IsNullOrWhiteSpace(surnameTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    throw new ArgumentNullException("Введите значения!");
                }


                

                MessageBox.Show("Данные сохранены");
                Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ошибка в процессе сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка" + ex.Message, "Код ошибки:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
