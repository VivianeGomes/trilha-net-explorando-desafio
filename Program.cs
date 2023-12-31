using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Variáveis auxiliares para armazenar os dados da reserva
            int diasReservados = 0;
            string tipoSuite = "";
            int capacidade = 0;
            decimal valorDiaria = 0;
            List<Pessoa> hospedes = new List<Pessoa>();
            int quantidadeHospedes = 0;
            string nomeHospede = "";

            // Pede ao usuário os dados da reserva
            Console.WriteLine("Bem-vindo ao sistema de hospedagem!");
            Console.WriteLine("Por favor, digite os dados da reserva.");

            // Laço while para repetir o bloco try-catch até que não ocorra mais exceções
            while (true)
            {
                try
                {
                    // Pede ao usuário o número de dias reservados
                    Console.Write("Digite o número de dias reservados: ");
                    diasReservados = int.Parse(Console.ReadLine());

                    // Pede ao usuário o tipo da suíte
                    Console.Write("Digite o tipo da suíte (Standard, Premium ou Luxo): ");
                    tipoSuite = Console.ReadLine();

                    // Pede ao usuário a capacidade da suíte
                    Console.Write("Digite a capacidade da suíte: ");
                    capacidade = int.Parse(Console.ReadLine());

                    // Pede ao usuário o valor da diária da suíte
                    Console.Write("Digite o valor da diária da suíte: ");
                    valorDiaria = decimal.Parse(Console.ReadLine());

                    // Pede ao usuário a quantidade de hóspedes
                    Console.Write("Digite a quantidade de hóspedes: ");
                    quantidadeHospedes = int.Parse(Console.ReadLine());

                    // Pede ao usuário o nome de cada hóspede e adiciona à lista de hóspedes
                    for (int i = 1; i <= quantidadeHospedes; i++)
                    {
                        Console.Write($"Digite o nome do hóspede {i}: ");
                        nomeHospede = Console.ReadLine();
                        Pessoa p = new Pessoa(nome: nomeHospede);
                        hospedes.Add(p);
                    }

                    // Cria uma nova reserva
                    Reserva reserva = new Reserva(diasReservados);

                    // Cria a suíte com os dados informados pelo usuário
                    Suite suite = new Suite(tipoSuite: tipoSuite, capacidade: capacidade, valorDiaria: valorDiaria);

                    // Cadastra a suíte e os hóspedes na reserva
                    reserva.CadastrarSuite(suite);
                    reserva.CadastrarHospedes(hospedes);

                    // Exibe a quantidade de hóspedes e o valor da diária
                    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
                    Console.WriteLine($"Valor total: {reserva.CalcularValorDiaria()}");

                    // Se não houver exceção, sai do laço
                    break;

                }

                catch (Exception e)
                {
                    // Mostra a mensagem de erro ao usuário
                    Console.WriteLine("Ocorreu um erro na reserva: " + e);

                    // Pede ao usuário que digite novamente os dados da reserva
                    Console.WriteLine("Por favor, digite novamente os dados da reserva.");
                }
            }

            
        }
    }
}
