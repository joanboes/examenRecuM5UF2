using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_M5UF2_git
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btMenjar_Click(object sender, EventArgs e)
        {
            FrmMenjar frmMenjar = new FrmMenjar();
            frmMenjar.Show();
        }

        private void btViatge_Click(object sender, EventArgs e)
        {
            FrmViatge frmViatge = new FrmViatge();
            frmViatge.Show();
        }
    }
}
