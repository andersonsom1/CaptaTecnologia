using CaptaTecnologia.Models;
using CaptaTecnologia.Models.Interfaces;
using CaptaTecnologia.Utils;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CaptaTecnologia.Repository
{
    public class RepositoryMoedas : BaseRepository, IRepositoryMoedas
    {

        public RepositoryMoedas(IOptions<AppConfiguration> config) : base(config.Value.DbSQlServer)
        {

        }


        public async Task<int> UpdateCotacaoMoedaSQLServer(CotacaoValue cotacaoMoeda)
        {
            try
            {

                IDictionary<string, object> Map = new Dictionary<string, object>();
                Map.Add(Querys.Parameters.@CotacaoCompra.ToString(), cotacaoMoeda.cotacaoCompra);
                Map.Add(Querys.Parameters.@CotacaoVenda.ToString(), cotacaoMoeda.cotacaoVenda);
                Map.Add(Querys.Parameters.@DataHora.ToString(), cotacaoMoeda.dataHoraCotacao);

                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.AddDynamicParams(Map);

                return await _dbConnection.ExecuteAsync(Querys.UpsertCotacaoMoedas, dynamicParameters, null, null, CommandType.Text);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public async Task<int> UpdateMoedaSQLServer(Value moedas)
        {
            try
            {

                IDictionary<string, object> Map = new Dictionary<string, object>();
                Map.Add(Querys.Parameters.@Simbolo.ToString(), moedas.simbolo);
                Map.Add(Querys.Parameters.@tipoMoeda.ToString(), moedas.tipoMoeda);
                Map.Add(Querys.Parameters.@NomeFormatado.ToString(), moedas.nomeFormatado);

                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.AddDynamicParams(Map);

                return await _dbConnection.ExecuteAsync(Querys.UpsertMoedas, dynamicParameters,null,null,CommandType.Text);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
