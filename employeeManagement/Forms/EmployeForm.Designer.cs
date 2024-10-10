namespace PresentationLayer.Forms
{
    partial class EmployeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeForm));
            nameLabel = new Label();
            DateLabel = new Label();
            dateCLabel = new Label();
            phoneLabel = new Label();
            dateBirthdayTimePicker = new DateTimePicker();
            ContractdateTimePicker = new DateTimePicker();
            PhonetextBox = new TextBox();
            NameTextBox = new TextBox();
            pictureBoxEmployed = new PictureBox();
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployed).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(65, 199);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(209, 24);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre Completo :";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateLabel.Location = new Point(37, 282);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(237, 24);
            DateLabel.TabIndex = 1;
            DateLabel.Text = "Fecha de Nacimiento :";
            // 
            // dateCLabel
            // 
            dateCLabel.AutoSize = true;
            dateCLabel.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateCLabel.Location = new Point(10, 379);
            dateCLabel.Name = "dateCLabel";
            dateCLabel.Size = new Size(264, 24);
            dateCLabel.TabIndex = 2;
            dateCLabel.Text = "fecha de Contratación :";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(156, 475);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(118, 24);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Telefono :";
            // 
            // dateBirthdayTimePicker
            // 
            dateBirthdayTimePicker.Cursor = Cursors.AppStarting;
            dateBirthdayTimePicker.Location = new Point(312, 279);
            dateBirthdayTimePicker.Name = "dateBirthdayTimePicker";
            dateBirthdayTimePicker.Size = new Size(309, 27);
            dateBirthdayTimePicker.TabIndex = 4;
            // 
            // ContractdateTimePicker
            // 
            ContractdateTimePicker.Cursor = Cursors.AppStarting;
            ContractdateTimePicker.Location = new Point(312, 376);
            ContractdateTimePicker.Name = "ContractdateTimePicker";
            ContractdateTimePicker.Size = new Size(309, 27);
            ContractdateTimePicker.TabIndex = 5;
            // 
            // PhonetextBox
            // 
            PhonetextBox.Cursor = Cursors.IBeam;
            PhonetextBox.Location = new Point(312, 469);
            PhonetextBox.Multiline = true;
            PhonetextBox.Name = "PhonetextBox";
            PhonetextBox.Size = new Size(235, 34);
            PhonetextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            NameTextBox.Cursor = Cursors.IBeam;
            NameTextBox.Location = new Point(312, 199);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(411, 34);
            NameTextBox.TabIndex = 7;
            // 
            // pictureBoxEmployed
            // 
            pictureBoxEmployed.Image = (Image)resources.GetObject("pictureBoxEmployed.Image");
            pictureBoxEmployed.Location = new Point(301, 36);
            pictureBoxEmployed.Name = "pictureBoxEmployed";
            pictureBoxEmployed.Size = new Size(156, 123);
            pictureBoxEmployed.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEmployed.TabIndex = 9;
            pictureBoxEmployed.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 255);
            btnGuardar.Cursor = Cursors.PanNorth;
            btnGuardar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(540, 613);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(DateLabel);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(dateCLabel);
            groupBox1.Controls.Add(phoneLabel);
            groupBox1.Controls.Add(pictureBoxEmployed);
            groupBox1.Controls.Add(dateBirthdayTimePicker);
            groupBox1.Controls.Add(ContractdateTimePicker);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Controls.Add(PhonetextBox);
            groupBox1.Location = new Point(386, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(741, 672);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(128, 255, 255);
            btnSalir.Cursor = Cursors.PanNorth;
            btnSalir.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(65, 613);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(133, 37);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // EmployeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1472, 786);
            Controls.Add(groupBox1);
            Name = "EmployeForm";
            Text = "EmployeForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployed).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label nameLabel;
        private Label DateLabel;
        private Label dateCLabel;
        private Label phoneLabel;
        private DateTimePicker dateBirthdayTimePicker;
        private DateTimePicker ContractdateTimePicker;
        private TextBox PhonetextBox;
        private TextBox NameTextBox;
        private PictureBox pictureBoxEmployed;
        private Button btnGuardar;
        private GroupBox groupBox1;
        private Button btnSalir;
    }
}