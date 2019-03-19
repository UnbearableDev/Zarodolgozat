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

namespace Asztali_alkalmazás_Záródolgozat.Nézet
{
    public partial class Multitool : Form
    {
        MegrendelőVezérlő vezérlő = new MegrendelőVezérlő();
        DataTable MegrendelőDT = new DataTable();
        public Multitool()
        {
           
            InitializeComponent();
            
            dataGridView1.DataSource = MegrendelőDT;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonHozzaadas_Click(object sender, EventArgs e)
        {

            vezérlő.hozzáadniMegrendelőtMegrendelőkhöz(Convert.ToString(textBoxMultiEmail),Convert.ToString(textBoxMultiMegrendeles),Convert.ToString(textBoxMultiMegrendelestipusa),Convert.ToString(textBoxMultiNev),Convert.ToInt32(textBoxTelefonszam),Convert.ToString(textBoxMultiVaros));
        }

        private void buttonSzerkesztes_Click(object sender, EventArgs e)
        {
            Szerkesztés szerkform = new Szerkesztés();
            szerkform.ShowDialog();
            if (szerkform.ShowDialog() == DialogResult.OK)
            {
                vezérlő.módosítaniMegrendelőtMegrendelőkhöz(visszaadVálasztottAzonosítót,);
            }

        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            vezérlő.törölniMegrendelőtMegrendelőkböl(visszaadVálasztottAzonosítót());
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
           MegrendelőDT =  vezérlő.betölteniMegrendelőket();
        }

        private void Multitool_Load(object sender, EventArgs e)
        {
           
        }
        private int visszaadVálasztottAzonosítót()
        {
            return  Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
        }
    }
}
