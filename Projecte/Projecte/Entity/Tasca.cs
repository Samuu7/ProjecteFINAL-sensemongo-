using System;
using System.Collections.Generic;
using System.Text;

namespace Projecte.Entity
{
   public class Tasca
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public string ResponsableTasca { get; set; }
        public string Descripcio { get; set; }
        public DateTime Data { get; set; }
        public DateTime Data1 { get; set; }

        public string Estat { get; set; }
    }
}
