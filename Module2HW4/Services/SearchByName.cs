using Module2HW4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Services
{
   public static class SearchByNameExtension
    {
        public static Plants[] SearchByNAme(this Plants[] plants,string name)
        {
            Plants[] tmpData = new Plants[plants.Length];
            int[] indexes = new int[plants.Length];
            int index = 0;
            for (int i = 0; i < plants.Length; i++)
            {
                if (plants[i].Name.Contains(name))
                {
                    indexes[index] = i;
                    tmpData[index] = plants[i];
                    index++;
                }
            }

            Array.Resize(ref tmpData, index);
            return tmpData;
        }
    }
}
