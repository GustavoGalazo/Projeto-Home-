using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            String sobrenome;
            String telefone;
            Console.WriteLine("Olá, escreva seu nome.");
            nome = Console.ReadLine();
            Console.WriteLine("Agora seu sobrenome.");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Escreva seu numero de telefone");
            telefone = Console.ReadLine();
            Console.WriteLine( nome+ "" +sobrenome);
            Console.WriteLine(telefone);
            Console.ReadKey();
        }
    }
}
