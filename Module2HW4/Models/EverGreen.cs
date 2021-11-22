using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public abstract class EverGreen : Perennial
    {
       public string ColorOfLeafs { set; get; }
        public EverGreen(string name, int age,string color,int plantingYear)
            :base(name, age,plantingYear)
        {
            this.ColorOfLeafs = color;
        }
    }
}
