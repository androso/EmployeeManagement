using System;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class PositionForm : Form
    {
        private MainForm mainForm;

        public PositionForm(MainForm mainForm)
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
    }
}
