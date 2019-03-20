using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asztali_alkalmazás_Záródolgozat.Tár;
using Asztali_alkalmazás_Záródolgozat.Adatbázis;
using Asztali_alkalmazás_Záródolgozat.Nézet;
using System.Data;

namespace Asztali_alkalmazás_Záródolgozat.Vezérlő
{
    class MegrendelőVezérlő 
    {
        DataTable adatok = new DataTable();
        Megrendelők m = new Megrendelők();
        MySQLDatabaseInterface AdatbázisParancsok = new MySQLDatabaseInterface();
        
        public void hozzáadniMegrendelőtMegrendelőkhöz( string email, string munka, string munkatípus, string név, int telefonszám, string város)
        {
            int MegrendelőAzonosító = m.visszaadKövetkezőMegrendelőAzonosítót();
                Megrendelő újMegrendelő = new Megrendelő(MegrendelőAzonosító, név, város, email, munka, munkatípus, telefonszám);
                m.hozzáadMegrendelőt(újMegrendelő);
            Kapcsolat k = new Kapcsolat();
            AdatbázisParancsok = k.kapcsolodas();
            AdatbázisParancsok.open();
            AdatbázisParancsok.updateChangesInTable(m.feltöltListábólAdattáblába());
           

        }
        public void törölniMegrendelőtMegrendelőkböl(int azonosító)
        {

                m.törölMegrendelőt(azonosító);
            AdatbázisParancsok.updateChangesInTable(m.feltöltListábólAdattáblába());
        }
        public void módosítaniMegrendelőtMegrendelőkhöz(int állandóAzonosító,string email, string munka, string munkatípus, string név, int telefonszám, string város)
        {
            Megrendelő módosítottMegrendelő = new Megrendelő(állandóAzonosító, név, város, email, munka, munkatípus, telefonszám);
            m.módosítMegrendelőt(állandóAzonosító, módosítottMegrendelő);
            AdatbázisParancsok.updateChangesInTable(m.feltöltListábólAdattáblába());
        }
        public DataTable betölteniMegrendelőket( )
        {
            m.feltöltMegrendelőkAdatbázisból();
            Kapcsolat k = new Kapcsolat();
            AdatbázisParancsok = k.kapcsolodas();
            AdatbázisParancsok.open();
            adatok = m.feltöltListábólAdattáblába(); 
            return adatok;
        }
        public DataTable adatokFrissitése()
        {
            DataTable DT = m.feltöltListábólAdattáblába();
            return DT;
        }
     
    }
}
