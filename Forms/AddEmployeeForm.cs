using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Diploma.Models;
namespace Diploma.Forms
{
    public partial class AddEmployeeForm : MaterialForm
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue400, Accent.LightBlue100, TextShade.WHITE);
            LoadComboBox();
        }

        private Model1 model = MainForm.model;
        private Employee emp = new Employee();
        private List<Employee> emps = new List<Employee>();
        private List<Department> dep = new List<Department>();
        private void LoadComboBox()
        {
            nameComboBox.Items.Clear();
            dep = model.Department.ToList();
            foreach (var deps in dep)
                nameComboBox.Items.Add(deps.Name);
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            // You can call LoadComboBox() here if needed
            // LoadComboBox();
        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (materialCheckBox1.Checked)
                {
                    if (!int.TryParse(reservedBookIDTextBox.Text, out int reservedBookID))
                    {
                        throw new FormatException("Reserved Book ID должен быть числом.");
                    }

                    emp.ReservedBookID = reservedBookID;
                }
                emp.Surname = surnameTextBox.Text;
                emp.Name = nameTextBox.Text;
                emp.SecondName = secondNameTextBox.Text;
                emp.Phone = phoneMaskedTextBox.Text;
                emp.Email = emailTextBox.Text;
                emp.IsReserved = materialCheckBox1.Checked;



                if (nameComboBox.SelectedIndex < 0)
                {
                    throw new InvalidOperationException("Выберите департамент.");
                }

                emp.Department = dep[nameComboBox.SelectedIndex].ID;

                model.Employee.Add(emp);
                model.SaveChanges();

                MessageBox.Show("Данные сохранены");
                Close();
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

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked)
            {
                materialLabel7.Visible = true;
                reservedBookIDTextBox.Visible = true;
            }
            else
            {

                materialLabel7.Visible = false;
                reservedBookIDTextBox.Visible = false;
            }
        }


    }
}
