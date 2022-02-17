using System;

namespace DiamanteDeCaracter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linha = 0, coluna = 0;
            int metadeesquerda, metadedireita;
            int numero;
            int tamanho;
            char letra;
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetochar = alfabeto.ToCharArray();

            Console.WriteLine("Digite sua letra");
            letra = Convert.ToChar(Console.ReadLine().ToUpper());
            
            tamanho = alfabeto.IndexOf(letra) * 2 + 1;
            metadedireita = alfabeto.IndexOf(letra) + 1;
            metadeesquerda = alfabeto.IndexOf(letra) + 1;
            numero = alfabeto.IndexOf(letra);


            #region parte de cima
            while (true)
            {
                if (coluna == metadeesquerda || coluna == metadedireita)
                {
                    Console.Write(alfabetochar[linha]);

                }
                else
                {
                    Console.Write(" ");
                }
                if(coluna == tamanho)
                {
                    Console.WriteLine();
                    coluna = 0;

                    
                    if (linha == numero )
                    {
                        break;
                    }
                    metadedireita++;
                    metadeesquerda --;
                    linha++;

                    continue;
                }

                coluna++;
                
            }
            #endregion
            #region parte de baixo 
            linha--;
            metadedireita--;
            metadeesquerda++;
            while (true)
            {
                if (coluna == metadeesquerda || coluna == metadedireita)
                {
                    Console.Write(alfabetochar[linha]);

                }
                else
                {
                    Console.Write(" ");
                }
                if (coluna == tamanho)
                {
                    Console.WriteLine();
                    coluna = 0;

                    if (linha == 0)
                    {
                        break;
                    }
                    metadedireita--;
                    metadeesquerda++;
                    linha--;

                    continue;
                }

                coluna++;



            }
            #endregion
        }

    }
    }

