using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Servico
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Decimal Valor { get; private set; }
        public string Descricao { get; private set; }
        public int DuracaoEmMin { get; private set; }

        public static Servico RegistrarServico(int id, string nome, decimal valor, string descricao, int duracaoEmMin)
        {
            Servico servico = new();
            servico.Id = id;
            servico.Nome = nome;
            servico.Valor = valor;
            servico.Descricao = descricao;
            servico.DuracaoEmMin = duracaoEmMin;
            return servico;
        }

        public void ModificarServico(Servico servico)
        {
            Nome = servico.Nome;
            Valor = servico.Valor;
            Descricao = servico.Descricao;
            DuracaoEmMin = servico.DuracaoEmMin;
        }

        public void AlterarCustoServico(decimal valor)
        {
            Valor = valor;
        }
    }
}
