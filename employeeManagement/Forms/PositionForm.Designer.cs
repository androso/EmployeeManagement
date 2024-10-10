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
            components = new System.ComponentModel.Container();
            editDepartmentGroupbox = new GroupBox();
            departmentCombobox = new ComboBox();
            departmentLabel = new Label();
            baseSalaryTextbox = new TextBox();
            editPositionTitle = new Label();
            btnCancel = new Button();
            baseSalaryLabel = new Label();
            positionNameLabel = new Label();
            btnGuardar = new Button();
            positionNameTextbox = new TextBox();
            validationErrorProvider = new ErrorProvider(components);
            editDepartmentGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // editDepartmentGroupbox
            // 
            editDepartmentGroupbox.Controls.Add(departmentCombobox);
            editDepartmentGroupbox.Controls.Add(departmentLabel);
            editDepartmentGroupbox.Controls.Add(baseSalaryTextbox);
            editDepartmentGroupbox.Controls.Add(editPositionTitle);
            editDepartmentGroupbox.Controls.Add(btnCancel);
            editDepartmentGroupbox.Controls.Add(baseSalaryLabel);
            editDepartmentGroupbox.Controls.Add(positionNameLabel);
            editDepartmentGroupbox.Controls.Add(btnGuardar);
            editDepartmentGroupbox.Controls.Add(positionNameTextbox);
            editDepartmentGroupbox.Location = new Point(-26, 95);
            editDepartmentGroupbox.Name = "editDepartmentGroupbox";
            editDepartmentGroupbox.Size = new Size(741, 480);
            editDepartmentGroupbox.TabIndex = 17;
            editDepartmentGroupbox.TabStop = false;
            // 
            // departmentCombobox
            // 
            departmentCombobox.FormattingEnabled = true;
            departmentCombobox.Location = new Point(324, 277);
            departmentCombobox.Name = "departmentCombobox";
            departmentCombobox.Size = new Size(235, 28);
            departmentCombobox.TabIndex = 24;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentLabel.Location = new Point(189, 276);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(135, 25);
            departmentLabel.TabIndex = 23;
            departmentLabel.Text = "Departamento";
            // 
            // baseSalaryTextbox
            // 
            baseSalaryTextbox.Location = new Point(324, 206);
            baseSalaryTextbox.Multiline = true;
            baseSalaryTextbox.Name = "baseSalaryTextbox";
            baseSalaryTextbox.Size = new Size(382, 34);
            baseSalaryTextbox.TabIndex = 22;
            // 
            // editPositionTitle
            // 
            editPositionTitle.AutoSize = true;
            editPositionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            editPositionTitle.Location = new Point(280, 42);
            editPositionTitle.Name = "editPositionTitle";
            editPositionTitle.Size = new Size(190, 32);
            editPositionTitle.TabIndex = 21;
            editPositionTitle.Text = "Nueva Posición";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(196, 381);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 37);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // baseSalaryLabel
            // 
            baseSalaryLabel.AutoSize = true;
            baseSalaryLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            baseSalaryLabel.Location = new Point(189, 205);
            baseSalaryLabel.Name = "baseSalaryLabel";
            baseSalaryLabel.Size = new Size(121, 25);
            baseSalaryLabel.TabIndex = 1;
            baseSalaryLabel.Text = "Salario base";
            // 
            // positionNameLabel
            // 
            positionNameLabel.AutoSize = true;
            positionNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            positionNameLabel.Location = new Point(125, 135);
            positionNameLabel.Name = "positionNameLabel";
            positionNameLabel.Size = new Size(185, 25);
            positionNameLabel.TabIndex = 0;
            positionNameLabel.Text = "Nombre de posición";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(404, 383);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // positionNameTextbox
            // 
            positionNameTextbox.Location = new Point(324, 135);
            positionNameTextbox.Multiline = true;
            positionNameTextbox.Name = "positionNameTextbox";
            positionNameTextbox.Size = new Size(382, 34);
            positionNameTextbox.TabIndex = 7;
            // 
            // validationErrorProvider
            // 
            validationErrorProvider.ContainerControl = this;
            // 
            // PositionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 671);
            Controls.Add(editDepartmentGroupbox);
            Name = "PositionForm";
            Text = "PositionForm";
            editDepartmentGroupbox.ResumeLayout(false);
            editDepartmentGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox editDepartmentGroupbox;
        private ComboBox departmentCombobox;
        private Label departmentLabel;
        private TextBox baseSalaryTextbox;
        private Label editPositionTitle;
        private Button btnCancel;
        private Label baseSalaryLabel;
        private Label positionNameLabel;
        private Button btnGuardar;
        private TextBox positionNameTextbox;
        private ErrorProvider validationErrorProvider;
    }
}