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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            mainForm.Show();
            base.OnFormClosed(e);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
