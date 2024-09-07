using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.models
{
    public class Pessoa
    {
        public required string Nome { get; set; }
        public int Id { get; set; }

        public Pessoa(string nome, int id)
        {
            Nome = nome;
            Id = id;
        }
    }
}