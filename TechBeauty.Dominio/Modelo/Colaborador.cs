using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Colaborador : Pessoa
    {
        public List<Servico> Servicos { get; private set; }
        public Endereco Endereco { get; private set; }
        public Genero Genero { get; private set; }
        public string Nomesocial { get; private set; }
        public ContratoTrabalho ContratoTrabalho { get; private set; }


        public static Colaborador CriarColaborador(int id, string nome, string CPF, DateTime dataNascimento,
            List<Contato> contatos, List<Servico> servicos, Endereco endereco, Genero genero,
            string nomesocial, ContratoTrabalho contratoTrabalho)
        {
            Colaborador colaborador = new();
            colaborador.Id = id;
            colaborador.Nome = nome;
            colaborador.Cpf = CPF;
            colaborador.DataNascimento = dataNascimento;
            colaborador.Contatos = contatos;
            colaborador.Servicos = servicos;
            colaborador.Endereco = endereco;
            colaborador.Genero = genero;
            colaborador.Nomesocial = nomesocial;
            colaborador.ContratoTrabalho = contratoTrabalho;
            return colaborador;
        }

        public void AlterarColaborador(Colaborador colaborador)
        {
            Nome = colaborador.Nome;
            Cpf = colaborador.Cpf;
            DataNascimento = colaborador.DataNascimento;
            Contatos = colaborador.Contatos;
            Servicos = colaborador.Servicos;
            Endereco = colaborador.Endereco;
            Genero = colaborador.Genero;
            Nomesocial = colaborador.Nomesocial;
            ContratoTrabalho = colaborador.ContratoTrabalho;
        }

        public void AlterarGenero(Genero genero)
        {
            Genero = genero;
        }

        public void AditarContrato(ContratoTrabalho contrato)
        {
            ContratoTrabalho = contrato;
        }
    }
}
