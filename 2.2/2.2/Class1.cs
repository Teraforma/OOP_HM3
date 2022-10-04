using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Converter

    {
        decimal dolHryv = 0;
        decimal euroHryv = 0;
        public Converter(decimal dol, decimal euro)
        {
            if (dol < 0 ){ dolHryv=0;}else { dolHryv=dol; }

            if (euro < 0){ euroHryv=0;}else { euroHryv=euro;}
            
        }
        public decimal ToHryvnya(decimal value, string cur)
        {   
            cur = cur.ToLower();
            if (cur == "dol")  { return DolToHryv(value);}

            if (cur == "euro") { return EuroToHryv(value); }

            throw new ArgumentException(String.Format("'{0}' no such currency accepted",cur));
            
          
        }

        public decimal FromHryvnya(decimal value, string cur)
        {
            cur = cur.ToLower();
            if (cur == "dol") { return DolToHryv(value, true); }

            if (cur == "euro") { return EuroToHryv(value, true); }

            throw new ArgumentException(String.Format("'{0}' no such currency accepted", cur));
        }


            private decimal DolToHryv(decimal value, bool isReverse = false)
        {
            if (dolHryv == 0)
            {
                Console.WriteLine("NOT POSSIBLE TO CONVERT");
                return 0;
            }
            if (isReverse)
            {
                return value * (1 / dolHryv);
            }
            else
            {
                return (value * dolHryv);
            }
        }
        private decimal EuroToHryv(decimal value, bool isReverse = false)
        {   
            if (euroHryv == 0)
            {
                Console.WriteLine("NOT POSSIBLE TO CONVERT");
                return 0;
            }
            if (isReverse)
            {
                return value * (1 / euroHryv);
            }
            else
            {
                return (value * euroHryv);
            }
        }
        
    }
}
