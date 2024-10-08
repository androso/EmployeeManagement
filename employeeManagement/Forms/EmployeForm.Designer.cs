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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 199);
            label1.Name = "label1";
            label1.Size = new Size(209, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 282);
            label2.Name = "label2";
            label2.Size = new Size(237, 24);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Nacimiento :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 379);
            label3.Name = "label3";
            label3.Size = new Size(264, 24);
            label3.TabIndex = 2;
            label3.Text = "fecha de Contratación :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(156, 475);
            label4.Name = "label4";
            label4.Size = new Size(118, 24);
            label4.TabIndex = 3;
            label4.Text = "Telefono :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(312, 279);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(309, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(312, 376);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(309, 27);
            dateTimePicker2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 469);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 34);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 199);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(411, 34);
            textBox2.TabIndex = 7;
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
            btnGuardar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(540, 613);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(386, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(741, 672);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(65, 613);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(133, 37);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // EmployeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1472, 786);
            Controls.Add(groupBox1);
            Name = "EmployeForm";
            Text = "EmployeForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button btnGuardar;
        private GroupBox groupBox1;
        private Button btnSalir;
    }
}