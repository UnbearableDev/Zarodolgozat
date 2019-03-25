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
        public void feltöltMegrendelőkAdatbázisból()
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
            Kapcsolat k = new Kapcsolat();
            AdatbázisParancsok = k.kapcsolodas();
            AdatbázisParancsok.open();
            DataTable AdatHozzáad = feltöltListábólAdattáblába();
            AdatbázisParancsok.getToDataTable("SELECT * FROM adminisztacio");
            AdatHozzáad.Rows.Add(megrendelő.getAzonosító(),
                megrendelő.getNév(),
                megrendelő.getVáros(),
                megrendelő.getEmail(),
                megrendelő.getMunka(),
                megrendelő.getMunkatipus(),
                megrendelő.getTelefonszám());
            AdatbázisParancsok.updateChangesInTable(AdatHozzáad);
            AdatbázisParancsok.close();
            return AdatHozzáad;
        }
        /// <summary>
        /// Megrendelő törlése listából az index segitségével
        /// </summary>
        /// <param name="azonosító">Az azonosító amit a törlendő megrendelő azonosítására használunk</param>
        public DataTable törölMegrendelőt(int sor ,int azonosító)
        {
            Kapcsolat k = new Kapcsolat();
            AdatbázisParancsok = k.kapcsolodas();
            AdatbázisParancsok.open();
            DataTable AdatTöröl = AdatbázisParancsok.getToDataTable("SELECT * FROM adminisztracio");
            AdatTöröl.Rows.RemoveAt(sor);
            string connectionString = Kapcs.connectionString();

           
            string query= "DELETE FROM adminisztracio WHERE azonosito = " + azonosító + "";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
            
            AdatbázisParancsok.updateChangesInTable(AdatTöröl);
            
            return AdatTöröl;
        }
        /// <summary>
        /// Megrendelő módosítása a listában azonosító segitségével
        /// </summary>
        /// <param name="azonosító">Megrendelő keresésére használt azonosító</param>
        /// <param name="Újmegrendelő">Már módosított megrendelő</param>
        public DataTable módosítMegrendelőt(int azonosító, Megrendelő Újmegrendelő)
        {
            string connectionString = Kapcs.connectionString();

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw new Exception("Adatbázis megnyitása nem lehetséges");
            }

            string query = "UPDATE adminisztracio SET azonosito = '" + Újmegrendelő.getAzonosító() + "', nev = '" + Újmegrendelő.getNév() + "', varos = '" + Újmegrendelő.getVáros() + "', email = '" + Újmegrendelő.getEmail() + "', munka = '" + Újmegrendelő.getMunka() + "', munkatipus = '" + Újmegrendelő.getMunkatipus()+ "', telefonszam = '" + Újmegrendelő.getTelefonszám() + "' WHERE azonosito = " + Újmegrendelő.getAzonosító() + "";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }

            connection.Close();
            
            Kapcsolat k = new Kapcsolat();
            AdatbázisParancsok = k.kapcsolodas();
            AdatbázisParancsok.open();
            DataTable AdatMódosít = AdatbázisParancsok.getToDataTable("SELECT * FROM adminisztracio");
            return AdatMódosít;
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
           return Convert.ToInt32(MegrendelokDT.Rows[MegrendelokDT.Rows.Count-1].ItemArray[0].ToString())+1;

           // return MegrendelokDT.Rows.Count + 1;
  
         }
        
    }

}
