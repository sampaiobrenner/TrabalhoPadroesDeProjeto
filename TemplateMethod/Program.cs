﻿using System;
using System.Collections.Generic;
using TemplateMethod.imposto;
using TemplateMethod.Relatorio;

namespace TemplateMethod
{
    internal class Program
    {
        private static void Imposto()
        {
            var orcamento = new Orcamento(0);
            orcamento.AdicionaItem(new Item("Caneta", 20));
            orcamento.AdicionaItem(new Item("Lapis", 20));
            orcamento.AdicionaItem(new Item("Boracha", 20));
            orcamento.AdicionaItem(new Item("Liquid Paper", 20));
            orcamento.AdicionaItem(new Item("Xbox", 420));

            Imposto ICPP = new ICPP();
            Imposto IKCV = new IKCV();
            Imposto IHIT = new IHIT();

            var calculador = new CalculadorDeImposto();

            calculador.RealizaCalculo(orcamento, IHIT);

            orcamento.AdicionaItem(new Item("Caneta", 20));
            calculador.RealizaCalculo(orcamento, IHIT);

            Console.ReadKey();
        }

        private static void Main(string[] args)
        {
            // Imposto();

            IList<Conta> contas = new List<Conta>();

            var conta1 = new Conta("Rodrigo", 1234, 789456123, 500);
            var conta2 = new Conta("Claudio", 1234, 456237894, 1500);
            var conta3 = new Conta("Lucia", 3544, 785463214, 700);

            contas.Add(conta1);
            contas.Add(conta2);
            contas.Add(conta3);

            TemplateRelatorio relatorio1 = new RelatorioSimples();
            TemplateRelatorio relatorio2 = new RelatorioComplexo();

            relatorio1.Imprime(contas);
            Console.WriteLine("---------------------------------------------");
            relatorio2.Imprime(contas);
            Console.ReadKey();
        }
    }
}