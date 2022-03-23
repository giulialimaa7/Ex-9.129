using System;
using System.Collections.Generic;
using Exemplo_9._129.Entidades.Enums;
using Exemplo_9._129.Entidades;

namespace Exemplo_9._129
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o departamento: ");
            string departNome = Console.ReadLine();
            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nível: ");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
            Console.Write("Salário base: ");
            double salárioBase = double.Parse(Console.ReadLine());
            Console.Write("Quantos contratos para este trabalhador? ");
            int c = int.Parse(Console.ReadLine());

            Departamento depart = new Departamento(departNome);
            Trabalhador trabalhador = new Trabalhador(nome, nivel, salárioBase, depart);

            for (int i=0; i < c; i++)
            {
                Console.WriteLine($"Entre com {i} data contrato: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração (hora): ");
                int hora = int.Parse(Console.ReadLine());

                HoraContrato contrato = new HoraContrato(data, valorPorHora, hora);
                trabalhador.AddContrato(contrato);
            }
            Console.Write("Entre com o mês e o ano para calcular a renda: ");
            string meseAno = Console.ReadLine();
            int mes = int.Parse(meseAno.Substring(0, 2));
            int ano = int.Parse(meseAno.Substring(3));
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Departamento: " + departNome);
            Console.WriteLine("Renda para" + meseAno + ": " + trabalhador.Renda(mes,ano).ToString("f2"));
            
        }
    }
}
