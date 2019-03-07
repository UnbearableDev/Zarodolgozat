using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Tár
{
    partial class Megrendelők : MegrendelőkKezelMegrendelőtF
    {
        /// <summary>
        /// Megrendelő hozzáadása listához
        /// </summary>
        /// <param name="megrendelő">A hozzáadásra kerülő megrendelő</param>
        public void hozzáadMegrendelőt(Megrendelő megrendelő)
        {
            megrendelők.Add(megrendelő);
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
        public int visszaadMegrendelőAzonosítót(string név)
        {
            foreach (Megrendelő m in megrendelők)
            
                if (m.getNév() == név)
                
                    return m.getAzonosító();
                
                 return -1;
            
        }
    }
}
