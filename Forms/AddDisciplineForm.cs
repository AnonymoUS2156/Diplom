using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diploma.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Diploma.Forms
{
    public partial class AddDisciplineForm : MaterialForm
    {
        public AddDisciplineForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue400, Accent.LightBlue100, TextShade.WHITE);

        }

        Disciplines disciplines = new Disciplines();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    throw new ArgumentNullException("Name field cannot be empty.");
                }

                
                

                disciplines.Name = nameTextBox.Text;

                using (Model1 model1 = new Model1())
                {
                    model1.Disciplines.Add(disciplines);
                    model1.SaveChanges();
                }

                MessageBox.Show("Данные успешно сохранены");
                Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
