using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }

        public void comer()
        {
            Console.WriteLine($"{Nome} está comendo.");
        }
    }
}
