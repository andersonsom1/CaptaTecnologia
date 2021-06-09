using CaptaTecnologia.Models;
using CaptaTecnologiaAPI.Models;
using CaptaTecnologiaAPI.Models.Interfaces;
using CaptaTecnologiaAPI.Utils;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CaptaTecnologiaAPI.Repository
{
    public class RepositoryCotacaoMoedas : BaseRepository, IRepositoryCotacaoMoedas
    {

        public RepositoryCotacaoMoedas(IOptions<AppConfiguration> config) : base(config.Value.DbSQlServer)
        {

        }

        public async Task<IEnumerable<MoedaCotacao>> SelectMoedaCotacaoSQLServer()
        {
            try
            {
                return await _dbConnection.QueryAsync<MoedaCotacao>(Querys.SelectCotacaMoeda, null, null, null, CommandType.Text);
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