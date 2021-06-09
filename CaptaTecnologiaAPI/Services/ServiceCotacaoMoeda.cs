using CaptaTecnologiaAPI.Models;
using CaptaTecnologiaAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaptaTecnologiaAPI.Services
{
    public class ServiceCotacaoMoeda : IServiceCotacaoMoeda
    {
        private readonly IRepositoryCotacaoMoedas _repositoryCotacaoMoedas;

        public ServiceCotacaoMoeda(IRepositoryCotacaoMoedas repositoryCotacaoMoedas)
        {
            _repositoryCotacaoMoedas = repositoryCotacaoMoedas;
        }


        public async Task<IEnumerable<MoedaCotacao>> GetCotacaoMoeda()
        {
            return await _repositoryCotacaoMoedas.SelectMoedaCotacaoSQLServer();
        }
    }
}
