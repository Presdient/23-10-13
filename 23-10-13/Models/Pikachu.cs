using _23_10_13.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_10_13.Models
{
    internal class Pikachu : IPokemon, IAttack, ITrain
    {
        //1. Kontraktet för IPokemon
        public string Name { get; }
        public string Type { get; }
        public int Health { get; set; } = 100;


        public Pikachu(string name) 
        { 
             Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"{Name} is of type {Type}");
        }
        //----------------------------------------------------

        //2: Kontraktet för IAttack
        public void Attack(IPokemon target)
        {
            Console.WriteLine($"{Name} is attacking {target.Name}");
        }
        //-------------------------------------------------------

        //3. Kontraktet för ITrain
        public void Train()
        {
            Console.WriteLine($"{Name} is training hard!");
        }
        //-------------------------------------------------------
    }
}
