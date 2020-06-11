using System;
using System.Data;

namespace PROJETO_BACK_SEGUNDA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] horas = null;

            while (horas == null)
            {
                Console.Write("Digite a hora");

                string retornoUsuario = Console.ReadLine();

                for (int i = 0; i < retornoUsuario.Length; i++)
                {
                    char vericarValor = (char)retornoUsuario[1];

                    if (char.IsDigit(vericarValor))
                    {
                        int validaHora = int.Parse(char.ConvertFromUtf32(vericarValor));

                        if (horas == null)
                        {
                            if (validaHora == 0 || validaHora == 1 || validaHora == 2)
                            {
                                horas = new int[2];

                                horas[0] = validaHora;
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido");
                                horas = null;
                                break;
                            }
                        }
                        else
                        {
                            horas[1] = validaHora;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Formato Inválido");
                        horas = null;
                        break;
                    }
                }
                if (horas != null)
                {
                    int horario = Convert.ToInt32(string.Format("{0}{1}", horas[0], horas[1]));

                    if (horario <= 12)
                    {
                        Console.WriteLine("Bom dia!");
                    }
                    else if (horario <= 18)
                    {
                        Console.WriteLine("Boa tarde!");
                    }
                    else
                    {
                        Console.WriteLine("Boa noite!");
                    }
                }

                Console.ReadLine();
            }

        }
    }
}

