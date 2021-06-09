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

        //MOEDAS
        [Get("/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?%40dataCotacao=%27{data}%27&%24format=json")]
        Task<CotacaoMoeda> GetBCBCotacaoMoedas(string data);
    }
}
