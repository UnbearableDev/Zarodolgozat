﻿using System;
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
        
        Megrendelők m = new Megrendelők();
        MySQLDatabaseInterface AdatbázisParancsok = new MySQLDatabaseInterface();
        
        public DataTable hozzáadniMegrendelőtMegrendelőkhöz( string email, string munka, string munkatípus, string név, int telefonszám, string város)
        {
          int MegrendelőAzonosító = m.visszaadKövetkezőMegrendelőAzonosítót();
          Megrendelő újMegrendelő = new Megrendelő(MegrendelőAzonosító, név, város, email, munka, munkatípus, telefonszám);
          DataTable d =  m.hozzáadMegrendelőt(újMegrendelő);
          return d;
        }
        public DataTable törölniMegrendelőtMegrendelőkböl(int sor,int azonosító)
        {

             return   m.törölMegrendelőt(sor, azonosító);
         
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
         
            return DT;
        }
     
        public void feltöltMegrendelőketAdatbázisból()
        {
            m.feltöltMegrendelőkAdatbázisból();
        }
        public int visszaAdMaximumMegrendelőt()
        {
            DataTable adatok = m.feltöltListábólAdattáblába();
            return adatok.Rows.Count;
         
        }
     
    }
}
