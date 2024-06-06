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
    public partial class ReadersForm : MaterialForm
    {
        public ReadersForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue400, Accent.LightBlue100, TextShade.WHITE);

        }
        public static Model1 model = new Model1();
        List<Employee> employees = model.Employee.ToList();
        private void Load1()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var items in employees)
            {
                Readers readers = new Readers();
                readers.Fill(items);
                flowLayoutPanel1.Controls.Add(readers);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReadersForm_Load(object sender, EventArgs e)
        {
            Load1();
        }

        private void buttonAddReader_Click(object sender, EventArgs e)
        {
            AddEmployeeForm amf = new AddEmployeeForm();
            amf.ShowDialog();
        }
    }
}
