using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Desenvolvedor : Funcionario
    {
        public override double CalcularBonusAnual()
        {
            return Salario * 0.12;
        }
    }
}
