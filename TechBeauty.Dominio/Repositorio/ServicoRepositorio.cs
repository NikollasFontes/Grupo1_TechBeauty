using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.ContextDb;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class ServicoRepositorio
    {
        private readonly DBContext context;

        public ServicoRepositorio()
        {
            context = new();
        }

        public void Incluir(Servico servico)
        {
            context.Servico.Add(servico);
            context.SaveChanges();
        }

        public void Alterar(int id, Servico servico)
        {
            context.Servico.FirstOrDefault(x => x.Id == id).ModificarServico(servico);
            context.SaveChanges();
        }

        public Servico PegarServico(int id)
        {
            return context.Servico.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Remove(context.Servico.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public List<Servico> Tabela()
        {
            return context.Servico.ToList();
        }
    }
}
