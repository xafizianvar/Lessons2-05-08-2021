﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adadi naturali dokhil kuned!");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a != b)
            {
                a++;
                b++;
            }
            else
            {
                a = 0;
                b = 0;
            }
            Console.WriteLine(a+" "+b);
            Console.WriteLine(" ");
            
            /*--------------------------------------*/
            
            int operand1, operand2;
            Console.WriteLine("Adadhoro dokhil kuned!");
            Console.Write("A=");
            operand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("B=");
            operand2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("amalro intikhob kuned");
            char formul=Convert.ToChar(Console.ReadLine());
            switch (formul)
            {
                case '+': {Console.WriteLine(operand1+operand2); } break;
                case '-': {Console.WriteLine(operand1-operand2); } break;
                case '*': {Console.WriteLine(operand1*operand2);} break;
                case '/': {Console.WriteLine(operand1/operand2);}break;
            }

            /*------------------------------------------- */

            Console.Write("Adadro dokhil namoed! ");
            int j = Convert.ToInt32(Console.ReadLine());
            if (j >=0 && j <= 14)
            {
                Console.WriteLine("Ваша диапазон:[0-14]");
            }
            if (j >=15 && j <= 35)
            {
                Console.WriteLine("Ваша диапазон:[15-35]");
            }
            if (j >= 36 && j <= 50)
            {
                Console.WriteLine("Ваша диапазон:[36-50]");
            }
            if (j >= 50 && j <= 100)
            {
                Console.WriteLine("Ваша диапазон:[50-100]");
            }
            if(j>100)
            {
                Console.WriteLine("Этот число ненаходится на нашу диапазон!");
            }

            /*---------------------------------*/

            Console.ReadKey();

        }
    }
}
