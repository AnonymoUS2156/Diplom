using Diploma.Forms;
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

namespace Diploma
{
    public partial class BookProps : UserControl
    {
        private Book _book;
        public BookProps()
        {
            InitializeComponent();
        }
        public void Fill(Book book)
        {
            
            _book = book;
            labelBookName.Text = book.Name;
            labelAuthor.Text = book.Author.Abbreviation.ToString();
            labelPublisher.Text = book.Publisher.Name.ToString();
            labelDiscipline.Text = book.Disciplines1.Name.ToString();
            labelAuthorScypher.Text = book.Author_Sign.ToString();
            pictureBox1.Image = Image.FromFile($@"{book.Photo}");
        }

        

        private void buttonProps_Click_1(object sender, EventArgs e)
        {

            EditBookForm editBookForm = new EditBookForm(_book);
            editBookForm.ShowDialog();
        }
    }
}
