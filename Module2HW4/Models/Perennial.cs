using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
   public abstract class Perennial:Plants
    {
        public int AgeOfVegetation { set; get; }
        public Perennial(string name,int age, int plantingYear)
        :base(name,plantingYear)
        {
            this.AgeOfVegetation = age;
        }
    }
}
