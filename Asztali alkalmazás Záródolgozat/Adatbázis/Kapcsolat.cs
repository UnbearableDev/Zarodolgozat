﻿using System;
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
            mdi.setConnectionServerData("localhost", "megrendelok", "3306");
            mdi.setConnectionUserData("root", "");
            mdi.makeConnectionToDatabase();

            return mdi;
        }
    }
}
