using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertice
{
    internal class Vertice
    {
        public Vertice()
        {
            this.X = 1;
            this.Y = 1;
            this.X1 = 1;
            this.Y1 = 1;
        }
        public double _x = 0;
        public double _y = 0;
        public double _x1 = 0;
        public double _y1 = 0;

        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value > 0) _x = value;
                else
                {
                    throw new Exception("\n Coordenada deve ser > a 0 !!!! ");

                }

            }
        }
        public double X1
        {
            get
            {
                return _x1;
            }
            set
            {
                if (value >= 0) _x1 = value;
                else
                {
                    throw new Exception("\n Coordenada deve ser > a 0 !!!! ");
                }
            }
        }
        public double Y
        {
            get
            {
                return _y;
            }

            set
            {
                if (value >= 0) _y = value;
                else
                {
                    throw new Exception("\n Coordenada deve ser > a 0 !!!! ");
                }
            }
        }
        public double Y1
        {
            get
            {
                return _y1;
            }

            set
            {
                if (value >= 0) _y1 = value;
                else
                {
                    throw new Exception("\n Coordenada deve ser > a 0 !!!! ");
                }
            }
        }
        public void Distancia()
        {
            double RE = ((X - X1) * (X - X1)) + ((Y - Y1) * (Y - Y1));
            Console.Write("\n Distancia Euclidiana = " + RE + "\n");
        }
        public void Move()
        {
            Dictionary<string, double> coordenadas = new Dictionary<string, double>
            {
                { "x1", X },
                { "y1", Y },
                { "x2", X1 },
                { "y2", Y1 }
            };

            for (int i = coordenadas.Count - 1; i >= 0; i--)
            {
                Console.Write("\n Coordenada " + coordenadas.ElementAt(i) + " " + " " + coordenadas.ElementAt(i).Key + ": " + coordenadas.ElementAt(i).Value);
            }
            string cordx = " ";
            Console.Write("\n\npara modificar digite o número que acompanha o eixo :");
            cordx = Convert.ToString(Console.ReadLine());
            if (cordx != " ")
            {
                cordx = "x" + cordx;
                string cordy = cordx.Replace('x', 'y');
                Console.Write("\n novas coordenadas : ");
                Console.Write("\n" + cordx + "\n");
                X = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n" + cordy + "\n");
                Y = Convert.ToDouble(Console.ReadLine());
                coordenadas.Remove(cordx);
                coordenadas.Remove(cordy);
                coordenadas.Add(cordx, X);
                coordenadas.Add(cordy, Y);
            }
            Console.Write("\nAssim são suas coordenadas\n");
            for (int i = coordenadas.Count - 1; i >= 0; i--)
            {
                Console.Write("\n Coordenada " + coordenadas.ElementAt(i) + " " + " " + coordenadas.ElementAt(i).Key + ": " + coordenadas.ElementAt(i).Value);
            }
        }

        public void Compara()
        {
            if (X == X1 && Y == Y1)

                Console.WriteLine("vertice son iguales X = " + X + " X1 = " + X1 + " Y = " + Y + " Y1 = " + Y1);
            else
                Console.WriteLine("vertice son diferentes X = " + X + " X1 = " + X1 + " Y = " + Y + " Y1 = " + Y1);
        }
    }
}
