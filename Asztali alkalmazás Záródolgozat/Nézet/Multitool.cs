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
using Asztali_alkalmazás_Záródolgozat.Tár;
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

            vezérlő.hozzáadniMegrendelőtMegrendelőkhöz(textBoxMultiEmail.Text,
                textBoxMultiMegrendeles.Text,
                textBoxMultiMegrendelestipusa.Text,
                textBoxMultiNev.Text,
                Convert.ToInt32(textBoxTelefonszam.Text),
                textBoxMultiVaros.Text);
            //datagridviewFrissités();
            
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
             //   datagridviewFrissités();
            }

        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            vezérlő.törölniMegrendelőtMegrendelőkböl(visszaadVálasztottAzonosítót());
           // datagridviewFrissités();
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            vezérlő.feltöltMegrendelőketAdatbázisból();
            dataGridView1.DataSource = MegrendelőDT;
           // datagridviewFrissités();
        }

        private void Multitool_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MegrendelőDT = vezérlő.adatokFrissitése();
            dataGridView1.DataSource = MegrendelőDT;
        }
        private int visszaadVálasztottAzonosítót()
        {
            int Érték = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()); ;
            return Érték;
           


        }
       // private void datagridviewFrissités()
       // {
         //   MegrendelőDT = vezérlő.adatokFrissitése();
           // dataGridView1.DataSource = MegrendelőDT;
           // AdatbázisParancsok.updateChangesInTable(MegrendelőDT);
  
            
 //       }

        private void buttonKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
