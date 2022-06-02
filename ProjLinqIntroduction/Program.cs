using System;
using System.Linq;

namespace ProjLinqIntroduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("****Exemplo Lista Full****");

            foreach (var p in pessoa.Pessoas())
            {
                 Console.WriteLine(p);
            }

            Console.WriteLine("****Exemplo Lista Linq****");

            var pessoas =
                from p in pessoa.Pessoas()
                where p.Age < 18
                select p;

            foreach (var item in pessoas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****Exemplo Lista Lambda****");

            pessoa.Pessoas().Where(p => p.Age < 18).ToList().ForEach(p => Console.WriteLine(p));

        }
    }
}
