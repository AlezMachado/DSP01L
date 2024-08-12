using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            LblHora.Text = DateTime.Now.ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Esta seguro que desea salir del Sistema?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
       
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "usuario1" && TxtPassword.Text == "admin1")
            {
                FrmInicio menu_Princ = new FrmInicio();
                menu_Princ.ShowDialog();
            }

            else if (TxtUsuario.Text == "usuario2" && TxtPassword.Text == "admin1")
            {
                FrmInicio menu_Princ = new FrmInicio();
                menu_Princ.ShowDialog();
            }

            else if (TxtUsuario.Text == "usuario3" && TxtPassword.Text == "admin1")
            {
                FrmInicio menu_Princ = new FrmInicio();
                menu_Princ.ShowDialog();
            }
            else if (TxtUsuario.Text == "usuario4" && TxtPassword.Text == "admin1")
            {
                FrmInicio menu_Princ = new FrmInicio();
                menu_Princ.ShowDialog();
            }
            else if (TxtUsuario.Text == "usuario5" && TxtPassword.Text == "admin1")
            {
                FrmInicio menu_Princ = new FrmInicio();
                menu_Princ.ShowDialog();
            }

            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos, vuelve a ingresar");
                TxtUsuario.Clear();
                TxtPassword.Clear();
            }
        }
    }
}
