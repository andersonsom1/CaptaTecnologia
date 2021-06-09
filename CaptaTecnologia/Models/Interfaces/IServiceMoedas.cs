using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CaptaTecnologia.Models.Interfaces
{
    public interface IServiceMoedas
    {
        Task<Moedas> GetMoedas();
        Task<bool> UpdateDb(Moedas moedas);
    }
}
