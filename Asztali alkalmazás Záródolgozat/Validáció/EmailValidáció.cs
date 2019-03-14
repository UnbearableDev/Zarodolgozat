using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
    class EmailValidáció
    {
        private string email;
        public EmailValidáció(string email)
        {
            this.email = email;
        }
        public void validáció()
        {
            if (üresEmail())
            {

            }
            if(nincsKukacAzEmailban())
            {

            }
            

        }

        private bool nincsKukacAzEmailban()
        {
            throw new NotImplementedException();
        }

        private bool üresEmail()
        {
            throw new NotImplementedException();
        }
    }
}
