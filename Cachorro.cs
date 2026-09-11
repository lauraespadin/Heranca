using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {
        }

        public void Latir()
        {
            Console.WriteLine("AU AU!");
        }
    }
}