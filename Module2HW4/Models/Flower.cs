using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
   public class Flower:Annual
    {
        public Color color { set; get; }
        public Flower(string name,double height, Color colors, int plantingYear)
            : base(name, height, plantingYear)
        {
            color = colors;
        }
    }
}
