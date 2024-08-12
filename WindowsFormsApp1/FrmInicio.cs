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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();

            tabControl1.TabPages[0].Text = "Programas de entrenimiento";
            tabControl1.TabPages[1].Text = "Libros";
            tabControl1.TabPages[2].Text = "Lenguajes de programacón";
            tabControl1.TabPages[3].Text = "Estadisticas";

        }

    }
}
