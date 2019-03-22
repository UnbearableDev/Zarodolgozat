using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asztali_alkalmazás_Záródolgozat.Tár;
using Asztali_alkalmazás_Záródolgozat.Adatbázis;
using Asztali_alkalmazás_Záródolgozat.Nézet;
using System.Data;
using System.Diagnostics;

namespace Asztali_alkalmazás_Záródolgozat.Vezérlő
{
    class MegrendelőVezérlő 
    {
        DataTable adatok = new DataTable();
        Megrendelők m = new Megrendelők();
        MySQLDatabaseInterface AdatbázisParancsok = new MySQLDatabaseInterface();
        
        public DataTable hozzáadniMegrendelőtMegrendelőkhöz( string email, string munka, string munkatípus, string név, int telefonszám, string város)
        {
            int MegrendelőAzonosító = m.visszaadKövetkezőMegrendelőAzonosítót();
                Megrendelő újMegrendelő = new Megrendelő(MegrendelőAzonosító, név, város, email, munka, munkatípus, telefonszám);
             DataTable d =  m.hozzáadMegrendelőt(újMegrendelő);
            Kapcsolat k = new Kapcsolat();
            AdatbázisParancsok = k.kapcsolodas();
            AdatbázisParancsok.open();
            AdatbázisParancsok.updateChangesInTable(betölteniMegrendelőket());
            AdatbázisParancsok.close();
            return d;
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
            
            Kapcsolat k = new Kapcsolat();
            AdatbázisParancsok = k.kapcsolodas();
            AdatbázisParancsok.open();
            adatok = m.feltöltListábólAdattáblába();
            AdatbázisParancsok.close();
            return adatok;
        }
        public DataTable adatokFrissitése()
        {
            DataTable DT = m.feltöltListábólAdattáblába();
            return DT;
        }
        public void feltöltMegrendelőketAdatbázisból()
        {
            m.feltöltMegrendelőkAdatbázisból();
        }
     
    }
}
