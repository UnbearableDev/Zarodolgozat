using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Tár
{
    partial class Megrendelők : MegrendelőkF
    {
        private List<Megrendelő> megrendelők;
        /// <summary>
        /// Konstruktor a Listához
        /// </summary>
        public Megrendelők()
        {
            this.megrendelők = new List<Megrendelő>();
        }
        /// <summary>
        /// Get metódus a listához
        /// </summary>
        /// <returns>Megrendelők listáját</returns>
        public List<Megrendelő> getMegrendelők()
        {
            return megrendelők;
        }
        public int getMaximumAzonosító()
        {
            int maximumMegrendelőAzonosító = -1;
            foreach (Megrendelő m in megrendelők)
                if (m.getAzonosító() > maximumMegrendelőAzonosító)
                    maximumMegrendelőAzonosító = m.getAzonosító();
            return maximumMegrendelőAzonosító;
        }
    }
}
