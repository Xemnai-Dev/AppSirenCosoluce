using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSiren
{
    public class Siren
    {
        private string number { get; set; }
        private bool isValid { get; set; }
        public bool IsValid
        {
            get => isValid;
            set => isValid = value;
        }
        public string Number
        {
            get => number;
            set => number = value;
        }
        public Siren(string number)
        {
            this.number = number;
            this.isValid = TestSiren(number);
        }
        private bool TestSiren(string number)
        {
            if (number.Length == 9)
            {
                int pos = 9;
                int sum = 0;
                for (int i = 0; i < 9; i++)
                {
                    int value = (int)Char.GetNumericValue(number[i]);

                    if (pos % 2 == 0)
                        if ((value * 2).ToString().Length > 1)
                            sum += (int)Char.GetNumericValue((value * 2).ToString()[0]) + (int)Char.GetNumericValue((value * 2).ToString()[1]);
                        else
                            sum += value * 2;
                    else
                        sum += value;

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
