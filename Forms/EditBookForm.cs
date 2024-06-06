using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Diploma.Models;
namespace Diploma.Forms
{
    public partial class EditBookForm : MaterialForm
    {
        private Model1 model = MainForm.model;
        private Book thisbook;

        private List<Author> authors = new List<Author>();
        private List<Disciplines> disciplines = new List<Disciplines>();

        public EditBookForm(Book book)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue400, Accent.LightBlue100, TextShade.WHITE);
            LoadComboBox();
            Fill(book);
        }

        private void LoadComboBox()
        {
            disciplinesComboBox.Items.Clear();
            comboBoxAuthors.Items.Clear();

            authors = model.Author.ToList();
            disciplines = model.Disciplines.ToList();

            foreach (var author in authors)
                comboBoxAuthors.Items.Add(author.Abbreviation);
            foreach (var dis in disciplines)
                disciplinesComboBox.Items.Add(dis.Name);
        }

        private void Fill(Book book)
        {
            thisbook = book;
            textBoxName.Text = book.Name;
            textBoxPublisher.Text = book.Publisher.Name;
            textBoxISBN.Text = book.ISBN.ToString();
            textBoxYear.Text = book.Year.ToString();

            pictureBox1.Image = Image.FromFile($@"{book.Photo}");
            for (int i = 0; i < authors.Count; i++)
            {
                if (book.AuthorID == authors[i].ID)
                    comboBoxAuthors.SelectedIndex = i;
            }
            for (int i = 0; i < disciplines.Count; i++)
            {
                if (book.Disciplines == disciplines[i].ID)
                    disciplinesComboBox.SelectedIndex = i;
            }
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            model.Book.Remove(thisbook);
            model.SaveChanges();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBook();
                model.SaveChanges();
                MessageBox.Show("Данные успешно обновлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении данных: " + ex.Message);
            }
        }

        private void UpdateBook()
        {
            try
            {
                thisbook.Name = textBoxName.Text;
                thisbook.Publisher.Name = textBoxPublisher.Text;
                thisbook.ISBN = textBoxISBN.Text;

                if (!int.TryParse(textBoxYear.Text, out int year))
                {
                    throw new FormatException("Неправильный формат года.");
                }

                thisbook.Year = year;

                if (comboBoxAuthors.SelectedIndex < 0)
                {
                    throw new InvalidOperationException("Выберите автора.");
                }

                if (disciplinesComboBox.SelectedIndex < 0)
                {
                    throw new InvalidOperationException("Выберите дисциплину.");
                }

                thisbook.Author = authors[comboBoxAuthors.SelectedIndex];
                thisbook.Disciplines1 = disciplines[disciplinesComboBox.SelectedIndex];
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка формата: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Ошибка выбора: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
