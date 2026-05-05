using System;

using System;
using System.Collections.Generic;
class Program
{
    static List<veiculo> veiculos = new List<Veiculo>();
    static void Main(string[] args)
    {
        int opcao;
        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Registar Veículo");
            Console.WriteLine("2 - Actualizar Quilometragem");
            Console.WriteLine("3 - Listar Veículos");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    RegistarVeiculo();
                    break;
                case 2:
                    ActualizarKm();
                    break;
                case 3:
                    ListarVeiculos();
                    break;
                case 0:
                    Console.WriteLine("Encerrando sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 0);
    }
    static void RegistarVeiculo()
    {
        Console.Write("Matrícula: ");
        string matricula = Console.ReadLine();
        Console.Write("Marca: ");
        string marca = Console.ReadLine();
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();
        Console.Write("Ano: ");
        int ano = int.Parse(Console.ReadLine());
        Console.Write("Quilometragem: ");
        double km = double.Parse(Console.ReadLine());
        Veiculo v = new Veiculo(matricula, marca, modelo, ano, km); veiculos.Add(v);
        Console.WriteLine("Veículo registado com sucesso!");
    }
    static void ActualizarKm()
    {
        Console.Write("Digite a matrícula: ");
        string mat = Console.ReadLine();
        foreach (Veiculo v in veiculos)
        {
            if (v.Matricula == mat)
            {
                Console.Write("Km a adicionar: ");
                double km = double.Parse(Console.ReadLine());
                v.ActualizarQuilometragem(km);
                Console.WriteLine("Quilometragem atualizada!");
                return;
            }
        }
        Console.WriteLine("Veículo não encontrado!");
    }
    static void ListarVeiculos()
    {
        if (veiculos.Count == 0)
        {
            Console.WriteLine("Nenhum veículo registado.");
            return;
        }
        foreach (Veiculo v in veiculos)
        {
            v.ApresentarDados();
        }
    }
}

