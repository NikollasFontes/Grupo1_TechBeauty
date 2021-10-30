using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Caixa
    {
        public int Id { get; private set; }
        public decimal SaldoInicial { get; private set; }
        public decimal SaldoFinalCaixa { get; private set; }
        public DateTime DataHoraAbertura { get; private set; }
        public DateTime DataHoraFechamento { get; private set; }
        public List<Pagamento> Pagamentos { get; private set; }
        public decimal LucroDiario { get; private set; }

        public static Caixa AbrirCaixa(int id, decimal saldoInicial, DateTime dataHoraAbertura)
        {
            Caixa caixa = new();
            caixa.Id = id;
            caixa.SaldoInicial = saldoInicial;
            caixa.DataHoraAbertura = dataHoraAbertura;
            return caixa;
        }

        public void FecharCaixa(DateTime dataHoraFechamento, List<Pagamento> pagamentos)
        {
            DataHoraFechamento = dataHoraFechamento;
            Pagamentos = pagamentos;
            decimal valor = 0;
            foreach (var item in pagamentos)
            {
                valor += item.OrdemServico.PrecoTotal;
            }
            LucroDiario = valor - SaldoInicial;
            SaldoFinalCaixa = valor + SaldoInicial;
        }

        public decimal ComissaoDiariaColaborador()
        {
            return 0;
        }
    }
}
