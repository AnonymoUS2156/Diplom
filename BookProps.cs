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

namespace Diploma
{
    public partial class BookProps : UserControl
    {
        public BookProps()
        {
            InitializeComponent();
        }
        public void Fill(Book book)
        {
            labelBookName.Text = book.Name;
            labelAuthor.Text = book.Author.Abbreviation.ToString();
            labelPublisher.Text = book.Publisher.Name.ToString();
            labelISBN.Text = book.ISBN.ToString();
            labelDiscipline.Text = book.Disciplines.ToString();
            labelAuthorScypher.Text = book.Author_Sign.ToString();
            pictureBox1.Image = Image.FromFile($@"{book.Photo}");
            Book book1 = new Book();
        }

        private void buttonProps_Click(object sender, EventArgs e)
        {
            EditBookForm editBookForm = new EditBookForm();
            editBookForm.ShowDialog();
        }
    }
}
