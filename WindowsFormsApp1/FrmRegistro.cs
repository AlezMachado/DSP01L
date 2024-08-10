using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        User user = new User();

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            user.Register(TxtNombre.Text, TxtApellido.Text, TxtUsuario.Text, TxtPassword.Text);

            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtUsuario.Clear();
            TxtPassword.Clear();
        }
    }
}
