using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public abstract class FallingLeafs :Perennial
    {
        public int AnountOfVegetationDays { set; get; }
        public FallingLeafs(string name, int age, int Amount, int plantingYear)
            :base(name,age, plantingYear)
        {
            this.AnountOfVegetationDays = Amount;
        }
    }
}
