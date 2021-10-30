using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Escala
    {
        public int Id { get; private set; }
        public DateTime DataHoraEntrada { get; private set; }
        public DateTime DataHoraSaida { get; private set; }
        public Colaborador Colaborador { get; private set; }

        public static Escala GerarEscala(int id, DateTime dataHoraEntrada, DateTime dataHoraSaida, Colaborador colaborador)
        {
            Escala escala = new();
            escala.Id = id;
            escala.DataHoraEntrada = dataHoraEntrada;
            escala.DataHoraSaida = dataHoraSaida;
            escala.Colaborador = colaborador;
            return escala;
        }

        public void AlterarEscala(Escala escala)
        {
            DataHoraEntrada = escala.DataHoraEntrada;
            DataHoraSaida = escala.DataHoraSaida;
            Colaborador = escala.Colaborador;
        }

        public void AlterarColaboradorEscala(Colaborador colaborador)
        {
            Colaborador = colaborador;
        }
    }
}
