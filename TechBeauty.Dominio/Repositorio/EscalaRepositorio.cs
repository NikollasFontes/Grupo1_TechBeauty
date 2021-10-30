using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.ContextDb;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class EscalaRepositorio
    {
        private readonly DBContext context;

        public EscalaRepositorio()
        {
            context = new();
        }

        public void Incluir(Escala escala)
        {
            context.Escala.Add(escala);
            context.SaveChanges();
        }

        public void Aletar(int id, Escala escala)
        {
            context.Escala.FirstOrDefault(x => x.Id == id).AlterarEscala(escala);
            context.SaveChanges();
        }

        public Escala PegarEscala(int id)
        {
            return context.Escala.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Escala.Remove(context.Escala.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public List<Escala> Tabela()
        {
            return context.Escala.ToList();
        }
    }
}
