using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.ContextDb;

namespace TechBeauty.Dominio.Repositorio
{
    public class GeneroRepositorio
    {
        private readonly DBContext context;

        public GeneroRepositorio()
        {
            context = new();
        }

        public void Incluir(Genero genero)
        {
             context.Genero.Add(genero);
             context.SaveChanges();
        }

        public void Alterar(int id, string genero)
        {
            context.Genero.FirstOrDefault(x => x.Id == id).AlterarGenero(genero);
            context.SaveChanges();
        }

        public Genero PegarGenero(int id)
        {
            return context.Genero.FirstOrDefault(x=>x.Id == id);
        }

        public void Remover(int id)
        {
            context.Genero.Remove(context.Genero.First(x => x.Id == id));
            context.SaveChanges();
        }

        public List<Genero> Tabela()
        {
            return context.Genero.ToList();
        }
    }
}
