using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.models
{
    public class Suite
    {
        public required string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public Decimal ValorDiaria { get; set; }
    }
}