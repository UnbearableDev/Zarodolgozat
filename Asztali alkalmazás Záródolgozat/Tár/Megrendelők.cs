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
        /// 
        /// </summary>
        public Megrendelők()
        {
            this.megrendelők = new List<Megrendelő>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Megrendelő> getMegrendelők()
        {
            return megrendelők;
        }

    }
}
