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
namespace Diploma.Forms
{
    public partial class AddDisciplineForm : Form
    {
        public AddDisciplineForm()
        {
            InitializeComponent();
        }
        Disciplines disciplines = new Disciplines();

        private void button1_Click(object sender, EventArgs e)
        {
            disciplines.Class = Int32.Parse(maskedTextBoxClass.Text);
            disciplines.Name = nameTextBox.Text;

        }
    }
}
