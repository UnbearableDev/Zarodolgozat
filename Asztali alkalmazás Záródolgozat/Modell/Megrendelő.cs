using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Modell
{
    class Megrendelő
    {
        private int azonosító;
        private string név;
        private string város;
        private string email;
        private string munka;
        private string munkatipus;
        private int telefonszám;

        public Megrendelő(int azonosító, string név, string város, string email, string munka, string munkatipus,int telefonszám)
        {
            this.azonosító = azonosító;
            this.név = név;
            this.város = város;
            this.email = email;
            this.munka = munka;
            this.munkatipus = munkatipus;
            this.telefonszám = telefonszám;
        }
        public int getAzonosító()
        {
            return azonosító;
        }
        public string getNév()
        {
            return név;
        }
        public string getVáros()
        {
            return város;
        }
        public string getEmail()
        {
            return email;
        }
        public string getMunka()
        {
            return munka;
        }
        public string getMunkatipus()
        {
            return munkatipus;
        }
        public int getTelefonszám()
        {
            return telefonszám;
        }
        public void setAzonosító(int azonosító)
        {
            this.azonosító = azonosító;
        }

        public void setNév(string név)
        {
            this.név = név;
        }

        public void setVáros(string város)
        {
            this.város = város;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setMunka(string munka)
        {
            this.munka = munka;
               }

        public void setMunkatipus(string munkatipus)
        {
            this.munkatipus = munkatipus;
        }

        public void setTelefonszam(int telefonszám)
        {
            this.telefonszám = telefonszám;
        }
    }
}
