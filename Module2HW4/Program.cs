using Module2HW4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module2HW4
{
   public class Program
    {
        static void Main(string[] args)
        {

            //var s = new Service();
            //var pla = new PlantAmountService();
            //pla.PlantCount();
            //s.Show();

            //Console.WriteLine("--------");
            //s.Show();
            //Console.WriteLine("----EXT----");
            var start = new Starter();
            start.Start();
            
        }
    }
}
