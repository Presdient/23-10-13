using _23_10_13.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_10_13.Models
{
    internal class Dragonite : IAttack, ITrain, IPokemon
    {
        public string Name { get; }

        public string Type { get; }

        public int Health { get; set; }

        public Dragonite(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"{Name} is of {Type}");
        }

        //----------------------------------------------
        public void Attack(IPokemon target)
        {
            Console.WriteLine($"{Name} is attacking {target.Name}");
        }

        //----------------------------------------------

        public void Train()
        {
            Console.WriteLine($"{Name} is training very hard! ");
        }

        //----------------------------------------------
    }
}




