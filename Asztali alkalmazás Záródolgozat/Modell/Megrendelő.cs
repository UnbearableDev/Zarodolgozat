using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Tár
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="azonosító"></param>
        /// <param name="név"></param>
        /// <param name="város"></param>
        /// <param name="email"></param>
        /// <param name="munka"></param>
        /// <param name="munkatipus"></param>
        /// <param name="telefonszám"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="megrendelő"></param>
        public void frissités(Megrendelő megrendelő)
        {
            this.azonosító = megrendelő.getAzonosító();
            this.név = megrendelő.getNév();
            this.város = megrendelő.getVáros();
            this.email = megrendelő.getEmail();
            this.munka = megrendelő.getMunka();
            this.munkatipus = megrendelő.getMunkatipus();
            this.telefonszám = megrendelő.getTelefonszám();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Azonosító: " + azonosító + "Teljes Név: " + név + "Város: " + város + "E-mail cím: " + email + "Munka leírása: " + munka + "Munka típusa: " + munkatipus + "Telefonszám: " + telefonszám;
        }
    }
}
