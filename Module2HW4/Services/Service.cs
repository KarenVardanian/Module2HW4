using Module2HW4.Models;
using Module2HW4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4
{
   public class Service
    {
        private readonly Plants[] _data;
        public Service()
        {
            _data = new Plants[] {
            new Tree("Apple",2012,50,145,true),
            new Flower("Astra",0.90,Color.green,2019),
            new AteTree("Fear",150,"green",true,2010)
            };

        }

       public Plants[] GetAll()
        {
            return _data;
        }
       
        
        public void Show()
        {
            foreach (var item in _data)
            {
                Console.WriteLine(item.Name);
            }
        }
       
    }
}
