using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Cargo
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public static Cargo criarCargo(int id, string nome, string descricao)
        {
            Cargo cargo = new();
            cargo.Id = id;
            cargo.Nome = nome;
            cargo.Descricao = descricao;
            return cargo;
        }


        public void AlterarCargo(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
