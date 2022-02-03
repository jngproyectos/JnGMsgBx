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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Btns
        private void btnCer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.ForeColor = Color.FromArgb(0, 51, 0);
        }
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.ForeColor = Color.White;
        }
        #endregion
        //Evento click del bóton para mostrar el form
        private void btn1_Click(object sender, EventArgs e)
        {
            //Llamamos el form y le pasamos los parametros
            Notificacion n = new Notificacion("Jng - Proyectos", "Guardado", "El empleado se guardo con éxito", Color.FromArgb(40, 167, 69), 1);
            n.ShowDialog(); //Mostramos el form
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Notificacion n = new Notificacion("Jng - Proyectos", "Actualizado", "El empleado se actualizó correctamente", Color.FromArgb(23, 162, 184), 2);
            n.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Notificacion n = new Notificacion("Jng - Proyectos", "Eliminado", "El empleado se elimino de forma permanente", Color.FromArgb(220, 53, 63), 3);
            n.ShowDialog();
        }
    }
}
