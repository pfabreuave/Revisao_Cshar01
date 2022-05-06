using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("\n Vamos calcular a distância euclidiana\n");
            Console.Write("\n      precisamos das coordenadas\n");

            Vertice vert01 = new Vertice();
            Console.Write("\n x1\n");
            vert01.X = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n y1\n");
            vert01.Y = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n x2\n");
            vert01.X1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n y2\n");
            vert01.Y1 = Convert.ToDouble(Console.ReadLine());

            vert01.Distancia();
            Console.Write("\n     podemos mover qualquer vértice");
            Console.Write("\n  vamos precisar das novas coordenadas\n");
            vert01.Move();

            Console.Write("\n\n    Vamos comparar vértices");
            Console.Write("\n   precisamos das coordenadas\n");

            Console.Write("\n x1\n");
            vert01.X = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n y1\n");
            vert01.Y = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n x2\n");
            vert01.X1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n y2\n");
            vert01.Y1 = Convert.ToDouble(Console.ReadLine());
            vert01.Compara();

            Console.Write("\n\n  deseja algo mais!");
            Console.ReadLine();

        }
    }
}
