using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaptaTecnologiaAPI.Repository
{
    public struct Querys
    {
        public const string SelectCotacaMoeda = @"select Simbolo
                                ,NomeFormatado
                                ,M.tipoMoeda
                                ,CotacaoCompra
                                ,CotacaoVenda
                                ,dataHoraCotacao
                                from tb_Moedas M 
                                JOIN tb_Cambio C on C.tipoMoeda = M.Simbolo";
    }
}
