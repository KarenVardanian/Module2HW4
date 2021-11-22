using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
    public abstract class Annual:Plants
    {
        public double Height { set; get; }
        public Annual(string name,double height, int plantingYear)
            : base(name, plantingYear)
        {
            this.Height=height;
        }
    }
}
