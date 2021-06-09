using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptaTecnologia.Models
{
public class CotacaoMoeda
    {
        public string odatacontext { get; set; }
        public CotacaoValue[] value { get; set; }
    }

    public class CotacaoValue
    {
        public double cotacaoCompra { get; set; }
        public double cotacaoVenda { get; set; }
        public string dataHoraCotacao { get; set; }
    }
}
