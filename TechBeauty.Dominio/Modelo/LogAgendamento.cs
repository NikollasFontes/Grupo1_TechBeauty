using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class LogAgendamento
    {
        public int id { get; set; }
        public DateTime DataCriacao { get; set; }
        public StatusAgendamento Status { get; set; }
        public Agendamento Agendamento { get; set; }

        public static LogAgendamento CriarLogAgendamento(DateTime dataCriacao, StatusAgendamento status, Agendamento agendamento)
        {
            LogAgendamento logAgendamento = new();
            logAgendamento.DataCriacao = dataCriacao;
            logAgendamento.Status = status;
            logAgendamento.Agendamento = agendamento;
            return logAgendamento;
        }


    }
}
