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
            
            Piramide piramide = new Piramide();
            Console.Write("\n altura da sua pirâmide: ");
            int m_altura;
            while (!int.TryParse(Console.ReadLine(), out m_altura))
            {
                Console.WriteLine("\t\tInsira apenas números inteiros");
                Console.Write("\n altura da sua pirâmide: ");
            }
            piramide.Nivelesp = m_altura; ;
            piramide.Desenha();
            Console.ReadLine();
        }
    }
}
