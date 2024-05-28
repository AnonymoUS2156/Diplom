using Diploma.Forms;
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
namespace Diploma
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue400, Accent.LightBlue100, TextShade.WHITE);
        }
        public static Model model = new Model();
        List<Book> books = model.Book.ToList();

        private void Load1()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in books)
            {
                BookProps bookProperties = new BookProps();
                bookProperties.Fill(item);
                flowLayoutPanel1.Controls.Add(bookProperties);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxSort.DataSource = GetProp(new Book());
            comboBoxSort.SelectedIndex = 0;
            comboBoxAtributesSort.SelectedIndex = 0;
            Load1();
        }
        private List<string> GetProp<T>(T o)
        {
            List<string> strings = new List<string>();
            strings = typeof(T).GetProperties().
               Where(x => !x.SetMethod.Attributes.ToString().Contains("Virtual")).
               Select(p => p.Name).ToList();
            return strings;
        }
        private void Sorting()
        {
            if (comboBoxAtributesSort.SelectedIndex == 0)
            {
                books = books.OrderBy(p => p.GetType().GetProperties().First(x => x.Name == comboBoxSort.SelectedItem.ToString()).GetValue(p)).ToList();
            }
            else if (comboBoxAtributesSort.SelectedIndex == 1)
                books = books.OrderByDescending(p => p.GetType().GetProperties().First(x => x.Name == comboBoxSort.SelectedItem.ToString()).GetValue(p)).ToList();

            Load1();
        }

        private void comboBoxAtributesSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sorting();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBoxSearch.Text)) // хз можно сделать лучше
            {
                books = books.Where(p => p.GetType().GetProperties().Any(prop =>
                prop.GetValue(p)?.ToString()?.ToLower().Contains(textBoxSearch.Text.ToLower()) ?? false)).OrderByDescending(p => p.GetType().GetProperties()
                .First(prop => prop.GetValue(p)?.ToString()?.ToLower().Contains(textBoxSearch.Text.ToLower()) ?? false)
                .GetValue(p)).ToList();
            }
            else
            {
                books = model.Book.ToList();
            }
            Load1();

            // добавить откат поискового запроса при отсутствии символов в поисковой строке
        }

        

        

        private void button2_Click_1(object sender, EventArgs e)
        {

            AddDisciplineForm addDisciplineForm = new AddDisciplineForm();
            addDisciplineForm.ShowDialog();
            ReadersForm readersForm = new ReadersForm();
            readersForm.ShowDialog();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            AddAuthorForm addAuthorForm = new AddAuthorForm();
            addAuthorForm.ShowDialog(this);
        }
    }
}
