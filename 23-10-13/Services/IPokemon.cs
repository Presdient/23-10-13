using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_10_13.Services
{
    internal interface IPokemon
    {
        string Name { get; }
        int Health { get; set; }
        string Type { get; }
        void Display();
    }
}

    


