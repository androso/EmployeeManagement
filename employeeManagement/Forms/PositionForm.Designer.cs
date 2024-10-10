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
            btnSalir = new Button();
            createPosition = new Label();
            namePosition = new Label();
            salaryLabel = new Label();
            departmentLabel = new Label();
            SelectDepartment = new ComboBox();
            AddSalaryTextBox = new TextBox();
            addNamePosition = new TextBox();
            btnGuardar = new Button();
            positionGroupBox = new GroupBox();
            positionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(357, 515);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(131, 35);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // createPosition
            // 
            createPosition.AutoSize = true;
            createPosition.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPosition.Location = new Point(162, 35);
            createPosition.Name = "createPosition";
            createPosition.Size = new Size(238, 33);
            createPosition.TabIndex = 1;
            createPosition.Text = "Crear posición";
            // 
            // namePosition
            // 
            namePosition.AutoSize = true;
            namePosition.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namePosition.Location = new Point(40, 134);
            namePosition.Name = "namePosition";
            namePosition.Size = new Size(248, 27);
            namePosition.TabIndex = 2;
            namePosition.Text = "Nombre de Posicion";
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
            // SelectDepartment
            // 
            SelectDepartment.FormattingEnabled = true;
            SelectDepartment.Location = new Point(357, 347);
            SelectDepartment.Name = "SelectDepartment";
            SelectDepartment.Size = new Size(226, 28);
            SelectDepartment.TabIndex = 5;
            // 
            // AddSalaryTextBox
            // 
            AddSalaryTextBox.Location = new Point(40, 347);
            AddSalaryTextBox.Multiline = true;
            AddSalaryTextBox.Name = "AddSalaryTextBox";
            AddSalaryTextBox.Size = new Size(263, 28);
            AddSalaryTextBox.TabIndex = 8;
            // 
            // addNamePosition
            // 
            addNamePosition.Location = new Point(40, 184);
            addNamePosition.Multiline = true;
            addNamePosition.Name = "addNamePosition";
            addNamePosition.Size = new Size(543, 40);
            addNamePosition.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(125, 515);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 35);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // positionGroupBox
            // 
            positionGroupBox.Controls.Add(btnGuardar);
            positionGroupBox.Controls.Add(addNamePosition);
            positionGroupBox.Controls.Add(AddSalaryTextBox);
            positionGroupBox.Controls.Add(SelectDepartment);
            positionGroupBox.Controls.Add(departmentLabel);
            positionGroupBox.Controls.Add(salaryLabel);
            positionGroupBox.Controls.Add(namePosition);
            positionGroupBox.Controls.Add(createPosition);
            positionGroupBox.Controls.Add(btnSalir);
            positionGroupBox.Location = new Point(370, 26);
            positionGroupBox.Name = "positionGroupBox";
            positionGroupBox.Size = new Size(618, 582);
            positionGroupBox.TabIndex = 13;
            positionGroupBox.TabStop = false;
            // 
            // PositionForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1320, 671);
            Controls.Add(positionGroupBox);
            Name = "PositionForm";
            Text = "PositionForm";
            positionGroupBox.ResumeLayout(false);
            positionGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Label createPosition;
        private Label namePosition;
        private Label salaryLabel;
        private Label departmentLabel;
        private ComboBox SelectDepartment;
        private TextBox AddSalaryTextBox;
        private TextBox addNamePosition;
        private Button btnGuardar;
        private GroupBox positionGroupBox;
    }
}