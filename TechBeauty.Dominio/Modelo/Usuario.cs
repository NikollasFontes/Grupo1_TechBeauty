using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Password { get; private set; }
        public Cargo Cargo { get; private set; }

        public static Usuario CriarUsuario(int id, string nome, string password, Cargo cargo)
        {
            Usuario usuario = new();
            usuario.Id = id;
            usuario.Nome = nome;
            usuario.Password = password;
            usuario.Cargo = cargo;
            return usuario;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarCargo(Cargo cargo)
        {
            Cargo = cargo;
        }

        public void AlterarSenha(string password)
        {
            Password = password;
        }
    }
}
