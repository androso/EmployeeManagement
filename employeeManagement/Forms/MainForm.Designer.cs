namespace PresentationLayer.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEmploye = new Button();
            btnDepartment = new Button();
            btnPosition = new Button();
            SuspendLayout();
            // 
            // btnEmploye
            // 
            btnEmploye.Location = new Point(208, 485);
            btnEmploye.Name = "btnEmploye";
            btnEmploye.Size = new Size(174, 55);
            btnEmploye.TabIndex = 0;
            btnEmploye.Text = "Empleado";
            btnEmploye.UseVisualStyleBackColor = true;
            btnEmploye.Click += btnEmploye_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.Location = new Point(834, 485);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(174, 55);
            btnDepartment.TabIndex = 1;
            btnDepartment.Text = "Departamento";
            btnDepartment.UseVisualStyleBackColor = true;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnPosition
            // 
            btnPosition.Location = new Point(506, 485);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(174, 55);
            btnPosition.TabIndex = 2;
            btnPosition.Text = "Posición";
            btnPosition.UseVisualStyleBackColor = true;
            btnPosition.Click += btnPosition_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 725);
            Controls.Add(btnPosition);
            Controls.Add(btnDepartment);
            Controls.Add(btnEmploye);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmploye;
        private Button btnDepartment;
        private Button btnPosition;
    }
}