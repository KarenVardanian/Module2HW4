using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
   public class AteTree: EverGreen
    {
        public bool IsBumps { set; get; }
        public AteTree(string name, int age,string color,bool isBumps,int plantingYear)
            :base(name,age,color, plantingYear)
        {
            IsBumps = isBumps;
        }
    }
}
