using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CaptaTecnologia.Models.Interfaces
{
    public interface IServiceMoedas
    {
        Task<Moedas> GetMoedas();
        Task<CotacaoMoeda> GetCotacaoMoeda(DateTime date);
        Task<bool> UpdateDbMoedas(Moedas moedas);
        Task<bool> UpdateDbCotacaoMoedas(CotacaoMoeda cotacaoMoeda);
    }
}
