using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Circulo : FormaGeometrica
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
