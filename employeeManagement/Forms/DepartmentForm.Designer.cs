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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            btnSalir = new Button();
            btnGuardar = new Button();
            addNameDepartment = new TextBox();
            nameDepartmentLabel = new Label();
            departmentLabel = new Label();
            DepartmentgroupBox = new GroupBox();
            DepartmentgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(310, 416);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(131, 35);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(134, 416);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 35);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // addNameDepartment
            // 
            addNameDepartment.Location = new Point(50, 220);
            addNameDepartment.Multiline = true;
            addNameDepartment.Name = "addNameDepartment";
            addNameDepartment.Size = new Size(514, 40);
            addNameDepartment.TabIndex = 20;
            // 
            // nameDepartmentLabel
            // 
            nameDepartmentLabel.AutoSize = true;
            nameDepartmentLabel.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameDepartmentLabel.Location = new Point(50, 170);
            nameDepartmentLabel.Name = "nameDepartmentLabel";
            nameDepartmentLabel.Size = new Size(320, 27);
            nameDepartmentLabel.TabIndex = 15;
            nameDepartmentLabel.Text = "Nombre de Departamento";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentLabel.Location = new Point(186, 66);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(230, 33);
            departmentLabel.TabIndex = 14;
            departmentLabel.Text = "Departamento";
            // 
            // DepartmentgroupBox
            // 
            DepartmentgroupBox.BackColor = Color.Transparent;
            DepartmentgroupBox.Controls.Add(btnGuardar);
            DepartmentgroupBox.Controls.Add(addNameDepartment);
            DepartmentgroupBox.Controls.Add(nameDepartmentLabel);
            DepartmentgroupBox.Controls.Add(departmentLabel);
            DepartmentgroupBox.Controls.Add(btnSalir);
            DepartmentgroupBox.Location = new Point(397, 65);
            DepartmentgroupBox.Name = "DepartmentgroupBox";
            DepartmentgroupBox.Size = new Size(603, 589);
            DepartmentgroupBox.TabIndex = 22;
            DepartmentgroupBox.TabStop = false;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1433, 748);
            Controls.Add(DepartmentgroupBox);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            Load += DepartmentForm_Load;
            DepartmentgroupBox.ResumeLayout(false);
            DepartmentgroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnGuardar;
        private TextBox addNameDepartment;
        private Label nameDepartmentLabel;
        private Label departmentLabel;
        private GroupBox DepartmentgroupBox;
    }
}