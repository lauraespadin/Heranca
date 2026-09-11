using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Gato : Animal
    {
        public Gato(string nome) : base(nome)
        {
        }

        public void Miar()
        {
            Console.WriteLine("MIAU MIAU!");
        }
    }
}
