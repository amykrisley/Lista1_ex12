﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;
            double v3;
            double v4;
            double v5;
            double vp;
            double vt;

            Console.Write("informe o valor do 1º produto: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("informe o valor do 2º produto: ");
            v2 = double.Parse(Console.ReadLine());

            Console.Write("informe o valor do 3º produto: ");
            v3 = double.Parse(Console.ReadLine());

            Console.Write("informe o valor do 4º produto: ");
            v4 = double.Parse(Console.ReadLine());

            Console.Write("informe o valor do 5º produto: ");
            v5 = double.Parse(Console.ReadLine());

            Console.Write("informe o valor do pagamento: ");
            vp = double.Parse(Console.ReadLine());

            vt = vp - (v1 + v2 + v3 + v4 + v5) ;

            Console.WriteLine("O valor do troco é: {0}R$", vt);

        }
    }
}
