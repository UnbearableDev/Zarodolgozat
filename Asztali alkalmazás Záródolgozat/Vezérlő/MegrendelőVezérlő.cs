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
          return d;
        }
        public void törölniMegrendelőtMegrendelőkböl(int azonosító)
        {

                m.törölMegrendelőt(azonosító);
         
        }
        public DataTable módosítaniMegrendelőtMegrendelőkhöz(int állandóAzonosító,string email, string munka, string munkatípus, string név, int telefonszám, string város)
        {
            Megrendelő módosítottMegrendelő = new Megrendelő(állandóAzonosító, név, város, email, munka, munkatípus, telefonszám);
            
            DataTable d = m.módosítMegrendelőt(állandóAzonosító, módosítottMegrendelő);
            return d;
        }
        public DataTable betölteniMegrendelőket( )
        {
            DataTable DT = m.feltöltListábólAdattáblába();
           // feltöltMegrendelőketAdatbázisból();
            return DT;
        }
     
        public void feltöltMegrendelőketAdatbázisból()
        {
            m.feltöltMegrendelőkAdatbázisból();
        }
     
    }
}
