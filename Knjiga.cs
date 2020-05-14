using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Knjiga : IRentable
    {
        private readonly double BaseBookPrice = 3.99;
     
        public String Name { get; private set; }
        public Knjiga(String name) { this.Name = name; }
        public string Description { get { return this.Name; } }
        public double CalculatePrice() { return BaseBookPrice; }

    }
}

