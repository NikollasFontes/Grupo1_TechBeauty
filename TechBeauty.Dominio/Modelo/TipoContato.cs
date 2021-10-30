using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class TipoContato
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }

        public static TipoContato CriarTipoContato(int id, string valor)
        {
            TipoContato contato = new();
            contato.Id = id;
            contato.Valor = valor;
            return contato;
        }

        public void AtualizarTipoContato(string valor)
        {
            Valor = valor;
        }
    }
}
