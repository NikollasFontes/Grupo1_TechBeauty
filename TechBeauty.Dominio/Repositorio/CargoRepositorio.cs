using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.ContextDb;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class CargoRepositorio
    {
        private readonly DBContext context;

        public CargoRepositorio()
        {
            context = new();
        }
        
        public void incluir(Cargo cargo)
        {
            context.Cargo.Add(cargo);
            context.SaveChanges();
        }

        public void Atualizar(int id, Cargo cargo)
        {
            context.Cargo.FirstOrDefault(x=>x.Id == id).AlterarCargo(cargo.Nome, cargo.Descricao);
            context.SaveChanges();
        }

        public Cargo PegarCargo(int id)
        {
            return context.Cargo.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Cargo.Remove(context.Cargo.FirstOrDefault(x=>x.Id == id));
            context.SaveChanges();
        }

        public List<Cargo> Tabela()
        {
            return context.Cargo.ToList();
        }
    }
}
