using Asztali_alkalmazás_Záródolgozat.Adatbázis;
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
        private MySQLDatabaseInterface AdatbázisParancsok = new MySQLDatabaseInterface();
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
            bool Authorization = false ;
            Kapcsolat k = new Kapcsolat();
            AdatbázisParancsok = k.kapcsolodas();
            AdatbázisParancsok.open();
            DataTable Adatok = AdatbázisParancsok.getToDataTable("SELECT * FROM bejelentkezes");
            for(int i = 0; i< Adatok.Rows.Count;i++)
            {
               if(Adatok.Rows[i].Field<string>(0) == textBoxFelhasznalonev.Text && Adatok.Rows[0].Field<string>(1) == textBoxJelszo.Text)
                {
                    Authorization = true;
                }
            }
            if (Authorization == true)
            {
                Multitool MT = new Multitool();
                MT.Show();
                this.Hide();
            }
            else
            {

            }
        }
    }
}
