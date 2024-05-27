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

        public void Fill(Employee employee)
        {
            //пересоздать лейблы
        }

        private void buttonProps_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addemployeeForm = new AddEmployeeForm();
            addemployeeForm.ShowDialog();
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
