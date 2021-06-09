using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaptaTecnologiaAPI.Models.Interfaces
{
    public interface IRepositoryCotacaoMoedas
    {
        Task<IEnumerable<MoedaCotacao>> SelectMoedaCotacaoSQLServer();
    }
}
