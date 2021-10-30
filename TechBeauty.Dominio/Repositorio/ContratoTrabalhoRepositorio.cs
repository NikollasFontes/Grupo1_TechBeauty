using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.ContextDb;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class ContratoTrabalhoRepositorio
    {
        private readonly DBContext context;

        public ContratoTrabalhoRepositorio()
        {
            context = new();
        }

        public void Incluir(ContratoTrabalho contratoTrabalho)
        {
            context.ContratoTrabalho.Add(contratoTrabalho);
            context.SaveChanges();
        }

        public void Alterar(int id, ContratoTrabalho contratoTrabalho)
        {
            context.ContratoTrabalho.FirstOrDefault(x => x.Id == id).Modificarcontrato(contratoTrabalho);
            context.SaveChanges();
        }

        public void EncerramentoContrato(int id, DateTime dataDesligamento)
        {
            context.ContratoTrabalho.FirstOrDefault(x => x.Id == id).EncerrarContrato(dataDesligamento);
            context.SaveChanges();
        }

        public ContratoTrabalho PegarContratoTrabalho(int id)
        {
            return context.ContratoTrabalho.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.ContratoTrabalho.Remove(context.ContratoTrabalho.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public List<ContratoTrabalho> Tabela()
        {
            return context.ContratoTrabalho.ToList();
        }
    }
}
