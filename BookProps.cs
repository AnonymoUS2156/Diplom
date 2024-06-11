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
            var assignments = new Action[]
            {   
                () => { if (book?.Name != null) labelBookName.Text = book.Name; },
                () => { if (book?.Author?.Abbreviation != null) labelAuthor.Text = book.Author.Abbreviation.ToString(); },
                () => { if (book?.Publisher?.Name != null) labelPublisher.Text = book.Publisher.Name.ToString(); },
                () => { if (book?.Disciplines1?.Name != null) labelDiscipline.Text = book.Disciplines1.Name.ToString(); },
                () => { if (book?.Author_Sign != null) labelAuthorScypher.Text = book.Author_Sign.ToString(); },
                () => { if (book?.Photo != null) pictureBox1.Image = Image.FromFile($@"{book.Photo}"); }

            };

            foreach (var assign in assignments)
            {
                try
                {
                    assign();
                }
                catch
                {   
                    continue;
                }
            }
            
        }



        private void buttonProps_Click_1(object sender, EventArgs e)
        {

            EditBookForm editBookForm = new EditBookForm(_book);
            editBookForm.ShowDialog();
        }
    }
}
