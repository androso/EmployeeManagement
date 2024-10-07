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
            // Mostrar el MainForm que se pasó como referencia
            mainForm.Show();
            this.Close();  // Cerrar el PositionForm
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Asegurarse de que MainForm se muestre si PositionForm se cierra
            mainForm.Show();
            base.OnFormClosed(e);
        }
    }
}
