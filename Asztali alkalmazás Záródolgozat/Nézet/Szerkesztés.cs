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
    public partial class Szerkesztés : Form
    {
        public Szerkesztés()
        {
            InitializeComponent();
        }

        private void Szerkesztés_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }
        public int getTelefonszámSzerkForm()
        { return Convert.ToInt32(textBoxTelefonszám.Text); }
        public string getNévSzerkForm()
        { return textBoxSzerkNev.Text; }
        public string getVárosSzerkForm()
        { return textBoxSzerkVaros.Text; }
        public string getMunkaSzerkForm()
        { return textBoxSzerkMegrendeles.Text; }
        public string getMunkatípusSzerkForm()
        { return textBoxSzerkMegrendelestipusa.Text; }
        public string getEmailSzerkForm()
        { return textBoxSzerkEmail.Text; }

        private void textBoxSzerkNev_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
