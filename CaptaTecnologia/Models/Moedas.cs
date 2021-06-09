using System;
using System.Collections.Generic;
using System.Text;

namespace CaptaTecnologia.Models
{

    public class Moedas
    {
        public string odatacontext { get; set; }
        public Value[] value { get; set; }
    }

    public class Value
    {
        public string simbolo { get; set; }
        public string nomeFormatado { get; set; }
        public string tipoMoeda { get; set; }
    }
}