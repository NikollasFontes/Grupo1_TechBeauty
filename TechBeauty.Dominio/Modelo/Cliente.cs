using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Cliente : Pessoa
    {

        public static Cliente CriarCliente(int id, string nome, string cpf, DateTime dataNascimento, List<Contato> contatos)
        {
            Cliente cliente = new();
            cliente.Id = id;
            cliente.Nome = nome;
            cliente.Cpf = cpf;
            cliente.DataNascimento = dataNascimento;
            cliente.Contatos = contatos;
            return cliente;
        }

        internal void AlterarCliente(Cliente cliente)
        {
            Nome = cliente.Nome;
            Cpf = cliente.Cpf;
            DataNascimento = cliente.DataNascimento;
            Contatos = cliente.Contatos;
        }
    }
}
