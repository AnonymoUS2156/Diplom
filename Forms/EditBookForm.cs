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

        private List<Publisher> publishers = new List<Publisher>();
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
            comboBoxPublisher.Items.Clear();

            authors = model.Author.ToList();
            disciplines = model.Disciplines.ToList();
            publishers = model.Publisher.ToList();
            

            foreach (var author in authors)
                comboBoxAuthors.Items.Add(author.Abbreviation);
            foreach (var dis in disciplines)
                disciplinesComboBox.Items.Add(dis.Name);
            foreach (var publisher in publishers)
                comboBoxPublisher.Items.Add(publisher.Name);
        }

        private void Fill(Book book)
        {
            thisbook = book;

            var assignments = new Action[]
            {
                () => { if (book?.Name != null) textBoxName.Text = book.Name; },
                () => { if (book?.ISBN != null) textBoxISBN.Text = book.ISBN.ToString(); },
                () => { textBoxYear.Text = book.Year.ToString(); },
                () => { if (book?.Photo != null) pictureBox1.Image = Image.FromFile($@"{book.Photo}"); },
                () =>
                {
                    for (int i = 0; i < authors.Count; i++)
                    {
                        if (book?.AuthorID == authors[i].ID)
                        comboBoxAuthors.SelectedIndex = i;
                    }
                },
            () =>
            {
                for (int i = 0; i < disciplines.Count; i++)
                {
                    if (book?.Disciplines == disciplines[i].ID)
                        disciplinesComboBox.SelectedIndex = i;
                }
            },
            () =>
            {
                for (int i = 0; i < publishers.Count; i++)
                {
                    if (book?.PublisherID == publishers[i].ID)
                        comboBoxPublisher.SelectedIndex = i;
                }
            }
        };

            foreach (var assign in assignments)
            {
                try
                {
                    assign();
                }
                catch (Exception)
                {
                    // Handle specific logging if needed
                    continue;
                }
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
                Close();
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
                thisbook.Publisher = publishers[comboBoxPublisher.SelectedIndex];
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.AddPicture();
        }
    }
}
