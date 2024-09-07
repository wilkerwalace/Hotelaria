using Hotelaria.models;
using System;
using System.Collections.Generic;
using System.Linq;
using static Hotelaria.models.Reserva;


Console.WriteLine("Bem-vindo ao Hotelaria!");
Console.WriteLine("Digite 1 para cadastrar hóspede");
Console.WriteLine("Digite 2 para cadastrar suíte");
Console.WriteLine("Digite 3 para obter quantidade de hóspedes");
Console.WriteLine("Digite 4 para obter quantidade de suítes");
Console.WriteLine("Digite 5 para sair");

int opcao = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
// int.Parse converte a representação de cadeia de caracteres de um número para o seu equivalente inteiro.
// throw new ArgumentNullException é uma exceção que é acionada quando um argumento nulo é passado para um método que não aceita argumentos nulos.

while (opcao != 5)
{
    switch (opcao)
    {
        case 1:
            Cadastrarhospede.CadastrarHospede();
            break;
        case 2:
            Cadastrarhospede.CadastrarSuite();
            break;
        case 3:
            Cadastrarhospede.ObterQuantidadeHospedes();
            break;
        case 4:
            Cadastrarhospede.CalcularValorDiaria();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Digite 1 para cadastrar hóspede");
    Console.WriteLine("Digite 2 para cadastrar suíte");
    Console.WriteLine("Digite 3 para obter quantidade de hóspedes");
    Console.WriteLine("Digite 4 para obter quantidade de suítes");
    Console.WriteLine("Digite 5 para sair");

    opcao = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
    // int.Parse converte a representação de cadeia de caracteres de um número para o seu equivalente inteiro.
    // throw new ArgumentNullException é uma exceção que é acionada quando um argumento nulo é passado para um método que não aceita argumentos nulos.
}
