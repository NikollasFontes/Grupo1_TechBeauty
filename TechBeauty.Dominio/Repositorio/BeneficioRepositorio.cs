using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.ContextDb;

namespace TechBeauty.Dominio.Repositorio
{
    public class BeneficioRepositorio
    {
        private readonly DBContext context;

        public BeneficioRepositorio()
        {
            context = new();
        }

        public void IncluirBeneficio(Beneficio beneficio)
        {
            context.Beneficio.Add(beneficio);
            context.SaveChanges();
        }

        public void AlterarBeneficio(int id, Beneficio beneficio)
        {
            context.Beneficio.FirstOrDefault(x => x.Id == id).AlterarBeneficio(beneficio.Nome, beneficio.Descricao);
            context.SaveChanges();
        }

        public void ExcluirBeneficio(int id)
        {
            context.Beneficio.Remove(context.Beneficio.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public Beneficio SelecionarBeneficio(int id)
        {
            return context.Beneficio.FirstOrDefault(x => x.Id == id);
        }

        public List<Beneficio> Tabela()
        {
            return context.Beneficio.ToList();
        }
    }
}
