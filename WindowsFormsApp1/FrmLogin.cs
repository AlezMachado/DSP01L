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
            FrmRegistro frm = new FrmRegistro();
            frm.ShowDialog();
        }
    }
}
