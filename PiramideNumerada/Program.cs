using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramideNumerada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Piramide pir = new Piramide();
            Console.Write("\n altura da sua pirâmide: ");
            pir.Nivelesp = Convert.ToInt32(Console.ReadLine());
            pir.Desenha();
            Console.ReadLine();
        }
    }
}
