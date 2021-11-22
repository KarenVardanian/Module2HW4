using Module2HW4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Services
{
    class PlantAmountService:ICountAmount
    {
        Service sr = new Service();
        Plants[] pl;
       
        public int PlantCount()
        {
            pl = sr.GetAll();
            int i = 0;
            foreach (var item in pl)
            {
                i++;
            }
            return i;
        }
        
    }
}
