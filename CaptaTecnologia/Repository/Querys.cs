using System;
using System.Collections.Generic;
using System.Text;

namespace CaptaTecnologia.Repository
{
    public struct Querys
    {

        public enum Parameters
        {
            @Simbolo,
            @NomeFormatado,
            @tipoMoeda,
            @CotacaoCompra,
            @CotacaoVenda,
            @DataHora,


        }

        public const string UpsertMoedas = @"begin
                                            if exists(select 1 from tb_Moedas where Simbolo = @Simbolo)
	                                            begin
	                                                update tb_Moedas set NomeFormatado = @NomeFormatado, tipoMoeda = @tipoMoeda  where Simbolo = @Simbolo;
	                                            end 
	                                        else 
	                                            begin 
	                                                insert into tb_Moedas values(@Simbolo,@NomeFormatado,@tipoMoeda);
	                                            end
                                            end";

        public const string UpsertCotacaoMoedas = @"begin
                                            if exists(select 1 from tb_Cambio where dataHoraCotacao = @DataHora and tipoMoeda = 'USD')
	                                            begin
	                                                update tb_Cambio set CotacaoCompra = @CotacaoCompra,CotacaoVenda = @CotacaoVenda where dataHoraCotacao = @DataHora and tipoMoeda = 'USD';
	                                            end 
	                                        else 
	                                            begin 
	                                                insert into tb_Cambio values(@CotacaoCompra,@CotacaoVenda,@DataHora, 'USD');
	                                            end
                                            end";
    }
}
