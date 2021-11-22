using Module2HW4.Models;
using Module2HW4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
   public class Starter
    {
        public void Start()
        {
            var sr = new Service();
            var CountService = new PlantAmountService();
            var ss = new SortService();
            Plants[] plants = sr.GetAll();
            Plants[] a;
            a=plants.SearchByNAme("Apple");
            //Console.WriteLine(a[0].Name);
            plants= ss.Sort();
            int amountOfPlants = CountService.PlantCount();
           // Console.WriteLine(amountOfPlants);
        } 
    }
}
