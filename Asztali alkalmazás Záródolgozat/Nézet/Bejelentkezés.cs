using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asztali_alkalmazás_Záródolgozat.Nézet
{
    public partial class Bejelentkezés : Form
    {
        public Bejelentkezés()
        {
            InitializeComponent();
        }

        private void Bejelentkezés_Load(object sender, EventArgs e)
        {
            
            
        }

        private void buttonMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBejelentkezes_Click(object sender, EventArgs e)
        {
            Multitool MT = new Multitool();
            MT.Show();
            this.Hide();
        }
    }
}
