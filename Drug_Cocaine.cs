using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugWarz
{
   public class Drug_Cocaine : Form1
    {
        public string Cocaine;
        public int MaxRate = 30;
        public int CoatSize = 10;
        
        public int DrugRate(int drugPrice)
        {
            Random randDrugPrice = new Random();
            drugPrice = randDrugPrice.Next(MaxRate);
            return drugPrice;

           
        }
    }
}
