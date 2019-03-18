using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asztali_alkalmazás_Záródolgozat.Kivétel.EmailKivétel;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
   public class EmailValidáció
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
                throw new üresEmailKivétel("Az email nem lehet üres");
            }
            if(nincsKukacAzEmailban())
            {
                throw new nincsKukacAzEmailbanKivétel("Az emailben kötelező a kukac használata");
            }
            

        }

        private bool nincsKukacAzEmailban()
        {
           if(email.Contains("@") == true)
            {
                return false;
            }
           else
            {
                return true;

            }
        }

        private bool üresEmail()
        {
            if (string.IsNullOrEmpty(email) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
