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
using Asztali_alkalmazás_Záródolgozat.Tár;

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

            vezérlő.hozzáadniMegrendelőtMegrendelőkhöz(textBoxMultiEmail.Text,
                textBoxMultiMegrendeles.Text,
                textBoxMultiMegrendelestipusa.Text,
                textBoxMultiNev.Text,
                Convert.ToInt32(textBoxTelefonszam.Text),
                textBoxMultiVaros.Text);
            datagridviewFrissités();
            
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
                datagridviewFrissités();
            }

        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            vezérlő.törölniMegrendelőtMegrendelőkböl(visszaadVálasztottAzonosítót());
            datagridviewFrissités();
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            datagridviewFrissités();
        }

        private void Multitool_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private int visszaadVálasztottAzonosítót()
        {
            return  Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
        }
        private void datagridviewFrissités()
        {
            MegrendelőDT = vezérlő.adatokFrissitése();
            dataGridView1.DataSource = MegrendelőDT;
        }

        private void buttonKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
