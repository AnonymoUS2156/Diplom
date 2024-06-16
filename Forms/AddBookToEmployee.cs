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
    public partial class AddBookToEmployee : MaterialForm
    {
        public AddBookToEmployee()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue400, Accent.LightBlue100, TextShade.WHITE);

            LoadComboBox();
        }
        public static Model1 model = new Model1();
        List<Book> books = model.Book.ToList();
        Employee employee = new Employee();
        Book book = new Book();
        private void LoadComboBox()
        {
            comboBox1.Items.Clear();

            books = model.Book.ToList();


            foreach (var book in books)
                comboBox1.Items.Add(book.Name);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            employee.ReservedBookID = books[comboBox1.SelectedIndex].ID;
            model.Employee.Add(employee);
            model.SaveChanges();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
