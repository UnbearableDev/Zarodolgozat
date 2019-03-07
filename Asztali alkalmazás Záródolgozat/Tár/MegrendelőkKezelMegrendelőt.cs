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
        /// 
        /// </summary>
        /// <param name="megrendelő"></param>
        public void hozzáadMegrendelőt(Megrendelő megrendelő)
        {
            megrendelők.Add(megrendelő);
        }
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
        /// 
        /// </summary>
        /// <param name="azonosító"></param>
        /// <param name="Újmegrendelő"></param>
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
        /// 
        /// </summary>
        /// <returns></returns>
        public int számolMegrendelőt()
        {
            return megrendelők.Count();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="név"></param>
        /// <returns></returns>
        public Megrendelő keresMegrendelőtNévről(string név)
        {
            foreach (Megrendelő m in megrendelők)
            
                if (m.getNév() == név)
                
                    return m;
                
                 return null;

            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="név"></param>
        /// <returns></returns>
        public bool létezikeMegrendelőNévről(string név)
        {
            foreach (Megrendelő m in megrendelők)
            
                if (m.getNév() == név)
                
                    return true;
                
                 return false;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="név"></param>
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
