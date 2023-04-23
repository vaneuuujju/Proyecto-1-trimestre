namespace Proyecto_Primer_trimestre
{
    partial class Index
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.txtIndex1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(293, 601);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.Location = new System.Drawing.Point(530, 9);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 49);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSiguiente.IconColor = System.Drawing.Color.Black;
            this.btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiguiente.Location = new System.Drawing.Point(369, 488);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(172, 59);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.UseWaitCursor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(319, 51);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(258, 263);
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // txtIndex1
            // 
            this.txtIndex1.AutoSize = true;
            this.txtIndex1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIndex1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.txtIndex1.Location = new System.Drawing.Point(369, 337);
            this.txtIndex1.Name = "txtIndex1";
            this.txtIndex1.Size = new System.Drawing.Size(168, 28);
            this.txtIndex1.TabIndex = 5;
            this.txtIndex1.Text = "Bienvenido al";
            this.txtIndex1.Click += new System.EventHandler(this.txtIndex1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(357, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jardin de Marta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(589, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIndex1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.Text = "Index";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox logo;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private Label txtIndex1;
        private Label label1;
    }
}