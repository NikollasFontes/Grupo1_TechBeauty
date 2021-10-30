using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class OrdemServico
    {
        public int Id { get; private set; }
        public decimal PrecoTotal { get; private set; }
        public int DuracaTotal { get; private set; }
        public Cliente Cliente { get; private set; }
        public StatusOS StatusOS { get; private set; }

        public static OrdemServico AbrirOrdemServico(int id, int duracaTotal, Cliente cliente, StatusOS statusOS)
        {
            OrdemServico ordemServico = new();
            ordemServico.Cliente = cliente;
            ordemServico.DuracaTotal = duracaTotal;
            ordemServico.Id = id;
            ordemServico.PrecoTotal = 0.0M;
            ordemServico.StatusOS = statusOS;
            return ordemServico;
        }

        internal void AlterarPrecoTotalOrdemServico(OrdemServico ordemServico)
        {
            PrecoTotal = ordemServico.PrecoTotal;
            StatusOS = ordemServico.StatusOS;
            DuracaTotal = ordemServico.DuracaTotal;
            Cliente = ordemServico.Cliente;
        }

        public void AlterarPrecoTotal(decimal precoTotal)
        {
            PrecoTotal += precoTotal;
        }

        public void ModificarStatusOrdemServico(StatusOS statusOS)
        {
            StatusOS = statusOS;
        }
    }
}
