namespace Practico4
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            Bagregar = new Button();
            Bfoto = new Button();
            TBfoto = new TextBox();
            TBsaldo = new TextBox();
            TBape = new TextBox();
            TBnom = new TextBox();
            RBmujer = new RadioButton();
            RBhombre = new RadioButton();
            Lsaldo = new Label();
            Lsexo = new Label();
            LFecha = new Label();
            DTfecha = new DateTimePicker();
            Lape = new Label();
            Lnom = new Label();
            dataGridView1 = new DataGridView();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(971, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 501);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Practicos.Properties.Resources.images;
            panel1.Controls.Add(Bagregar);
            panel1.Controls.Add(Bfoto);
            panel1.Controls.Add(TBfoto);
            panel1.Controls.Add(TBsaldo);
            panel1.Controls.Add(TBape);
            panel1.Controls.Add(TBnom);
            panel1.Controls.Add(RBmujer);
            panel1.Controls.Add(RBhombre);
            panel1.Controls.Add(Lsaldo);
            panel1.Controls.Add(Lsexo);
            panel1.Controls.Add(LFecha);
            panel1.Controls.Add(DTfecha);
            panel1.Controls.Add(Lape);
            panel1.Controls.Add(Lnom);
            panel1.Font = new Font("Papyrus", 16F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(72, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 607);
            panel1.TabIndex = 2;
            // 
            // Bagregar
            // 
            Bagregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Bagregar.ForeColor = SystemColors.ControlText;
            Bagregar.Image = (Image)resources.GetObject("Bagregar.Image");
            Bagregar.ImageAlign = ContentAlignment.MiddleLeft;
            Bagregar.Location = new Point(368, 542);
            Bagregar.Name = "Bagregar";
            Bagregar.Size = new Size(147, 57);
            Bagregar.TabIndex = 13;
            Bagregar.Text = "Agregar";
            Bagregar.TextAlign = ContentAlignment.MiddleRight;
            Bagregar.UseVisualStyleBackColor = true;
            // 
            // Bfoto
            // 
            Bfoto.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Bfoto.ForeColor = SystemColors.ControlText;
            Bfoto.Location = new Point(38, 398);
            Bfoto.Name = "Bfoto";
            Bfoto.Size = new Size(112, 34);
            Bfoto.TabIndex = 12;
            Bfoto.Text = "FOTO";
            Bfoto.UseVisualStyleBackColor = true;
            Bfoto.Click += Bfoto_Click;
            // 
            // TBfoto
            // 
            TBfoto.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBfoto.Location = new Point(211, 398);
            TBfoto.Name = "TBfoto";
            TBfoto.Size = new Size(569, 45);
            TBfoto.TabIndex = 11;
            // 
            // TBsaldo
            // 
            TBsaldo.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBsaldo.Location = new Point(211, 312);
            TBsaldo.Name = "TBsaldo";
            TBsaldo.Size = new Size(569, 45);
            TBsaldo.TabIndex = 10;
            // 
            // TBape
            // 
            TBape.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBape.Location = new Point(211, 105);
            TBape.Name = "TBape";
            TBape.Size = new Size(569, 45);
            TBape.TabIndex = 9;
            // 
            // TBnom
            // 
            TBnom.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBnom.Location = new Point(211, 30);
            TBnom.Name = "TBnom";
            TBnom.Size = new Size(569, 45);
            TBnom.TabIndex = 8;
            // 
            // RBmujer
            // 
            RBmujer.AutoSize = true;
            RBmujer.BackColor = Color.Transparent;
            RBmujer.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RBmujer.ForeColor = SystemColors.ControlLightLight;
            RBmujer.Location = new Point(441, 255);
            RBmujer.Name = "RBmujer";
            RBmujer.Size = new Size(106, 42);
            RBmujer.TabIndex = 7;
            RBmujer.TabStop = true;
            RBmujer.Text = "Mujer";
            RBmujer.UseVisualStyleBackColor = false;
            // 
            // RBhombre
            // 
            RBhombre.AutoSize = true;
            RBhombre.BackColor = Color.Transparent;
            RBhombre.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RBhombre.Location = new Point(248, 255);
            RBhombre.Name = "RBhombre";
            RBhombre.Size = new Size(128, 42);
            RBhombre.TabIndex = 6;
            RBhombre.TabStop = true;
            RBhombre.Text = "Hombre";
            RBhombre.UseVisualStyleBackColor = false;
            // 
            // Lsaldo
            // 
            Lsaldo.AutoSize = true;
            Lsaldo.BackColor = Color.Transparent;
            Lsaldo.Location = new Point(38, 312);
            Lsaldo.Name = "Lsaldo";
            Lsaldo.Size = new Size(119, 51);
            Lsaldo.TabIndex = 5;
            Lsaldo.Text = "Saldo:";
            // 
            // Lsexo
            // 
            Lsexo.AutoSize = true;
            Lsexo.BackColor = Color.Transparent;
            Lsexo.Location = new Point(38, 248);
            Lsexo.Name = "Lsexo";
            Lsexo.Size = new Size(110, 51);
            Lsexo.TabIndex = 4;
            Lsexo.Text = "Sexo:";
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.BackColor = Color.Transparent;
            LFecha.Location = new Point(33, 183);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(326, 51);
            LFecha.TabIndex = 3;
            LFecha.Text = "Fecha de Nacimiento:";
            // 
            // DTfecha
            // 
            DTfecha.CalendarFont = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DTfecha.Font = new Font("Perpetua", 13F, FontStyle.Regular, GraphicsUnit.Point);
            DTfecha.Format = DateTimePickerFormat.Short;
            DTfecha.Location = new Point(416, 193);
            DTfecha.Name = "DTfecha";
            DTfecha.Size = new Size(176, 37);
            DTfecha.TabIndex = 2;
            // 
            // Lape
            // 
            Lape.AutoSize = true;
            Lape.BackColor = Color.Transparent;
            Lape.Location = new Point(31, 105);
            Lape.Name = "Lape";
            Lape.Size = new Size(153, 51);
            Lape.TabIndex = 1;
            Lape.Text = "Apellido:";
            // 
            // Lnom
            // 
            Lnom.AutoSize = true;
            Lnom.BackColor = Color.Transparent;
            Lnom.Location = new Point(31, 30);
            Lnom.Name = "Lnom";
            Lnom.Size = new Size(144, 51);
            Lnom.TabIndex = 0;
            Lnom.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, FechaNacimiento, Sexo, Eliminar, Saldo, Foto, Ruta });
            dataGridView1.Location = new Point(170, 753);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1335, 225);
            dataGridView1.TabIndex = 4;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            FechaNacimiento.MinimumWidth = 8;
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Width = 150;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 8;
            Sexo.Name = "Sexo";
            Sexo.Width = 150;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Width = 150;
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.MinimumWidth = 8;
            Saldo.Name = "Saldo";
            Saldo.Width = 150;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.MinimumWidth = 8;
            Foto.Name = "Foto";
            Foto.Width = 150;
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.MinimumWidth = 8;
            Ruta.Name = "Ruta";
            Ruta.Width = 250;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1659, 1050);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario con Datagrid";
            WindowState = FormWindowState.Maximized;
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button Bagregar;
        private Button Bfoto;
        private TextBox TBfoto;
        private TextBox TBsaldo;
        private TextBox TBape;
        private TextBox TBnom;
        private RadioButton RBmujer;
        private RadioButton RBhombre;
        private Label Lsaldo;
        private Label Lsexo;
        private Label LFecha;
        private DateTimePicker DTfecha;
        private Label Lape;
        private Label Lnom;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Ruta;
        private OpenFileDialog openFileDialog1;
    }
}