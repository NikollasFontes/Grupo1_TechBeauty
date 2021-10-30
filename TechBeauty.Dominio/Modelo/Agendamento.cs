using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class Agendamento
    {
        public int Id { get; private set; }
        public Servico Servico { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public string PessoaAtendida { get; private set; }
        public DateTime DataHoraInicio { get; private set; }
        public OrdemServico OrdemServico { get; private set; }
        public DateTime DataHoraCriacao { get; private set; }
        public DateTime DataHoraTermino { get; private set; }
        public StatusAgendamento StatusAgendamento { get; private set; }

        public static Agendamento CriarAgendamento(int Id, Servico servico, Colaborador colaborador,
            string pessoaAtendida, DateTime dataHora, OrdemServico ordemServico,
            DateTime dataHoraCriacao)
        {
            Agendamento agendamento = new();
            agendamento.Id = Id;
            agendamento.Servico = servico;
            agendamento.Colaborador = colaborador;
            agendamento.PessoaAtendida = pessoaAtendida;
            agendamento.DataHoraInicio = dataHora;
            agendamento.OrdemServico = ordemServico;
            agendamento.DataHoraCriacao = dataHoraCriacao;
            agendamento.StatusAgendamento = StatusAgendamento.Agendado;
            return agendamento;
        }

        public void ExecucaoServico(DateTime dataHoraInicio)
        {
            DataHoraInicio = dataHoraInicio;
        }

        public void AlterarStatusAgendamento(StatusAgendamento status)
        {
            StatusAgendamento = status;
        }

        public void ModificarAgendamento(Servico servico, Colaborador colaborador,
            string pessoaAtendida, DateTime dataHora, OrdemServico ordemServico, StatusAgendamento statusAgendamento)
        {
            Servico = servico;
            Colaborador = colaborador;
            PessoaAtendida = pessoaAtendida;
            DataHoraInicio = dataHora;
            OrdemServico = ordemServico;
            StatusAgendamento = statusAgendamento;
        }
    }
}
