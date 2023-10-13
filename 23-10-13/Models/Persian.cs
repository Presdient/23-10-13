using _23_10_13.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_10_13.Models
{
    internal class Persian : IPokemon
    {
        public string Name { get; }
        public string Type { get; }
        public int Health { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name} is meowing");
        }
    }
}



