using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
   public class Tree:FallingLeafs
    {
        public bool IsFruit { set; get; }
        public Tree(string name, int plantingYear ,int age, int Amount,bool isFruit) 
        :base(name, age, Amount, plantingYear)
        { 
            IsFruit = isFruit;
        }
    }
}
