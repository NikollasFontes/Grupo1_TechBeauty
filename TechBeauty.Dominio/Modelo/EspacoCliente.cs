using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Modelo
{
    public class EspacoCliente
    {
        public int Id { get; private set; }
        public Beneficio Beneficio { get; private set; }
        public List<OrdemServico> OrdemServicos { get; set; }

        public static EspacoCliente CriarEspacoCliente(int id, List<OrdemServico> ordemServicos)
        {
            EspacoCliente espaco = new();
            espaco.Id = id;
            espaco.OrdemServicos = ordemServicos;
            return espaco;
        }

        public void ValidarBeneficio()
        {

        }
    }
}
