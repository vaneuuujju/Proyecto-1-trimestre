namespace Proyecto_Primer_trimestre
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.txtContrsena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new FontAwesome.Sharp.IconButton();
            this.btnMostrasContra = new FontAwesome.Sharp.IconButton();
            this.btnOcultar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(299, 601);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.Location = new System.Drawing.Point(691, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 39);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnRegresar.IconColor = System.Drawing.Color.Black;
            this.btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegresar.IconSize = 30;
            this.btnRegresar.Location = new System.Drawing.Point(550, 0);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(46, 39);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(364, 73);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(292, 256);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // txtContrsena
            // 
            this.txtContrsena.BackColor = System.Drawing.Color.Silver;
            this.txtContrsena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContrsena.Location = new System.Drawing.Point(387, 396);
            this.txtContrsena.Name = "txtContrsena";
            this.txtContrsena.Size = new System.Drawing.Size(219, 23);
            this.txtContrsena.TabIndex = 7;
            this.txtContrsena.Text = "Contraseña";
            this.txtContrsena.TextChanged += new System.EventHandler(this.txtContrsena_TextChanged);
            this.txtContrsena.Enter += new System.EventHandler(this.txtContrsena_Enter);
            this.txtContrsena.Leave += new System.EventHandler(this.txtContrsena_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Silver;
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.Location = new System.Drawing.Point(387, 335);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(243, 23);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Text = "Nombre de usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIngresar.IconColor = System.Drawing.Color.Black;
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.Location = new System.Drawing.Point(434, 454);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(172, 59);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.UseWaitCursor = true;
            // 
            // btnMostrasContra
            // 
            this.btnMostrasContra.BackColor = System.Drawing.Color.Silver;
            this.btnMostrasContra.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnMostrasContra.IconColor = System.Drawing.Color.Black;
            this.btnMostrasContra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrasContra.IconSize = 25;
            this.btnMostrasContra.Location = new System.Drawing.Point(601, 396);
            this.btnMostrasContra.Margin = new System.Windows.Forms.Padding(0);
            this.btnMostrasContra.Name = "btnMostrasContra";
            this.btnMostrasContra.Size = new System.Drawing.Size(29, 23);
            this.btnMostrasContra.TabIndex = 10;
            this.btnMostrasContra.UseVisualStyleBackColor = false;
            this.btnMostrasContra.Click += new System.EventHandler(this.btnMostrasContra_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.BackColor = System.Drawing.Color.Silver;
            this.btnOcultar.FlatAppearance.BorderSize = 0;
            this.btnOcultar.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnOcultar.IconColor = System.Drawing.Color.Black;
            this.btnOcultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOcultar.IconSize = 25;
            this.btnOcultar.Location = new System.Drawing.Point(601, 396);
            this.btnOcultar.Margin = new System.Windows.Forms.Padding(0);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(29, 23);
            this.btnOcultar.TabIndex = 11;
            this.btnOcultar.UseVisualStyleBackColor = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.ArrowsToCircle;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 30;
            this.btnMinimizar.Location = new System.Drawing.Point(596, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(46, 39);
            this.btnMinimizar.TabIndex = 12;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.White;
            this.btnNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNormal.BackgroundImage")));
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.Location = new System.Drawing.Point(645, 0);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(46, 39);
            this.btnNormal.TabIndex = 13;
            this.btnNormal.TabStop = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.UpRightFromSquare;
            this.btnMaximizar.IconColor = System.Drawing.Color.Black;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 30;
            this.btnMaximizar.Location = new System.Drawing.Point(645, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(46, 39);
            this.btnMaximizar.TabIndex = 14;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(734, 535);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnMostrasContra);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrsena);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private PictureBox logo;
        private TextBox txtContrsena;
        private TextBox txtUsuario;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnMostrasContra;
        private FontAwesome.Sharp.IconButton btnOcultar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private PictureBox btnNormal;
        private FontAwesome.Sharp.IconButton btnMaximizar;
    }
}