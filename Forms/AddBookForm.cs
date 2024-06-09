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
using MaterialSkin.Controls;
using Diploma.Models;
using System.IO;
using System.Data.Entity.Infrastructure;
namespace Diploma
{
    public partial class AddBookForm : MaterialForm
    {
        public AddBookForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue400, Accent.LightBlue100, TextShade.WHITE);
            LoadComboBox();
        }
        private Model1 model = MainForm.model;
        private Book book = new Book();
        private List<Disciplines> disciplines = new List<Disciplines>();
        private List<Author> authors = new List<Author>();
        private List<Publisher> publishers = new List<Publisher>();
        MainForm main = new MainForm();
        private string newFileName;
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }
        private void LoadComboBox()
        {
            disciplinesComboBox.Items.Clear();
            comboBoxAuthors.Items.Clear();
            publishersComboBox.Items.Clear();

            authors = model.Author.ToList();
            disciplines = model.Disciplines.ToList();
            publishers = model.Publisher.ToList();

            foreach (var author in authors)
                comboBoxAuthors.Items.Add(author.Abbreviation);
            foreach (var dis in disciplines)
                disciplinesComboBox.Items.Add(dis.Name);
            foreach (var publisher in publishers)
                publishersComboBox.Items.Add(publisher.Name);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Loader();
            model.Book.Add(book);
            model.SaveChanges();


            MessageBox.Show("Данные успешно сохранены");
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении данных: " + ex.Message + ". Проверьте вводимые данные на правильность");
            }

        }

        void Loader()
        {
            book.Name = textBoxName.Text;
            book.Author_Sign = author_SignTextBox.Text;
            book.Price = decimal.Parse(priceTextBox.Text);
            book.Pages = Int32.Parse(maskedTextBox1.Text);
            book.Photo = pictureBox2.ImageLocation;
            book.PublisherID = publishers[publishersComboBox.SelectedIndex].ID;
            book.AuthorID = authors[comboBoxAuthors.SelectedIndex].ID;
            book.ISBN = textBoxISBN.Text;
            book.Disciplines = disciplines[disciplinesComboBox.SelectedIndex].ID;
            book.Photo = $@"pictures\{newFileName}";
            try
            {
                book.Year = Int32.Parse(textBoxYear.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не верно введен год! Проверьте диапозон с 0 до 2025!");
            }
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
            for (int i = 0; i < publishers.Count; i++)
            {
                if (book.PublisherID == publishers[i].ID)
                    publishersComboBox.SelectedIndex = i;
            }
        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получение пути к выбранному файлу
                    string sourceFilePath = openFileDialog.FileName;

                    // Создание папки "pictures" в папке проекта, если она не существует
                    string picturesFolder = Path.Combine(Application.StartupPath, "pictures");
                    if (!Directory.Exists(picturesFolder))
                        Directory.CreateDirectory(picturesFolder);

                    int imageCounter = GetNextPictureIndex(picturesFolder);

                    // Определение пути для копирования файла с новым именем
                    newFileName = $"pict{imageCounter++}{Path.GetExtension(sourceFilePath)}";

                    string destinationFilePath = Path.Combine(picturesFolder, newFileName);


                    // Копирование файла в папку "pictures"
                    File.Copy(sourceFilePath, destinationFilePath, true);

                    // Загрузка изображения в PictureBox
                    pictureBox2.Image = new Bitmap(destinationFilePath);

                    //book.Photo = 
                    // Уведомление пользователя о завершении операции
                    MessageBox.Show($"Изображение успешно загружено и сохранено как {newFileName} в папке \"pictures\".");
                }
            }
        }
        private int GetNextPictureIndex(string picturesFolder)
        {
            // Получаем все директории и файлы внутри папки pictures
            DirectoryInfo dirInfo = new DirectoryInfo(picturesFolder);
            FileInfo[] files = dirInfo.GetFiles("pict*.*");

            var pictureFiles = files
                .Where(f => f.Name.StartsWith("pict") && int.TryParse(f.Name.Substring(4, f.Name.IndexOf('.') - 4), out _))
                .Select(f => int.Parse(f.Name.Substring(4, f.Name.IndexOf('.') - 4)))
                .OrderBy(index => index)
                .ToList();

            if (pictureFiles.Count == 0)
                return 1;

            return pictureFiles.Last() + 1;
        }
        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
