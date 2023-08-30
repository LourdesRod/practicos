namespace Practico5
{
    partial class Form4
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            Ldesde = new Label();
            Lhasta = new Label();
            TBdesde = new TextBox();
            TBhasta = new TextBox();
            label3 = new Label();
            Bgenerar = new Button();
            Bpares = new Button();
            Bimpares = new Button();
            Bprimos = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(519, 110);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(252, 254);
            listBox1.TabIndex = 0;
            // 
            // Ldesde
            // 
            Ldesde.AutoSize = true;
            Ldesde.Location = new Point(61, 93);
            Ldesde.Name = "Ldesde";
            Ldesde.Size = new Size(62, 25);
            Ldesde.TabIndex = 1;
            Ldesde.Text = "Desde";
            // 
            // Lhasta
            // 
            Lhasta.AutoSize = true;
            Lhasta.Location = new Point(61, 147);
            Lhasta.Name = "Lhasta";
            Lhasta.Size = new Size(57, 25);
            Lhasta.TabIndex = 2;
            Lhasta.Text = "Hasta";
            // 
            // TBdesde
            // 
            TBdesde.Location = new Point(147, 93);
            TBdesde.Name = "TBdesde";
            TBdesde.Size = new Size(150, 31);
            TBdesde.TabIndex = 3;
            // 
            // TBhasta
            // 
            TBhasta.Location = new Point(147, 147);
            TBhasta.Name = "TBhasta";
            TBhasta.Size = new Size(150, 31);
            TBhasta.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bernard MT Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(272, 27);
            label3.Name = "label3";
            label3.Size = new Size(213, 33);
            label3.TabIndex = 5;
            label3.Text = "Lista de Números";
            // 
            // Bgenerar
            // 
            Bgenerar.Location = new Point(112, 232);
            Bgenerar.Name = "Bgenerar";
            Bgenerar.Size = new Size(185, 34);
            Bgenerar.TabIndex = 6;
            Bgenerar.Text = "Generar Función";
            Bgenerar.UseVisualStyleBackColor = true;
            Bgenerar.Click += Bgenerar_Click;
            // 
            // Bpares
            // 
            Bpares.Location = new Point(118, 285);
            Bpares.Name = "Bpares";
            Bpares.Size = new Size(163, 34);
            Bpares.TabIndex = 7;
            Bpares.Text = "Numeros pares";
            Bpares.UseVisualStyleBackColor = true;
            Bpares.Click += Bpares_Click;
            // 
            // Bimpares
            // 
            Bimpares.Location = new Point(118, 333);
            Bimpares.Name = "Bimpares";
            Bimpares.Size = new Size(163, 34);
            Bimpares.TabIndex = 8;
            Bimpares.Text = "Numeros impares";
            Bimpares.UseVisualStyleBackColor = true;
            Bimpares.Click += Bimpares_Click;
            // 
            // Bprimos
            // 
            Bprimos.Location = new Point(118, 384);
            Bprimos.Name = "Bprimos";
            Bprimos.Size = new Size(163, 34);
            Bprimos.TabIndex = 9;
            Bprimos.Text = "Numeros primos";
            Bprimos.UseVisualStyleBackColor = true;
            Bprimos.Click += Bprimos_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Bprimos);
            Controls.Add(Bimpares);
            Controls.Add(Bpares);
            Controls.Add(Bgenerar);
            Controls.Add(label3);
            Controls.Add(TBhasta);
            Controls.Add(TBdesde);
            Controls.Add(Lhasta);
            Controls.Add(Ldesde);
            Controls.Add(listBox1);
            Name = "Form4";
            Text = "Formulario 4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label Ldesde;
        private Label Lhasta;
        private TextBox TBdesde;
        private TextBox TBhasta;
        private Label label3;
        private Button Bgenerar;
        private Button Bpares;
        private Button Bimpares;
        private Button Bprimos;
    }
}