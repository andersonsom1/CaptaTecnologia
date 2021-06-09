using CaptaTecnologia.Models;
using CaptaTecnologia.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptaTecnologia.Services
{
    public class ServiceMoedas : IServiceMoedas
    {
        private readonly IBCBService _bCBService;
        private readonly IRepositoryMoedas _repositoryMoedas;

        public ServiceMoedas(IBCBService bCBService, IRepositoryMoedas repositoryMoedas)
        {
            _bCBService = bCBService;
            _repositoryMoedas = repositoryMoedas;
        }

        public async Task<CotacaoMoeda> GetCotacaoMoeda(DateTime date)
        {
            try
            {
                return await _bCBService.GetBCBCotacaoMoedas(date.ToString("MMddyyyy"));
            }
            catch (Exception e)
            {
                throw new Exception("Um erro ocorreu no Metodo GetMoedas " + e.Message);
            }
        }

        public async Task<Moedas> GetMoedas()
        {
            try
            {
                return await _bCBService.GetBCBMoedas();
            }
            catch (Exception e)
            {
                throw new Exception("Um erro ocorreu no Metodo GetMoedas " + e.Message);
            }

        }

        public async Task<bool> UpdateDbCotacaoMoedas(CotacaoMoeda cotacaoMoeda)
        {
            try
            {
                cotacaoMoeda.value.ToList().ForEach(val =>
                {
                    _repositoryMoedas.UpdateCotacaoMoedaSQLServer(val).Wait();
                });

                return await Task.FromResult(true);
            }
            catch (Exception e)
            {

                throw new Exception("Um erro ocorreu no Metodo UpdateDbCotacaoMoedas " + e.Message);
            }

        }


    public async Task<bool> UpdateDbMoedas(Moedas modelMoedas)
    {
        try
        {
            modelMoedas.value.ToList().ForEach(val =>
            {
                _repositoryMoedas.UpdateMoedaSQLServer(val).Wait();
            });

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {

            throw new Exception("Um erro ocorreu no Metodo UpdateDbMoedas " + e.Message);
        }

    }
}
}
