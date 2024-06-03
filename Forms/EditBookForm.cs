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
    public partial class EditBookForm : MaterialForm
    {
        private Model model = MainForm.model;
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

            foreach (var autor in authors)
                comboBoxAuthors.Items.Add(autor.Abbreviation);
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

            UpdateBook();

            model.SaveChanges();
        }

        private void UpdateBook()
        {
            thisbook.Name = textBoxName.Text;
            thisbook.Publisher.Name = textBoxPublisher.Text;
            thisbook.ISBN = textBoxISBN.Text ;
            thisbook.Publisher.Name = textBoxPublisher.Text;
            thisbook.Year = Int32.Parse(textBoxYear.Text);
            thisbook.Author = authors[comboBoxAuthors.SelectedIndex];
            thisbook.Disciplines1 = disciplines[disciplinesComboBox.SelectedIndex];
            MessageBox.Show("Данные успешно обновлены");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
