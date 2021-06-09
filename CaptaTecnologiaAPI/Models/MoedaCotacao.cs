
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaptaTecnologiaAPI.Models
{
    public class MoedaCotacao
    {
        public string simbolo { get; set; }
        public string nomeFormatado { get; set; }
        public string tipoMoeda { get; set; }
        public double cotacaoCompra { get; set; }
        public double cotacaoVenda { get; set; }
        public string dataHoraCotacao { get; set; }
    }
}
