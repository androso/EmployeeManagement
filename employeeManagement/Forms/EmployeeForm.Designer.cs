namespace PresentationLayer.Forms
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            label1 = new Label();
            birthDateLabel = new Label();
            hireDateLabel = new Label();
            phoneLabel = new Label();
            birthDate = new DateTimePicker();
            hireDate = new DateTimePicker();
            phoneTextbox = new TextBox();
            fullNameTextbox = new TextBox();
            pictureBox1 = new PictureBox();
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            positionCombobox = new ComboBox();
            label5 = new Label();
            btnSalir = new Button();
            validationErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 199);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo :";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthDateLabel.Location = new Point(37, 282);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(207, 25);
            birthDateLabel.TabIndex = 1;
            birthDateLabel.Text = "Fecha de Nacimiento :";
            // 
            // hireDateLabel
            // 
            hireDateLabel.AutoSize = true;
            hireDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hireDateLabel.Location = new Point(10, 352);
            hireDateLabel.Name = "hireDateLabel";
            hireDateLabel.Size = new Size(214, 25);
            hireDateLabel.TabIndex = 2;
            hireDateLabel.Text = "fecha de Contratación :";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(156, 413);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(100, 25);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Telefono :";
            // 
            // birthDate
            // 
            birthDate.Location = new Point(312, 279);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(309, 27);
            birthDate.TabIndex = 4;
            // 
            // hireDate
            // 
            hireDate.Location = new Point(312, 349);
            hireDate.Name = "hireDate";
            hireDate.Size = new Size(309, 27);
            hireDate.TabIndex = 5;
            // 
            // phoneTextbox
            // 
            phoneTextbox.Location = new Point(312, 407);
            phoneTextbox.Multiline = true;
            phoneTextbox.Name = "phoneTextbox";
            phoneTextbox.Size = new Size(235, 34);
            phoneTextbox.TabIndex = 6;
            // 
            // fullNameTextbox
            // 
            fullNameTextbox.Location = new Point(312, 199);
            fullNameTextbox.Multiline = true;
            fullNameTextbox.Name = "fullNameTextbox";
            fullNameTextbox.Size = new Size(411, 34);
            fullNameTextbox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(282, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(447, 565);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(positionCombobox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(birthDateLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(hireDateLabel);
            groupBox1.Controls.Add(phoneLabel);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(birthDate);
            groupBox1.Controls.Add(hireDate);
            groupBox1.Controls.Add(fullNameTextbox);
            groupBox1.Controls.Add(phoneTextbox);
            groupBox1.Location = new Point(386, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(741, 672);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // positionCombobox
            // 
            positionCombobox.FormattingEnabled = true;
            positionCombobox.Location = new Point(312, 474);
            positionCombobox.Name = "positionCombobox";
            positionCombobox.Size = new Size(309, 28);
            positionCombobox.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(156, 473);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 21;
            label5.Text = "Posición :";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(171, 563);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(133, 37);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // validationErrorProvider
            // 
            validationErrorProvider.ContainerControl = this;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1472, 786);
            Controls.Add(groupBox1);
            Name = "EmployeeForm";
            Text = "EmployeForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label birthDateLabel;
        private Label hireDateLabel;
        private Label phoneLabel;
        private DateTimePicker birthDate;
        private DateTimePicker hireDate;
        private TextBox phoneTextbox;
        private TextBox fullNameTextbox;
        private PictureBox pictureBox1;
        private Button btnGuardar;
        private GroupBox groupBox1;
        private Button btnSalir;
        private ComboBox positionCombobox;
        private Label label5;
        private ErrorProvider validationErrorProvider;
    }
}