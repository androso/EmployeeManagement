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
            MaindataGridView = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            SelectComboBox = new ComboBox();
            textBox1 = new TextBox();
            MainLabel = new Label();
            btnEmploye = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnPosition = new Button();
            btnDepartment = new Button();
            pictureBoxMain = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MaindataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).BeginInit();
            SuspendLayout();
            // 
            // MaindataGridView
            // 
            MaindataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MaindataGridView.Location = new Point(588, 104);
            MaindataGridView.Name = "MaindataGridView";
            MaindataGridView.RowHeadersWidth = 51;
            MaindataGridView.Size = new Size(672, 475);
            MaindataGridView.TabIndex = 15;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(128, 255, 255);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(588, 618);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(178, 55);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(128, 255, 255);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(840, 617);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(179, 56);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 255);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(1100, 617);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 55);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // SelectComboBox
            // 
            SelectComboBox.Cursor = Cursors.AppStarting;
            SelectComboBox.FormattingEnabled = true;
            SelectComboBox.Items.AddRange(new object[] { "Empleado", "Departamento", "Posición" });
            SelectComboBox.Location = new Point(825, 52);
            SelectComboBox.Name = "SelectComboBox";
            SelectComboBox.Size = new Size(243, 28);
            SelectComboBox.TabIndex = 20;
            SelectComboBox.Text = "Seleccionar Datos";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(128, 128, 255);
            textBox1.Cursor = Cursors.PanNorth;
            textBox1.Dock = DockStyle.Left;
            textBox1.ForeColor = SystemColors.MenuText;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 725);
            textBox1.TabIndex = 26;
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.BackColor = Color.Cyan;
            MainLabel.BorderStyle = BorderStyle.Fixed3D;
            MainLabel.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainLabel.Location = new Point(8, 30);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(402, 42);
            MainLabel.TabIndex = 27;
            MainLabel.Text = "Gestionar Empleados";
            // 
            // btnEmploye
            // 
            btnEmploye.Location = new Point(56, 178);
            btnEmploye.Name = "btnEmploye";
            btnEmploye.Size = new Size(268, 65);
            btnEmploye.TabIndex = 28;
            btnEmploye.Text = "Crear Empleado";
            btnEmploye.UseVisualStyleBackColor = true;
            btnEmploye.Click += btnEmploye_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(67, 195);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(67, 447);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 33;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(67, 322);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // btnPosition
            // 
            btnPosition.Location = new Point(56, 301);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(268, 68);
            btnPosition.TabIndex = 31;
            btnPosition.Text = "Crear Posición";
            btnPosition.UseVisualStyleBackColor = true;
            btnPosition.Click += btnPosition_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.Location = new Point(56, 425);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(268, 70);
            btnDepartment.TabIndex = 30;
            btnDepartment.Text = "Crear Departamento";
            btnDepartment.UseVisualStyleBackColor = true;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // pictureBoxMain
            // 
            pictureBoxMain.Image = (Image)resources.GetObject("pictureBoxMain.Image");
            pictureBoxMain.Location = new Point(762, 50);
            pictureBoxMain.Name = "pictureBoxMain";
            pictureBoxMain.Size = new Size(39, 30);
            pictureBoxMain.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMain.TabIndex = 34;
            pictureBoxMain.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 725);
            Controls.Add(pictureBoxMain);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(btnPosition);
            Controls.Add(btnDepartment);
            Controls.Add(pictureBox3);
            Controls.Add(btnEmploye);
            Controls.Add(MainLabel);
            Controls.Add(textBox1);
            Controls.Add(SelectComboBox);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(MaindataGridView);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)MaindataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView MaindataGridView;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
        private ComboBox SelectComboBox;
        private TextBox textBox1;
        private Label MainLabel;
        private Button btnEmploye;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Button btnPosition;
        private Button btnDepartment;
        private PictureBox pictureBoxMain;
    }
}