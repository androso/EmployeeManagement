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
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(488, 256);
            label1.Name = "label1";
            label1.Size = new Size(209, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(460, 336);
            label2.Name = "label2";
            label2.Size = new Size(237, 24);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Nacimiento :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(433, 436);
            label3.Name = "label3";
            label3.Size = new Size(264, 24);
            label3.TabIndex = 2;
            label3.Text = "fecha de Contratación :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(579, 532);
            label4.Name = "label4";
            label4.Size = new Size(118, 24);
            label4.TabIndex = 3;
            label4.Text = "Telefono :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(735, 336);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(291, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(735, 433);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(291, 27);
            dateTimePicker2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(735, 526);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 34);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(735, 255);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(503, 34);
            textBox2.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(735, 632);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(705, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1346, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(1226, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(1110, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // EmployeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 717);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeForm";
            Text = "EmployeForm";
            Load += EmployeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnSalir;
        private PictureBox pictureBox1;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnEditar;
    }
}