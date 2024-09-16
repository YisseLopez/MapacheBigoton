namespace Mapavhes
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            pictureBox1 = new PictureBox();
            btnNuevaCita = new Button();
            btnCitasRegistradas = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNuevaCita
            // 
            btnNuevaCita.BackColor = Color.DarkCyan;
            btnNuevaCita.Font = new Font("Copperplate Gothic Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaCita.Location = new Point(403, 69);
            btnNuevaCita.Name = "btnNuevaCita";
            btnNuevaCita.Size = new Size(146, 50);
            btnNuevaCita.TabIndex = 1;
            btnNuevaCita.Text = "Nueva cita";
            btnNuevaCita.UseVisualStyleBackColor = false;
            btnNuevaCita.Click += btnNuevaCita_Click;
            // 
            // btnCitasRegistradas
            // 
            btnCitasRegistradas.BackColor = Color.PaleTurquoise;
            btnCitasRegistradas.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCitasRegistradas.ForeColor = SystemColors.ActiveCaptionText;
            btnCitasRegistradas.Location = new Point(403, 147);
            btnCitasRegistradas.Name = "btnCitasRegistradas";
            btnCitasRegistradas.Size = new Size(146, 50);
            btnCitasRegistradas.TabIndex = 2;
            btnCitasRegistradas.Text = "Citas registradas";
            btnCitasRegistradas.UseVisualStyleBackColor = false;
            btnCitasRegistradas.Click += btnCitasRegistradas_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightSalmon;
            btnSalir.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(403, 235);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(146, 50);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 195);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 4;
            label1.Text = "Barber \"El Mapache Bigotón\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 235);
            label2.Name = "label2";
            label2.Size = new Size(267, 15);
            label2.TabIndex = 5;
            label2.Text = "Calle Emiliano Zapata, No. 1175, Barrio de Francia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 270);
            label3.Name = "label3";
            label3.Size = new Size(189, 15);
            label3.TabIndex = 6;
            label3.Text = "\"El refugio del caballero moderno\"";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 310);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 7;
            label4.Text = "Tel. 231 222 3568";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGreen;
            pictureBox2.Location = new Point(310, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(312, 371);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(622, 365);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnCitasRegistradas);
            Controls.Add(btnNuevaCita);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "FrmInicio";
            Text = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnNuevaCita;
        private Button btnCitasRegistradas;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
    }
}