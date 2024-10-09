namespace PresentationLayer.Forms
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            groupBox1 = new GroupBox();
            positionCombobox = new ComboBox();
            label5 = new Label();
            btnCancel = new Button();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            birthDate = new DateTimePicker();
            hireDate = new DateTimePicker();
            fullNameTextbox = new TextBox();
            phone = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(positionCombobox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(birthDate);
            groupBox1.Controls.Add(hireDate);
            groupBox1.Controls.Add(fullNameTextbox);
            groupBox1.Controls.Add(phone);
            groupBox1.Location = new Point(23, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(741, 653);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // positionCombobox
            // 
            positionCombobox.FormattingEnabled = true;
            positionCombobox.Location = new Point(312, 457);
            positionCombobox.Name = "positionCombobox";
            positionCombobox.Size = new Size(309, 28);
            positionCombobox.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(156, 456);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 19;
            label5.Text = "Posición :";
            label5.Click += label5_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(218, 551);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 37);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 272);
            label2.Name = "label2";
            label2.Size = new Size(207, 25);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Nacimiento :";
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
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(416, 553);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 330);
            label3.Name = "label3";
            label3.Size = new Size(214, 25);
            label3.TabIndex = 2;
            label3.Text = "fecha de Contratación :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(156, 394);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 3;
            label4.Text = "Telefono :";
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
            // birthDate
            // 
            birthDate.Location = new Point(312, 269);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(309, 27);
            birthDate.TabIndex = 4;
            // 
            // hireDate
            // 
            hireDate.Location = new Point(312, 327);
            hireDate.Name = "hireDate";
            hireDate.Size = new Size(309, 27);
            hireDate.TabIndex = 5;
            // 
            // fullNameTextbox
            // 
            fullNameTextbox.Location = new Point(312, 199);
            fullNameTextbox.Multiline = true;
            fullNameTextbox.Name = "fullNameTextbox";
            fullNameTextbox.Size = new Size(411, 34);
            fullNameTextbox.TabIndex = 7;
            // 
            // phone
            // 
            phone.Location = new Point(312, 388);
            phone.Multiline = true;
            phone.Name = "phone";
            phone.Size = new Size(235, 34);
            phone.TabIndex = 6;
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 686);
            Controls.Add(groupBox1);
            Name = "EditEmployee";
            Text = "EditEmployee";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Button btnCancel;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private DateTimePicker birthDate;
        private DateTimePicker hireDate;
        private TextBox fullNameTextbox;
        private TextBox phone;
        private ComboBox positionCombobox;
    }
}