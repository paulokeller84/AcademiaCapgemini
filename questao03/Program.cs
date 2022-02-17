using System;
using System.Collections.Generic;

namespace questao03
{
    class Program
    {
        public static void Main(string[] args)
        {
            //informações para o usuário
            Console.WriteLine("Digite a string");

            //entrada de dados
            Console.WriteLine(Anagrama(Console.ReadLine()));


            //método
            int Anagrama(string entradaDados)
            {
                string[] palavra = new string[2];
                char letra;
                int contagem = 0;

                for (int cont = 0; cont < entradaDados.Length; cont++)
                {
                    for (int cont2 = 1; cont2 < entradaDados.Length; cont2++)
                    {
                        if (cont2 > cont)
                        {
                            for (int cont3 = 1; cont3 < entradaDados.Substring(cont2 - 1).Length; cont3++)
                            {
                                palavra[0] = entradaDados.Substring(cont, cont3);
                                palavra[1] = entradaDados.Substring(cont2, cont3);

                                char[] caracter = palavra[0].ToCharArray();
                                char[] caracter2 = palavra[1].ToCharArray();

                                for (int c = 1; c < caracter.Length; c++)
                                {
                                    for (int c2 = 0; c2 < caracter.Length - 1; c2++)
                                    {
                                        if (caracter[c2] > caracter[c2 + 1])
                                        {
                                            letra = caracter[c2];
                                            caracter[c2] = caracter[c2 + 1];
                                            caracter[c2 + 1] = letra;
                                        }
                                    }
                                }

                                for (int c = 1; c < caracter2.Length; c++)
                                {
                                    for (int c2 = 0; c2 < caracter2.Length - 1; c2++)
                                    {
                                        if (caracter2[c2] > caracter2[c2 + 1])
                                        {
                                            letra = caracter2[c2];
                                            caracter2[c2] = caracter2[c2 + 1];
                                            caracter2[c2 + 1] = letra;
                                        }
                                    }
                                }

                                bool igual = true;

                                for (int c = 0; c < caracter.Length; c++)
                                {
                                    if (caracter[c] != caracter2[c])
                                    {
                                        igual = false;
                                    }
                                }

                                if (igual)
                                {
                                    contagem++;
                                }
                            }
                        }
                    }
                }

                return contagem;
            }

            
        }
    }
}
