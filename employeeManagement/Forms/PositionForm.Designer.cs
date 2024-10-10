namespace PresentationLayer.Forms
{
    partial class PositionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionForm));
            btnSalir = new Button();
            createPositionLabel = new Label();
            namePositionLabel = new Label();
            salaryLabel = new Label();
            departmentLabel = new Label();
            SelectDepartmentTextBox = new ComboBox();
            AddSalaryTextBox = new TextBox();
            PositionTextBox = new TextBox();
            btnGuardar = new Button();
            positionGroupBox = new GroupBox();
            pictureBoxPosition = new PictureBox();
            positionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPosition).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 255, 255);
            btnSalir.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(357, 515);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(131, 35);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // createPositionLabel
            // 
            createPositionLabel.AutoSize = true;
            createPositionLabel.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPositionLabel.Location = new Point(162, 35);
            createPositionLabel.Name = "createPositionLabel";
            createPositionLabel.Size = new Size(238, 33);
            createPositionLabel.TabIndex = 1;
            createPositionLabel.Text = "Crear posición";
            // 
            // namePositionLabel
            // 
            namePositionLabel.AutoSize = true;
            namePositionLabel.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namePositionLabel.Location = new Point(40, 134);
            namePositionLabel.Name = "namePositionLabel";
            namePositionLabel.Size = new Size(248, 27);
            namePositionLabel.TabIndex = 2;
            namePositionLabel.Text = "Nombre de Posicion";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salaryLabel.Location = new Point(40, 289);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(166, 27);
            salaryLabel.TabIndex = 3;
            salaryLabel.Text = "Salario base";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentLabel.Location = new Point(357, 289);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(188, 27);
            departmentLabel.TabIndex = 4;
            departmentLabel.Text = "Departamento";
            // 
            // SelectDepartmentTextBox
            // 
            SelectDepartmentTextBox.FormattingEnabled = true;
            SelectDepartmentTextBox.Location = new Point(357, 347);
            SelectDepartmentTextBox.Name = "SelectDepartmentTextBox";
            SelectDepartmentTextBox.Size = new Size(226, 28);
            SelectDepartmentTextBox.TabIndex = 5;
            // 
            // AddSalaryTextBox
            // 
            AddSalaryTextBox.Location = new Point(40, 347);
            AddSalaryTextBox.Multiline = true;
            AddSalaryTextBox.Name = "AddSalaryTextBox";
            AddSalaryTextBox.Size = new Size(263, 28);
            AddSalaryTextBox.TabIndex = 8;
            // 
            // PositionTextBox
            // 
            PositionTextBox.Location = new Point(40, 184);
            PositionTextBox.Multiline = true;
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(543, 40);
            PositionTextBox.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 255);
            btnGuardar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(125, 515);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 35);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // positionGroupBox
            // 
            positionGroupBox.BackColor = Color.White;
            positionGroupBox.Controls.Add(pictureBoxPosition);
            positionGroupBox.Controls.Add(btnGuardar);
            positionGroupBox.Controls.Add(PositionTextBox);
            positionGroupBox.Controls.Add(AddSalaryTextBox);
            positionGroupBox.Controls.Add(SelectDepartmentTextBox);
            positionGroupBox.Controls.Add(departmentLabel);
            positionGroupBox.Controls.Add(salaryLabel);
            positionGroupBox.Controls.Add(namePositionLabel);
            positionGroupBox.Controls.Add(createPositionLabel);
            positionGroupBox.Controls.Add(btnSalir);
            positionGroupBox.Location = new Point(370, 26);
            positionGroupBox.Name = "positionGroupBox";
            positionGroupBox.Size = new Size(618, 582);
            positionGroupBox.TabIndex = 13;
            positionGroupBox.TabStop = false;
            // 
            // pictureBoxPosition
            // 
            pictureBoxPosition.Image = (Image)resources.GetObject("pictureBoxPosition.Image");
            pictureBoxPosition.Location = new Point(457, 26);
            pictureBoxPosition.Name = "pictureBoxPosition";
            pictureBoxPosition.Size = new Size(126, 105);
            pictureBoxPosition.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPosition.TabIndex = 14;
            pictureBoxPosition.TabStop = false;
            // 
            // PositionForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(128, 255, 255);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1320, 671);
            Controls.Add(positionGroupBox);
            Name = "PositionForm";
            Text = "PositionForm";
            positionGroupBox.ResumeLayout(false);
            positionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPosition).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Label createPositionLabel;
        private Label namePositionLabel;
        private Label salaryLabel;
        private Label departmentLabel;
        private ComboBox SelectDepartmentTextBox;
        private TextBox AddSalaryTextBox;
        private TextBox PositionTextBox;
        private Button btnGuardar;
        private GroupBox positionGroupBox;
        private PictureBox pictureBoxPosition;
    }
}