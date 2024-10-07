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
    public partial class DepartmentForm : Form
    {
        private MainForm mainForm;
        public DepartmentForm(MainForm mainForm)
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
            // Asegurarse de que MainForm se muestre si PositionForm se cierra
            mainForm.Show();
            base.OnFormClosed(e);
        }
    }
}
