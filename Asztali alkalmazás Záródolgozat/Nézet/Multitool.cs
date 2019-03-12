using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asztali_alkalmazás_Záródolgozat.Vezérlő;

namespace Asztali_alkalmazás_Záródolgozat
{
    public partial class Multitool : Form
    {
        MegrendelőVezérlő vezérlő = new MegrendelőVezérlő();
        public Multitool()
        {
            InitializeComponent();
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonHozzaadas_Click(object sender, EventArgs e)
        {
            vezérlő.hozzáadniMegrendelőtMegrendelőkhöz();
        }

        private void buttonSzerkesztes_Click(object sender, EventArgs e)
        {
            vezérlő.módosítaniMegrendelőtMegrendelőkhöz();
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            vezérlő.törölniMegrendelőtMegrendelőkböl()
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            vezérlő.betölteniMegrendelőket();
        }
    }
}
