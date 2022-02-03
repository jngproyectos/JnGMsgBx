using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msg
{
    public partial class Notificacion : Form
    {
        public Notificacion()
        {
            InitializeComponent();
        }
        //Sobrecargamos el constructor con parametros
        public Notificacion(string pTitulo, string pMsgIm, string pMsg, Color pColor, int pImg)
        {
            InitializeComponent();
            //Cambiamos el text de los labels con los string de los parametros
            //que recibimos
            lblTitulo.Text = pTitulo;//cambiamos el text del label 
            lblImagen.Text = pMsgIm;
            lblMsg.Text = pMsg;
            lblTitulo.ForeColor = pColor;//Color de letra
            pRight.BackColor = pColor;// color de fondo de los panel´s
            pImagen.BackColor = pColor;
            //Condición para ocultar o mostrar las imagenes
            if(pImg == 1)//imagen success
            {
                pbInfo.Visible = false;
                pbDel.Visible = false;
            }
            else if(pImg == 2)//Imagen info
            {
                pbSuc.Visible = false;
                pbDel.Visible = false;
            }
            else if (pImg == 3)//Imagen delte
            {
                pbSuc.Visible = false;
                pbInfo.Visible = false;
            }
        }
        //Evento click del bóton
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //evento cuando el mouse entre en el boóton
        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            //Cambiamos el color a rojo
            btnCerrar.ForeColor = Color.Red;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            //Regresa a color negro cuando salga del bóton
            btnCerrar.ForeColor = Color.Black; 
        }
    }
}
