using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Primer_trimestre
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        #region //Botones de manejo entre forms
        //cierra todo
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalAdmin formulario = new PrincipalAdmin();
            formulario.Show();
        }
        //permite volver al formulario anterior mientras se tenga permisos para dirigirse al mismo
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index index = new Index();
            index.Show();
        }

        //variables para btnMaxi
        int posY, posX;//ubicacion actual
        int sw, sh;//tamaño actual
                   //abarca toda la pantalla
        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            posX = this.Location.X;
            posY = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;//se esconde este
            //se muestra el boton para volver a lo normal
            btnNormal.Visible = true; //este boton vuelve todo al tamaño inicial
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Permite que el form vuelva a ser normal
        private void btnNormal_Click(object sender, EventArgs e)
        {
            //valores previos del btn
            this.Size = new Size(sw, sh);
            this.Location = new Point(posX, posY);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;

        }
        #endregion


        #region //Eventos de los text box
        string txtTempo; //para los eventos leave y enter de los textBox
        private void txtContrsena_TextChanged(object sender, EventArgs e)
        {
            txtContrsena.UseSystemPasswordChar = true;

        }
        private void txtContrsena_Leave(object sender, EventArgs e)
        {
            if (txtContrsena.Text == "")//verifica si el text box esta vacio
            {
                txtContrsena.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }
        //al hacer click el texto por default se borra automaticamente
        private void txtContrsena_Enter(object sender, EventArgs e)
        {
            txtTempo = txtContrsena.Text;
            txtContrsena.Text = "";
        }
        //al hacer click el texto por default se borra automaticamente
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtTempo = txtUsuario.Text;
            txtUsuario.Text = "";
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = txtTempo; //txtTempo= el texto temporal que trae el cuadro
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }


        #endregion

        #region //Eventos de contraseña
        private void btnMostrasContra_Click(object sender, EventArgs e)
        {
            //si esta siendo mostrada se pone en pantalla el btn contrario
            btnOcultar.BringToFront();
            if (txtContrsena.UseSystemPasswordChar)
            {
                txtContrsena.UseSystemPasswordChar = false;//esta asi por default 
                btnMostrasContra.Text = "Ocultar";
            }
            else
            {
                btnOcultar.BringToFront();
                txtContrsena.UseSystemPasswordChar = true;//muestra la conrtaseña
                btnMostrasContra.Text = "Mostrar";
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            btnMostrasContra.BringToFront();

        }
        #endregion

    }
}
