using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Contato
    {
        public int Id { get; private set; }
        public TipoContato Tipo { get; private set; }
        public string Valor { get; private set; }

        public static Contato CriarContato(int id, string valor, TipoContato tipoContato)
        {
            Contato contato = new();
            contato.Id = id;
            contato.Valor = valor;
            contato.Tipo = tipoContato;
            return contato;
        }

        public void AlterarContato(string contato)
        {
            Valor = contato;
        }

        public void AlterarTipoContato(TipoContato tipoContato)
        {
            Tipo = tipoContato;
        }
    }
}
