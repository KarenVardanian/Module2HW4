using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
   public abstract class Plants
    {
        public string Name { set; get; }
        public int PlantingYear { set; get; }
        public Plants(string name, int plantingYear)
        {
            this.Name = name;
            this.PlantingYear = plantingYear;
        }
    }
}
