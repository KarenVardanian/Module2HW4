using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models
{
   public class Grass:Annual
    {
        public bool IsShadowLike { get; set; }
        public Grass(string name,double height,bool isShadowLiked, int plantingYear)
            : base(name, height, plantingYear)
        {
            IsShadowLike = isShadowLiked;
        }
    }
}
