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
        private MegrendelőkKezelMegrendelőtF megrendelőketKezelőMetódusok;
        private MySQLDatabaseInterface AdatbázisParancsok;
        
        public void hozzáadniMegrendelőtMegrendelőkhöz( string email, string munka, string munkatípus, string név, int telefonszám, string város)
        {

            
            
                int MegrendelőAzonosító = megrendelőketKezelőMetódusok.visszaadKövetkezőMegrendelőAzonosítót();
                Megrendelő újMegrendelő = new Megrendelő(MegrendelőAzonosító, név, város, email, munka, munkatípus, telefonszám);
                megrendelőketKezelőMetódusok.hozzáadMegrendelőt(újMegrendelő);
            
            
            

            
        }
        public void törölniMegrendelőtMegrendelőkböl(int azonosító)
        {
            
            
                megrendelőketKezelőMetódusok.törölMegrendelőt(azonosító);
        
        }
        public void módosítaniMegrendelőtMegrendelőkhöz(int állandóAzonosító,string email, string munka, string munkatípus, string név, int telefonszám, string város)
        {
            Megrendelő módosítottMegrendelő = new Megrendelő(állandóAzonosító, név, város, email, munka, munkatípus, telefonszám);
            megrendelőketKezelőMetódusok.módosítMegrendelőt(állandóAzonosító, módosítottMegrendelő);
        }
        public DataTable betölteniMegrendelőket( )
        {
            DataTable adatok;
            Kapcsolat k = new Kapcsolat();
            AdatbázisParancsok = k.kapcsolodas();
            AdatbázisParancsok.open();
            adatok = AdatbázisParancsok.getToDataTable("SELECT * FROM megrendelok");
            return adatok;
            
        }
     
    }
}
