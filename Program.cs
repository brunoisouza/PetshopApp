using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetshopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcaoMenu = 0;

            while (opcaoMenu !=9)
            {
                if (opcaoMenu == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("==================================");
                    Console.WriteLine("|         PETSHOP LALADOG        |");
                    Console.WriteLine("==================================");
                    Console.ResetColor();
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("|         MENU DE OPÇÕES         |");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Selecione a opção desejada:");
                    Console.WriteLine("");
                    Console.WriteLine("1 - Calcular Medicamento");
                    Console.WriteLine("");
                    Console.WriteLine("2 - Agendar Banho");
                    Console.WriteLine("");
                    Console.WriteLine("3 - Calcular Alimentação");
                    Console.WriteLine("");
                    Console.WriteLine("==================================");
                    Console.WriteLine("9 - Sair ao Aplicativo");
                    Console.WriteLine("==================================");
                }


                if (opcaoMenu == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("==================================");
                    Console.WriteLine("|         PETSHOP LALADOG        |");
                    Console.WriteLine("==================================");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("|      CALCULAR MEDICAMENTO      |");
                    Console.WriteLine("----------------------------------");
                    Console.ResetColor();
                    Console.WriteLine("");

                    Console.Write("Informe o peso do pet: ");
                    decimal pesoPet = decimal.Parse(Console.ReadLine());

                    Console.Write("Informe a dose por quilo do medicamento: ");
                    decimal doseQuilo = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"A dose correta do medicamento é: {pesoPet * doseQuilo}");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Digite 0 para voltar ao menu ou 9 para sair");
                }

                if (opcaoMenu == 2)
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("==================================");
                    Console.WriteLine("|         PETSHOP LALADOG        |");
                    Console.WriteLine("==================================");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("         AGENDAR BANHO          |");
                    Console.WriteLine("----------------------------------");
                    Console.ResetColor();
                    Console.WriteLine("");

                    decimal vlrCuidadosExtras = 0;
                    decimal vlrBanho = 0;

                    Console.WriteLine("Informe o porte do pet: p = Pequeno, m = Médio, g = Grande ");
                    string portePet = Console.ReadLine();

                    if (portePet == "p")
                    {
                        vlrBanho = 80;
                    }
                    else if (portePet == "m")
                    {
                        vlrBanho = 100;
                    }
                    else
                    {
                        vlrBanho = 120;
                    }

                    Console.WriteLine("Adicionar cuidados extras? s = Sim, n = Não ");
                    string cuidadosExtras = Console.ReadLine();

                    if (cuidadosExtras == "s")
                    {
                        Console.WriteLine("Tirar parasitas?");
                        string tirarParasitas = Console.ReadLine();

                        if (tirarParasitas == "s")
                        {
                            vlrCuidadosExtras += 20;
                        }

                        Console.WriteLine("Aparar pelos?");
                        string apararPelos = Console.ReadLine();

                        if (apararPelos == "s")
                        {
                            vlrCuidadosExtras += 20;
                        }

                        Console.WriteLine("Shampoo premium?");
                        string shampooPremium = Console.ReadLine();

                        if (apararPelos == "s")
                        {
                            vlrCuidadosExtras += 20;
                        }
                    }

                    Console.WriteLine("----------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Valor total do banho: {vlrBanho + vlrCuidadosExtras} ");
                    Console.ResetColor();
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Digite 0 para voltar ao menu ou 9 para sair");
                }

                if (opcaoMenu == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("==================================");
                    Console.WriteLine("|         PETSHOP LALADOG        |");
                    Console.WriteLine("==================================");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("|      CALCULAR ALIMENTAÇÃO      |");
                    Console.WriteLine("----------------------------------");
                    Console.ResetColor();
                    Console.WriteLine("");

                    Console.WriteLine("Informe a quantidade de pet:");
                    int quantidadePet = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade de ração disponível em quilo:");
                    double qtdRacaoDisponivel = double.Parse(Console.ReadLine());

                    Console.WriteLine("Deseja calcular para quantos dias?");
                    int Dias = int.Parse(Console.ReadLine());

                    double qtdNecessaria = (quantidadePet * 0.1) * Dias;

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"Quantidade necessária: {qtdNecessaria} quilos");
                    Console.WriteLine($"Quantidade disponível: {qtdRacaoDisponivel} quilos");
                    Console.WriteLine("----------------------------------");

                    if (qtdNecessaria > qtdRacaoDisponivel)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Será necessário comprar mais ração.");
                        Console.ResetColor();
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Digite 0 para voltar ao menu ou 9 para sair");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"A Quantidade de ração disponível é suficiente para os {Dias} dias.");
                        Console.ResetColor();
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Digite 0 para voltar ao menu ou 9 para sair");
                    }
                }

                bool deuCerto = int.TryParse(Console.ReadLine(), out opcaoMenu);

                if (!deuCerto || (opcaoMenu !=  0 && opcaoMenu != 1 && opcaoMenu != 2 && opcaoMenu != 3 && opcaoMenu != 9))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("                                  ");
                    Console.WriteLine("Opção Inválida!                   ");
                    Console.WriteLine("Por favor verifique!              ");
                    Console.WriteLine("                                  ");
                    Console.WriteLine("----------------------------------");
                    Console.ResetColor();

                    Thread.Sleep(3000);

                    opcaoMenu = 0;
                }

                Console.Clear();
            }
        }
    }
}
