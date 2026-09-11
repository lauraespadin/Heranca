using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Mago : Personagem
    {
        public int PontosDeMagia { get; set; }

        public Mago(string nome, int pontosDeVida, int forcaDeAtaque, int pontosDeMagia)
            : base(nome, pontosDeVida, forcaDeAtaque)
        {
            PontosDeMagia = pontosDeMagia;
        }

        public override void Atacar(Personagem alvo)
        {
            int dano = ForcaDeAtaque;

            alvo.PontosDeVida -= dano;

            if (alvo.PontosDeVida < 0)
            {
                alvo.PontosDeVida = 0;
            }

            int recuperacao = (int)(dano * 0.10);
            PontosDeMagia += recuperacao;

            Console.WriteLine($"{Nome} causou {dano} de dano em {alvo.Nome}.");
            Console.WriteLine($"PV restante de {alvo.Nome}: {alvo.PontosDeVida}");
            Console.WriteLine($"{Nome} recuperou {recuperacao} MP.");
        }
    }
}