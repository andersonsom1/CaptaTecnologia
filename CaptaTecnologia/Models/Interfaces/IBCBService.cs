using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CaptaTecnologia.Models.Interfaces
{
    public interface IBCBService
    {
        //MOEDAS
        [Get("/servico/PTAX/versao/v1/odata/Moedas?%24format=json")]
        Task<Moedas> GetBCBMoedas();
    }
}
