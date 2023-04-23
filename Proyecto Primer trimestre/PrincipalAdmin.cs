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
    public partial class PrincipalAdmin : Form
    {
        public PrincipalAdmin()
        {
            InitializeComponent();
        }


        #region //Botones para el manejo entre forms
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

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
    }
}
