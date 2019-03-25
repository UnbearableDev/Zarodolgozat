using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Asztali_alkalmazás_Záródolgozat.Vezérlő;
using Asztali_alkalmazás_Záródolgozat.Adatbázis;

namespace Asztali_alkalmazás_Záródolgozat.Nézet
{
    public partial class Multitool : Form
    {
        MegrendelőVezérlő vezérlő = new MegrendelőVezérlő();
        DataTable MegrendelőDT = new DataTable();
        MySQLDatabaseInterface AdatbázisParancsok = new MySQLDatabaseInterface();
        public Multitool()
        {
           
            InitializeComponent();
            
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonHozzaadas_Click(object sender, EventArgs e)
        {

            MegrendelőDT =  vezérlő.hozzáadniMegrendelőtMegrendelőkhöz(textBoxMultiEmail.Text,
                textBoxMultiMegrendeles.Text,
                textBoxMultiMegrendelestipusa.Text,
                textBoxMultiNev.Text,
                Convert.ToInt32(textBoxTelefonszam.Text),
                textBoxMultiVaros.Text);
            dataGridViewMultiTool.DataSource = MegrendelőDT;
            
        }

        private void buttonSzerkesztes_Click(object sender, EventArgs e)
        {
            Szerkesztés szerkform = new Szerkesztés();
           
            if (szerkform.ShowDialog() == DialogResult.OK)
            {
               
                vezérlő.módosítaniMegrendelőtMegrendelőkhöz(
                    visszaadVálasztottAzonosítót(),
                    szerkform.getEmailSzerkForm(),
                    szerkform.getMunkaSzerkForm(),
                    szerkform.getMunkatípusSzerkForm(),
                    szerkform.getNévSzerkForm(),
                    szerkform.getTelefonszámSzerkForm(),
                    szerkform.getVárosSzerkForm());

                frissités();
            }

        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            int sor = dataGridViewMultiTool.SelectedRows[0].Index;
            vezérlő.törölniMegrendelőtMegrendelőkböl(sor,visszaadVálasztottAzonosítót());
            frissités();
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            frissités();

        }

        private void Multitool_Load(object sender, EventArgs e)
        {
            dataGridViewMultiTool.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }
        private int visszaadVálasztottAzonosítót()
        {
            DataGridViewRow row = this.dataGridViewMultiTool.SelectedRows[0];
            int Érték = Convert.ToInt32(row.Cells["azonosito"].Value.ToString());
            return Érték;
           


        }
      
    

        private void buttonKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frissités()
        {
            MegrendelőDT = vezérlő.betölteniMegrendelőket();
            dataGridViewMultiTool.DataSource = MegrendelőDT;
        }
    }
}
