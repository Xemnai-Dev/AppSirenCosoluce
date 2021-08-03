using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSiren
{
    public class Siret
    {
        private Siren siren { get; set; }
        private string nic { get; set; }

        private bool isValid { get; set; }
        public bool IsValid
        {
            get => isValid;
            set => isValid = value;
        }
        public Siret(string siren, string nic)
        {
            this.siren = new Siren(siren);
            this.nic = nic;
            this.isValid = this.siren.IsValid ? TestSiret(siren + nic) : false;
        }
        public Siret(Siren siren, string nic)
        {
            this.siren = siren;
            this.nic = nic;
            this.isValid = this.siren.IsValid ? TestSiret(siren + nic) : false;
            this.isValid = TestSiret(siren.Number + nic);
        }
        public Siret(string sirenAndNic)
        {
            
            siren = new Siren(sirenAndNic.Substring(0, 9));
            nic = sirenAndNic.Substring(9);
            this.isValid = TestSiret(siren.Number + nic);
        }

        private bool TestSiret(string sirenAndNic)
        {
     
            if (sirenAndNic.Length == 14)
            {
                int sum = 0;
                int pos = 14;
                for (int i = 0; i < 14; i++)
                {
                    int value = (int)Char.GetNumericValue(sirenAndNic[i]);
                    sum += pos % 2 == 0 ? value * 2 : value;
                    pos--;
                }

                if (sum % 10 == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
