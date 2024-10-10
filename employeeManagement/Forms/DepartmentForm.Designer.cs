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
            btnSalir = new Button();
            btnGuardar = new Button();
            nameDepartmentLabel = new Label();
            departmentLabel = new Label();
            DepartmentgroupBox = new GroupBox();
            DepartmentComboBox = new ComboBox();
            pictureBoxDepartment = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            DescriptionrichTextBox = new RichTextBox();
            DescriptionLabel = new Label();
            DepartmentgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDepartment).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(128, 255, 255);
            btnSalir.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(383, 443);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(131, 35);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 255);
            btnGuardar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(124, 443);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 35);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // nameDepartmentLabel
            // 
            nameDepartmentLabel.AutoSize = true;
            nameDepartmentLabel.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameDepartmentLabel.Location = new Point(144, 123);
            nameDepartmentLabel.Name = "nameDepartmentLabel";
            nameDepartmentLabel.Size = new Size(320, 27);
            nameDepartmentLabel.TabIndex = 15;
            nameDepartmentLabel.Text = "Nombre de Departamento";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentLabel.Location = new Point(201, 52);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(230, 33);
            departmentLabel.TabIndex = 14;
            departmentLabel.Text = "Departamento";
            // 
            // DepartmentgroupBox
            // 
            DepartmentgroupBox.BackColor = Color.White;
            DepartmentgroupBox.Controls.Add(DescriptionLabel);
            DepartmentgroupBox.Controls.Add(DescriptionrichTextBox);
            DepartmentgroupBox.Controls.Add(DepartmentComboBox);
            DepartmentgroupBox.Controls.Add(btnGuardar);
            DepartmentgroupBox.Controls.Add(nameDepartmentLabel);
            DepartmentgroupBox.Controls.Add(departmentLabel);
            DepartmentgroupBox.Controls.Add(btnSalir);
            DepartmentgroupBox.Location = new Point(597, 100);
            DepartmentgroupBox.Name = "DepartmentgroupBox";
            DepartmentgroupBox.Size = new Size(617, 533);
            DepartmentgroupBox.TabIndex = 22;
            DepartmentgroupBox.TabStop = false;
            // 
            // DepartmentComboBox
            // 
            DepartmentComboBox.FormattingEnabled = true;
            DepartmentComboBox.Location = new Point(144, 178);
            DepartmentComboBox.Name = "DepartmentComboBox";
            DepartmentComboBox.Size = new Size(320, 28);
            DepartmentComboBox.TabIndex = 22;
            // 
            // pictureBoxDepartment
            // 
            pictureBoxDepartment.Image = (Image)resources.GetObject("pictureBoxDepartment.Image");
            pictureBoxDepartment.Location = new Point(110, 100);
            pictureBoxDepartment.Name = "pictureBoxDepartment";
            pictureBoxDepartment.Size = new Size(490, 533);
            pictureBoxDepartment.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDepartment.TabIndex = 23;
            pictureBoxDepartment.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // DescriptionrichTextBox
            // 
            DescriptionrichTextBox.Location = new Point(144, 263);
            DescriptionrichTextBox.Name = "DescriptionrichTextBox";
            DescriptionrichTextBox.Size = new Size(320, 160);
            DescriptionrichTextBox.TabIndex = 23;
            DescriptionrichTextBox.Text = "";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionLabel.Location = new Point(144, 233);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(158, 27);
            DescriptionLabel.TabIndex = 24;
            DescriptionLabel.Text = "Descripción";
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1433, 748);
            Controls.Add(pictureBoxDepartment);
            Controls.Add(DepartmentgroupBox);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            Load += DepartmentForm_Load;
            DepartmentgroupBox.ResumeLayout(false);
            DepartmentgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDepartment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnGuardar;
        private Label nameDepartmentLabel;
        private Label departmentLabel;
        private GroupBox DepartmentgroupBox;
        private ComboBox DepartmentComboBox;
        private PictureBox pictureBoxDepartment;
        private RichTextBox DescriptionrichTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private Label DescriptionLabel;
    }
}