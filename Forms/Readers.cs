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

namespace Diploma.Forms
{
    public partial class Readers : UserControl
    {
        public Readers()
        {
            InitializeComponent();
        }
        private Employee employee1 = new Employee();

        private Model model = MainForm.model;
        public void Fill(Employee employee)
        {
            employee1 = employee;
            labelSurname.Text = employee.Surname;
            labelName.Text = employee.Name;
            labelSecondName.Text = employee.SecondName;
            labelDepartment.Text = employee.Department1.Name.ToString();
            labelPhone.Text = employee.Phone;
            labelEmail.Text = employee.Email;
            checkBoxReserved.Checked = (bool)employee.IsReserved;
            if (employee.IsReserved == true)
            {
                labelBookName.Text = employee.Book.Name;
            }
            else
            {
                labelBookName.Visible = false;
                labelnasas.Visible = false;
            }
        }

        private void buttonProps_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addemployeeForm = new AddEmployeeForm();
            addemployeeForm.ShowDialog();
        }

        
      

      
    }
}
