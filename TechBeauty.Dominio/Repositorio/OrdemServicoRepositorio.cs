using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.ContextDb;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class OrdemServicoRepositorio
    {
        private readonly DBContext context;

        public OrdemServicoRepositorio()
        {
            context = new();
        }

        public void Incluir(OrdemServico ordemServico)
        {
            context.OrdemServico.Add(ordemServico);
            context.SaveChanges();
        }

        public void Alterar(int id, OrdemServico ordemServico)
        {
            context.OrdemServico.FirstOrDefault(x => x.Id == id).AlterarPrecoTotalOrdemServico(ordemServico);
            context.SaveChanges();
        }

        public OrdemServico PegarOrdemServico(int id)
        {
            return context.OrdemServico.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.OrdemServico.Remove(context.OrdemServico.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public List<OrdemServico> Tabela()
        {
            return context.OrdemServico.ToList();
        }

        public void AlterarPrecototal(int id, decimal valor)
        {
            context.OrdemServico.FirstOrDefault(x => x.Id == id).AlterarPrecoTotal(valor);
            context.SaveChanges();
        }
    }
}
