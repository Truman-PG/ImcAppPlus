namespace ImcAppPlus
{
    partial class frmCalculaImc
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
            numAltura = new NumericUpDown();
            numPeso = new NumericUpDown();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lblResultado = new Label();
            ImagemIMC = new PictureBox();
            lblSeta = new Label();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagemIMC).BeginInit();
            SuspendLayout();
            // 
            // numAltura
            // 
            numAltura.DecimalPlaces = 2;
            numAltura.Location = new Point(66, 234);
            numAltura.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(180, 31);
            numAltura.TabIndex = 0;
            numAltura.TextAlign = HorizontalAlignment.Right;
            // 
            // numPeso
            // 
            numPeso.DecimalPlaces = 2;
            numPeso.Location = new Point(66, 107);
            numPeso.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(180, 31);
            numPeso.TabIndex = 1;
            numPeso.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Location = new Point(66, 309);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 66);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 3;
            label1.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 178);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 4;
            label2.Text = "Altura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 17);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 5;
            label3.Text = "Calculo IMC";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(numAltura);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numPeso);
            panel1.Location = new Point(12, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 405);
            panel1.TabIndex = 6;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Perpetua Titling MT", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(368, 24);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(71, 72);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "0";
            // 
            // ImagemIMC
            // 
            ImagemIMC.Image = Properties.Resources.tabela_imc_peso_720x267;
            ImagemIMC.Location = new Point(359, 100);
            ImagemIMC.Name = "ImagemIMC";
            ImagemIMC.Size = new Size(720, 267);
            ImagemIMC.TabIndex = 8;
            ImagemIMC.TabStop = false;
            // 
            // lblSeta
            // 
            lblSeta.AutoSize = true;
            lblSeta.BackColor = Color.Transparent;
            lblSeta.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeta.ForeColor = Color.Red;
            lblSeta.Location = new Point(649, 457);
            lblSeta.Name = "lblSeta";
            lblSeta.Size = new Size(80, 96);
            lblSeta.TabIndex = 9;
            lblSeta.Text = "⬆";
            lblSeta.Visible = false;
            // 
            // frmCalculaImc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 562);
            Controls.Add(lblSeta);
            Controls.Add(ImagemIMC);
            Controls.Add(lblResultado);
            Controls.Add(panel1);
            Name = "frmCalculaImc";
            Text = "Calculo IMC";
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImagemIMC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numAltura;
        private NumericUpDown numPeso;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label lblResultado;
        private PictureBox ImagemIMC;
        private Label lblSeta;
    }
}
