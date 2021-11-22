using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
   public class Juniper:EverGreen
    {
        public bool IsCreeping { set; get; }
        public Juniper(string name, int age, string color, bool isCreeping, int plantingYear)
            : base(name, age, color, plantingYear)
        {
            this.IsCreeping = isCreeping;
        }
    }
}
