using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Beneficio
    {
        /*
         * 40% caso leve outro cliente
         * 10% pagamento PIX
         * Produtos cosmeticos 
         * Bonus de R$50,00 em consumos no salão
         * Amostra gratis de um serviço ou produto
         * Promoção Uber, valeu R$30,00.
         * 15% de desconto na compra de um pacote de serviço
         */
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public static Beneficio GerarBeneficio(int id, string nome, string descricao)
        {
            Beneficio beneficio = new();
            beneficio.Id = id;
            beneficio.Nome = nome;
            beneficio.Descricao = descricao;
            return beneficio;
        }

        public void AlterarBeneficio(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
