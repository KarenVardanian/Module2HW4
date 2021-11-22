using Module2HW4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Services
{
   public class SortService : IComparer<Plants>
    {

        public int Compare(Plants x, Plants y)
        {
            if (x.PlantingYear > y.PlantingYear)
                return 1;
            else if (x.PlantingYear < y.PlantingYear)
                return -1;
            else
                return 0;
        }
        public Plants[] Sort()
        {
            Service sr = new Service();
            Plants[] pl = sr.GetAll();
            Array.Sort(sr.GetAll(), new SortService());
            
            return sr.GetAll();
        }
    }
}
