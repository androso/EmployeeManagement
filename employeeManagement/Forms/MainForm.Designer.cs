namespace PresentationLayer.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnEmploye = new Button();
            btnDepartment = new Button();
            btnPosition = new Button();
            dataGridView1 = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            comboBox1 = new ComboBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnEmploye
            // 
            btnEmploye.Location = new Point(1082, 115);
            btnEmploye.Name = "btnEmploye";
            btnEmploye.Size = new Size(231, 55);
            btnEmploye.TabIndex = 0;
            btnEmploye.Text = "Crear Empleado";
            btnEmploye.UseVisualStyleBackColor = true;
            btnEmploye.Click += btnEmploye_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.Location = new Point(1082, 319);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(231, 55);
            btnDepartment.TabIndex = 1;
            btnDepartment.Text = "Crear Departamento";
            btnDepartment.UseVisualStyleBackColor = true;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnPosition
            // 
            btnPosition.Location = new Point(1082, 216);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(231, 55);
            btnPosition.TabIndex = 2;
            btnPosition.Text = "Crear Posición";
            btnPosition.UseVisualStyleBackColor = true;
            btnPosition.Click += btnPosition_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(355, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(672, 475);
            dataGridView1.TabIndex = 15;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(365, 618);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 46);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(611, 618);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 46);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(881, 618);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 45);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Empleado", "Departamento", "Posición" });
            comboBox1.Location = new Point(564, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(243, 28);
            comboBox1.TabIndex = 20;
            comboBox1.Text = "Seleccionar Datos";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1093, 229);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1093, 128);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1093, 335);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 725);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(comboBox1);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dataGridView1);
            Controls.Add(btnPosition);
            Controls.Add(btnDepartment);
            Controls.Add(btnEmploye);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmploye;
        private Button btnDepartment;
        private Button btnPosition;
        private DataGridView dataGridView1;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}