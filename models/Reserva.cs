using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.models
{
    public class Reserva
    {
            public class Cadastrarhospede
        {
        static List<Pessoa> Hospedes = new();
        // List<Pessoa> é uma coleção de objetos que podem ser acessados por índice. List é uma classe genérica que é uma coleção de elementos fortemente tipados.
        static List<Suite> Suites = new();
        // List<Suite> é uma coleção de objetos que podem ser acessados por índice. List é uma classe genérica que é uma coleção de elementos fortemente tipados.

        public static void CadastrarHospede()
        {
            Console.WriteLine("Digite o nome do hóspede:");
            string? nome = Console.ReadLine();
            // .? é um operador de condicional nula que retorna o operando direito se o operando esquerdo for nulo; caso contrário, ele retorna o operando esquerdo.
            Console.WriteLine("Digite o ID do hóspede:");
            int id = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
            // int.Parse converte a representação de cadeia de caracteres de um número para o seu equivalente inteiro.
            // throw new ArgumentNullException é uma exceção que é acionada quando um argumento nulo é passado para um método que não aceita argumentos nulos.
            Pessoa hospede = new(nome ?? throw new ArgumentNullException(nameof(nome)), id)
            // .?? throw new ArgumentNullException é uma exceção que é acionada quando um argumento nulo é passado para um método que não aceita argumentos nulos.
            // nameof(nome) retorna o nome de uma variável, tipo ou membro como uma cadeia de caracteres.
    
            {
                Nome = nome,
                Id = id
            };
            Hospedes.Add(hospede);
            // Add adiciona um objeto ao final da coleção List.
        }

        public static void CadastrarSuite()
        {
            Console.WriteLine("Digite o tipo da suíte:");
            string tipoSuite = Console.ReadLine() ?? string.Empty;
            // ?? string.Empty é um operador de coalescência nula que retorna o operando esquerdo se o operando não for nulo; caso contrário, ele retorna o operando direito.
            Console.WriteLine("Digite a capacidade da suíte:");
            int capacidade = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
            // int.TryParse tenta converter a representação de cadeia de caracteres de um número para o seu equivalente inteiro. Um valor retornado indica se a operação foi bem-sucedida.
            Console.WriteLine("Digite o valor da diária da suíte:");
            Decimal valorDiaria = Decimal.Parse(Console.ReadLine() ?? "0");
            // Decimal.Parse converte a representação de cadeia de caracteres de um número para o seu equivalente decimal.
            Suite suite = new()
            {
                TipoSuite = tipoSuite,
                Capacidade = capacidade,
                ValorDiaria = valorDiaria
            };
            Suites.Add(suite);
        }

        public static void ObterQuantidadeHospedes()
        {
            Console.WriteLine("Quantidade de hóspedes: " + Hospedes.Count);
        }

            public static void CalcularValorDiaria()
        {
            Decimal valorDiaria = 0;
            foreach (var suite in Suites)
            {
                valorDiaria += suite.ValorDiaria;
                // += é um operador de atribuição composta que adiciona o valor do operando direito ao valor da variável e armazena o resultado na variável esquerda.
            }
            Console.WriteLine("Valor total da diária: " + valorDiaria);
        }
    }
}
}