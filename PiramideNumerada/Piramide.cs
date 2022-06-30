using System;

namespace PiramideNumerada
{
    internal class Piramide
    {

			public Piramide()
			{
				this.Nivelesp = 1;

			}

			public int nvPar;

        public int Nivelesp
			{
				get { return nvPar; }
				set
				{
					if (value >= 1) nvPar = value;
					else
					{
                    throw new Exception("\n A altura da pirâmide deve ser > a 0 !!!! ");
					}
				}
			}

			public void Desenha()
			{

				int digito;
				int y;
				int x;


				/*
					--------------Piramide solicitada-------------
					sequência ascendente da esquerda para a direita
					sequência ascendente da direita  para a esquerda
				*/
				for (x = 1; x <= Nivelesp; x++)
				{
					for (y = 1; y <= Nivelesp - x; y++)
					{
						Console.Write(" ");
					}

					for (y = 1; y <= x; y++)
					{
						digito = y % 10;
						Console.Write(digito);
					}
					int j = y - 1;
					for (y = 1; y <= x - 1; y++)
					{
						j--;
						digito = j % 10;
						Console.Write(digito);
					}

					Console.WriteLine();
				}
				/*
					---------Piramide solicitada invertida--------
					sequência ascendente da esquerda para a direita
					sequência ascendente da direita  para a esquerda
				*/

				Console.WriteLine();

				for (x = Nivelesp; x >= 0; x--)
				{
					for (y = 1; y <= Nivelesp - x; y++)
					{
						Console.Write(" ");
					}

					for (y = 1; y <= x; y++)
					{
						digito = y % 10;
						Console.Write(digito);
					}
					int j = y - 1;
					for (y = 1; y <= x - 1; y++)
					{
						j--;
						digito = j % 10;
						Console.Write(digito);
					}

					Console.WriteLine();
				}

			/*
					---Piramide secuencia ilimitada----
					sequência ascendente de lado a lado
			*/

			Console.WriteLine();

			for (x = 1; x <= Nivelesp; x++)
			{
				for (y = 1; y <= Nivelesp - x; y++)
				{
					Console.Write(" ");
				}

				for (y = 1; y <= x; y++)
				{
					digito = y % 10;
					Console.Write(digito);
				}

				int j = y - 1;
				for (y = 1; y <= x - 1; y++)
				{
					j++;
					digito = j % 10;
					Console.Write(digito);
				}

				Console.WriteLine();
			}

			/*
					---Piramide secuencia ilimitada invertida----
						sequência ascendente de lado a lado
			*/
			Console.WriteLine();
			for (x = Nivelesp; x >= 0; x--)
			{
				for (y = 1; y <= Nivelesp - x; y++)
				{
					Console.Write(" ");
				}

				for (y = 1; y <= x; y++)
				{
					digito = y % 10;
					Console.Write(digito);
				}

				int j = y - 1;
				for (y = 1; y <= x - 1; y++)
				{
					j++;
					digito = j % 10;
					Console.Write(digito);
				}

				Console.WriteLine();
			}

			/*
					--------------Piramide solicitada-------------
					secuencia ascendente hasta el cateto adyacente
					secuencia ascendente desde el cateto adyacente
			*/

			Console.WriteLine();

			for (x = 1; x <= Nivelesp; x++)
			{
				for (y = 1; y <= Nivelesp - x; y++)
				{
					Console.Write(" ");
				}

				for (y = 1; y <= x; y++)
				{
					digito = y % 10;
					Console.Write(digito);
				}

				for (y = 1; y <= x - 1; y++)
				{
					digito = y % 10;
					Console.Write(digito);
				}

				Console.WriteLine();

			}


			/*
					--------------Piramide Invertida-------------
					secuencia ascendente hasta el cateto adyacente
					secuencia ascendente desde el cateto adyacente
			*/

			Console.WriteLine();

			for (x = Nivelesp; x >= 0; x--)
			{
				for (y = 1; y <= Nivelesp - x; y++)
				{
					Console.Write(" ");
				}

				for (y = 1; y <= x; y++)
				{
					digito = y % 10;
					Console.Write(digito);
				}

				for (y = 1; y <= x - 1; y++)
				{
					digito = y % 10;
					Console.Write(digito);
				}

				Console.WriteLine();

			}



		}


	}

}

