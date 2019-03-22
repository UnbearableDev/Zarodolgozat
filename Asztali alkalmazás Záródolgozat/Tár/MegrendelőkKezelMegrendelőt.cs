using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asztali_alkalmazás_Záródolgozat.Adatbázis;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Data;


namespace Asztali_alkalmazás_Záródolgozat.Tár
{
    public partial class Megrendelők : IMegrendelőkKezelMegrendelőtF
    {
        private MySQLDatabaseInterface AdatbázisParancsok = new MySQLDatabaseInterface();
        public DataTable MegrendelokDT = new DataTable();
        private Kapcsolat Kapcs = new Kapcsolat();
        public List<Megrendelő> feltöltMegrendelőkAdatbázisból()
        {
            string connectionString = Kapcs.connectionString();
           
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                throw new Exception("Adatbázis megnyitása nem lehetséges");
            }
            string query = "SELECT * FROM adminisztracio";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Megrendelő m = new Megrendelő(
                        Convert.ToInt32(dr["azonosito"]),
                        dr["nev"].ToString(),
                        dr["varos"].ToString(),
                         dr["email"].ToString(),
                          dr["munka"].ToString(),
                           dr["munkatipus"].ToString(),
                        Convert.ToInt32(dr["telefonszam"]));
                    megrendelők.Add(m);
                }
                dr.Close();
                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw new Exception("Hibás lekérdezés.");
            }
            return megrendelők;

        }
        public DataTable feltöltListábólAdattáblába()
        {
            Kapcsolat k = new Kapcsolat();
            AdatbázisParancsok = k.kapcsolodas();
            AdatbázisParancsok.open();
            MegrendelokDT = AdatbázisParancsok.getToDataTable("SELECT * FROM adminisztracio");
            foreach(Megrendelő m in megrendelők)
            {
                MegrendelokDT.Rows.Add(m.getAzonosító(), m.getNév(), m.getVáros(), m.getEmail(), m.getMunka(), m.getMunkatipus(), m.getTelefonszám());
            }
            AdatbázisParancsok.close();
            return MegrendelokDT;
        }
        /// <summary>
        /// Megrendelő hozzáadása listához
        /// </summary>
        /// <param name="megrendelő">A hozzáadásra kerülő megrendelő</param>
        public DataTable hozzáadMegrendelőt(Megrendelő megrendelő)
        {
            megrendelők.Add(megrendelő);
           DataTable add = feltöltListábólAdattáblába();
            return add;
        }
        /// <summary>
        /// Megrendelő törlése listából az index segitségével
        /// </summary>
        /// <param name="azonosító">Az azonosító amit a törlendő megrendelő azonosítására használunk</param>
        public void törölMegrendelőt(int azonosító)
        {
            int index = 0;
            foreach (Megrendelő m in megrendelők)
            {
                if (m.getAzonosító() == azonosító)
                {
                    megrendelők.RemoveAt(index);
                }
                index++;
            }

        }
        /// <summary>
        /// Megrendelő módosítása a listában azonosító segitségével
        /// </summary>
        /// <param name="azonosító">Megrendelő keresésére használt azonosító</param>
        /// <param name="Újmegrendelő">Már módosított megrendelő</param>
        public void módosítMegrendelőt(int azonosító, Megrendelő Újmegrendelő)
        {
            int index = 0;
            foreach (Megrendelő m in megrendelők)
            {
                if (m.getAzonosító() == azonosító)
                {
                    m.frissités(Újmegrendelő);
                    return;
                }
                index = index + 1;
            }
        }
        /// <summary>
        /// Megrendelők számolása
        /// </summary>
        /// <returns>Összes megrendelők számát</returns>
        public int számolMegrendelőt()
        {
            return megrendelők.Count();
        }
        /// <summary>
        /// Név alapján kikeres megrendelőt a listából
        /// </summary>
        /// <param name="név">a Név ami alapján kikeresi a megrendelőt</param>
        /// <returns></returns>
        public Megrendelő keresMegrendelőtNévről(string név)
        {
            foreach (Megrendelő m in megrendelők)
            
                if (m.getNév() == név)
                
                    return m;
                
                 return null;

            
        }
        /// <summary>
        /// Megnézi létezik e ilyen névvel rendelkező megrendelő
        /// </summary>
        /// <param name="név">Az erre a célra használt név</param>
        /// <returns></returns>
        public bool létezikeMegrendelőNévről(string név)
        {
            foreach (Megrendelő m in megrendelők)
            
                if (m.getNév() == név)
                
                    return true;
                
                 return false;
            
        }
        /// <summary>
        /// Név alapján azonosítót ad vissza
        /// </summary>
        /// <param name="név">Az erre a célra használt név</param>
        /// <returns></returns>
        public int visszaadKövetkezőMegrendelőAzonosítót()
        {
           
                int maximumAzonosító = 0;
                foreach (Megrendelő m in megrendelők)
                {
                int megrendelőkMaximumMegrendelőAzonosító = getMaximumAzonosító();
                    if (megrendelőkMaximumMegrendelőAzonosító > maximumAzonosító)
                        maximumAzonosító = megrendelőkMaximumMegrendelőAzonosító;
                }
                if (maximumAzonosító > 0)
                    return maximumAzonosító + 1;
                else
                    return 1;
         }
        
    }

}
