using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace calculadora_com_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o 1° número");
            int numero= int.Parse(Console.ReadLine());
            Console.WriteLine("digite o 2° número");
            int numero2= int.Parse(Console.ReadLine());
            Console.WriteLine("digite a operação desejada(+,/,*,-)");
            string ope= Console.ReadLine();
  
            int total= 0;

            switch (ope) 
            {
                case "+":
                        total = (numero + numero2);
                        break;
                case "-":
                    total = (numero - numero2);
                    break;
                case "*":
                    total = (numero * numero2);
                    break;
                case "/":
                    total = (numero / numero2);
                    break;
                    
            }

            Console.WriteLine("o total da operação foi de:"+ total);
            Console.ReadKey();
        }
    }
}
