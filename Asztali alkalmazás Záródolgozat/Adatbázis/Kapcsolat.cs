using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Asztali_alkalmazás_Záródolgozat.Adatbázis
{
    class Kapcsolat
    {
        public MySQLDatabaseInterface kapcsolodas()
        {
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi.setErrorToUserInterface(true);
            mdi.setErrorToGraphicalUserInterface(false);
            mdi.setConnectionServerData("localhost", "web_asztali_adatbazis", "3306");
            mdi.setConnectionUserData("root", "");
           
            mdi.makeConnectionToDatabase();

            return mdi;
        }
        public string connectionString()
        {
            string connectionString =
              "SERVER=\"localhost\";"
            //"SERVER=\"127.0.0.1\";"
            + "DATABASE=\"web_asztali_adatbazis\";"
            + "UID=\"root\";"
            + "PASSWORD=\"\";"
            + "PORT=\"3306\";"
            + "SslMode = none";
            return connectionString;
        }
    }
}
