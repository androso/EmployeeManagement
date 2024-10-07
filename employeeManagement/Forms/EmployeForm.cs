using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class EmployeForm : Form
    {
        MainForm mainForm;
        public EmployeForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void EmployeForm_Load(object sender, EventArgs e)
        {


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
