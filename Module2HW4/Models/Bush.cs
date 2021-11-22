using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
   public class Bush:FallingLeafs
    {
        public double Height { set; get; }
        public double Width { set; get; }
        public Bush(string name, int age, int Amount,double height,double width,int plantingYear)
            :base(name, age, Amount, plantingYear)
        {
            this.Height = height;
            this.Width = width;
        }
    }
}
