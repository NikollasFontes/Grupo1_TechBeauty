using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Endereco
    {
        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Cidade { get; private set; }
        public string Uf { get; private set; }
        public string Numero { get; private set; }
        public string Complemento{ get; private set; }
        public string Cep { get; set; }//implementar
        public string Bairro { get; set; }//implementar

        public static Endereco RegistrarEndereco(int id, string logradouro, string cidade, string uf, string numero, string complemento, string cep, string bairro)
        {
            Endereco endereco = new();
            endereco.Id = id;
            endereco.Logradouro = logradouro;
            endereco.Cidade = cidade;
            endereco.Uf = uf;
            endereco.Numero = numero;
            endereco.Complemento = complemento;
            endereco.Cep = cep;
            endereco.Bairro = bairro;
            return endereco;
        }

        internal void AlterarEndereco(Endereco endereco)
        {
            Logradouro = endereco.Logradouro;
            Cidade = endereco.Cidade;
            Uf = endereco.Uf;
            Numero = endereco.Numero;
            Complemento = endereco.Complemento;
            Cep = endereco.Cep;
            Bairro = endereco.Bairro;
        }
    }
}
