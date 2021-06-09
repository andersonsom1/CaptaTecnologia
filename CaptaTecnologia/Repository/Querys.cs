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
            @tipoMoeda
        }

        public const string UpsertMoedas = @"begin
                                            if exists(select 1 from tb_Moedas where Simbolo = @Simbolo)
	                                            begin
	                                                update tb_Moedas set NomeFormatado = 'Teste' where Simbolo = @Simbolo;
	                                            end 
	                                        else 
	                                            begin 
	                                                insert into tb_Moedas values(@Simbolo,@NomeFormatado,@tipoMoeda);
	                                            end
                                            end";
    }
}
