using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsFormsApp1
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        public int timeLeft { get; set; }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }

            else
            {
                Tiempo.Stop();
                new FrmLogin().Show();
                this.Hide();

            }
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            timeLeft = 25;
            Tiempo.Start();
        }
    }
}
