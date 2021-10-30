using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class Pagamento
    {
        public int Id { get; private set; }
        public FormaPagamento FormaPagamento { get; private set; }
        public OrdemServico OrdemServico { get; private set; }
        public DateTime DataHoraPagamento { get; private set; }
        public decimal ValorRecebido { get; private set; }
        public decimal? Troco { get; private set; }

        public static Pagamento GerarPagamento(int id, FormaPagamento forma, OrdemServico ordem, DateTime date, decimal valorRecebido)
        {
            Pagamento pagamento = new();
            pagamento.Id = id;
            pagamento.FormaPagamento = forma;
            pagamento.OrdemServico = ordem;
            pagamento.DataHoraPagamento = date;
            pagamento.ValorRecebido = valorRecebido;
            return pagamento;
        }

        public void AlterarFormaPagamento(FormaPagamento forma)
        {
            FormaPagamento = forma;
        }

        public void AlterarDataHora(DateTime data)
        {
            DataHoraPagamento = data;
        }

        public void CalculaTroco()
        {
            Troco = ValorRecebido - OrdemServico.PrecoTotal;
        }
    }
}
