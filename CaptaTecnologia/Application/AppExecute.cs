using CaptaTecnologia.Models;
using CaptaTecnologia.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptaTecnologia.Application
{
    public class AppExecute : IAppExecute
    {
        private readonly IServiceMoedas _serviceMoedas;

        public AppExecute(IServiceMoedas serviceMoedas)
        {
            _serviceMoedas = serviceMoedas;
        }

        public async Task<bool> Start()
        {
            try
            {
                Console.WriteLine("Iniciando aplicacao");
                //lista de moedas
                Console.WriteLine("Listando moedas...");
                Moedas moedas = await _serviceMoedas.GetMoedas();
                Console.WriteLine("Moedas listados : " + moedas.value.Count());

                if (moedas.value.Any())
                {
                    //Grava Moedas no banco de dados
                    Console.WriteLine("Gravando moedas no banco...");
                    await _serviceMoedas.UpdateDbMoedas(moedas);
                }

                Console.WriteLine("Listando cotacao moedas...");
                CotacaoMoeda cotacaoMoeda = await _serviceMoedas.GetCotacaoMoeda(DateTime.Now.AddDays(-1));

                if (cotacaoMoeda.value.Any())
                {
                    //Grava Moedas no banco de dados
                    Console.WriteLine("Gravando cotacao moedas no banco...");
                    await _serviceMoedas.UpdateDbCotacaoMoedas(cotacaoMoeda);
                }


                Console.WriteLine("Aplicação finalizada com sucesso");

                return await Task.FromResult(true);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
