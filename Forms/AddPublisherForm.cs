using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diploma.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Diploma.Forms
{
    public partial class AddPublisherForm : MaterialForm
    {
        private Model1 model1 = MainForm.model;
        Publisher publisher = new Publisher();

        public AddPublisherForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue400, Accent.LightBlue100, TextShade.WHITE);
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    throw new ArgumentNullException("Name field cannot be empty.");
                }

                publisher.Name = nameTextBox.Text;
                publisher.Site = siteTextBox.Text;
                publisher.Email = emailTextBox.Text;
                publisher.Phone = phoneMaskedTextBox.Text;
                publisher.Adress = adressTextBox.Text;

                model1.Publisher.Add(publisher);
                model1.SaveChanges();

                MessageBox.Show("Данные успешно сохранены");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
