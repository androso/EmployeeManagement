namespace PresentationLayer.Forms
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            editDepartmentGroupbox = new GroupBox();
            departmentDescriptionTextBox = new RichTextBox();
            newDepartmentTitle = new Label();
            btnCancel = new Button();
            departmentDescriptionLabel = new Label();
            departmentTitleLabel = new Label();
            btnGuardar = new Button();
            departmentNameTextbox = new TextBox();
            validationErrorProvider = new ErrorProvider(components);
            editDepartmentGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // editDepartmentGroupbox
            // 
            editDepartmentGroupbox.Controls.Add(departmentDescriptionTextBox);
            editDepartmentGroupbox.Controls.Add(newDepartmentTitle);
            editDepartmentGroupbox.Controls.Add(btnCancel);
            editDepartmentGroupbox.Controls.Add(departmentDescriptionLabel);
            editDepartmentGroupbox.Controls.Add(departmentTitleLabel);
            editDepartmentGroupbox.Controls.Add(btnGuardar);
            editDepartmentGroupbox.Controls.Add(departmentNameTextbox);
            editDepartmentGroupbox.Location = new Point(346, 134);
            editDepartmentGroupbox.Name = "editDepartmentGroupbox";
            editDepartmentGroupbox.Size = new Size(769, 480);
            editDepartmentGroupbox.TabIndex = 16;
            editDepartmentGroupbox.TabStop = false;
            // 
            // departmentDescriptionTextBox
            // 
            departmentDescriptionTextBox.Location = new Point(324, 205);
            departmentDescriptionTextBox.Name = "departmentDescriptionTextBox";
            departmentDescriptionTextBox.Size = new Size(382, 134);
            departmentDescriptionTextBox.TabIndex = 22;
            departmentDescriptionTextBox.Text = "";
            // 
            // newDepartmentTitle
            // 
            newDepartmentTitle.AutoSize = true;
            newDepartmentTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            newDepartmentTitle.Location = new Point(238, 46);
            newDepartmentTitle.Name = "newDepartmentTitle";
            newDepartmentTitle.Size = new Size(262, 32);
            newDepartmentTitle.TabIndex = 21;
            newDepartmentTitle.Text = "Nuevo Departamento";
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
            // 
            // departmentDescriptionLabel
            // 
            departmentDescriptionLabel.AutoSize = true;
            departmentDescriptionLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentDescriptionLabel.Location = new Point(196, 205);
            departmentDescriptionLabel.Name = "departmentDescriptionLabel";
            departmentDescriptionLabel.Size = new Size(114, 25);
            departmentDescriptionLabel.TabIndex = 1;
            departmentDescriptionLabel.Text = "Descripción";
            // 
            // departmentTitleLabel
            // 
            departmentTitleLabel.AutoSize = true;
            departmentTitleLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentTitleLabel.Location = new Point(77, 135);
            departmentTitleLabel.Name = "departmentTitleLabel";
            departmentTitleLabel.Size = new Size(233, 25);
            departmentTitleLabel.TabIndex = 0;
            departmentTitleLabel.Text = "Nombre de departamento";
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
            // departmentNameTextbox
            // 
            departmentNameTextbox.Location = new Point(324, 135);
            departmentNameTextbox.Multiline = true;
            departmentNameTextbox.Name = "departmentNameTextbox";
            departmentNameTextbox.Size = new Size(382, 34);
            departmentNameTextbox.TabIndex = 7;
            // 
            // validationErrorProvider
            // 
            validationErrorProvider.ContainerControl = this;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1433, 748);
            Controls.Add(editDepartmentGroupbox);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            editDepartmentGroupbox.ResumeLayout(false);
            editDepartmentGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox editDepartmentGroupbox;
        private RichTextBox departmentDescriptionTextBox;
        private Label newDepartmentTitle;
        private Button btnCancel;
        private Label departmentDescriptionLabel;
        private Label departmentTitleLabel;
        private Button btnGuardar;
        private TextBox departmentNameTextbox;
        private ErrorProvider validationErrorProvider;
    }
}