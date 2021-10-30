using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Repositorio;

namespace TecBeautyCsl
{
    class Program
    {
        private static CargoRepositorio reporCargo = new();
        private static GeneroRepositorio repoGenero = new();
        private static TipoContatoRepositorio reporTipoContato = new();
        private static ContatoRepositorio reporContato = new();
        private static EnderecoRepositorio reporEndereco = new();
        private static ServicoRepositorio reporServico = new();
        private static RegimeContratualRepositorio reporRegimeContratual = new();
        private static ContratoTrabalhoRepositorio reporContratoTrabalho = new();
        private static ClienteRepositorio reporCliente = new();
        private static ColaboradorRepositorio reporColaborador = new();
        private static EscalaRepositorio reporEscala = new();
        private static OrdemServicoRepositorio reporOrdemServico = new();
        private static AgendamentoRepositorio reporAgendamento = new();
        private static List<LogAgendamento> LogAgendamento = new();

        static void Main(string[] args)
        {
            
        }


        public static List<Genero> PreencherGenero()
        {
            Genero genero1 = Genero.RegistrarGenero("Feminino");
            repoGenero.Incluir(genero1);

            Genero genero2 = Genero.RegistrarGenero("Masculino");
            repoGenero.Incluir(genero2);

            Genero genero3 = Genero.RegistrarGenero("Mulher Trans");
            repoGenero.Incluir(genero3);

            return repoGenero.Tabela();
        }

        public static List<Cargo> PreencherCargos()
        {

            Cargo cargo1 = Cargo.criarCargo(1, "Cabelereira", "Corte de cabelo");
            reporCargo.incluir(cargo1);
            Cargo cargo2 = Cargo.criarCargo(2, "Manicure", "Pintar unha");
            reporCargo.incluir(cargo2);
            Cargo cargo3 = Cargo.criarCargo(3, "Depiladora ", "Depilações");
            reporCargo.incluir(cargo3);
            Cargo cargo4 = Cargo.criarCargo(4, "Colorista", "Pintar");
            reporCargo.incluir(cargo4);

            return reporCargo.Tabela();
        }

        public static void AtualizarCargo(int id, string nome, string descricao)
        {
            Cargo cargo = new Cargo();
            cargo.AlterarCargo(nome, descricao);
            reporCargo.Atualizar(id, cargo);
        }

        public static Cargo PegarCargo(int Id)
        {
            return reporCargo.PegarCargo(Id);
        }

        private static List<TipoContato> PreencherTipoContato()
        {
            TipoContato tipoContato = TipoContato.CriarTipoContato(1, "TiKTok");
            reporTipoContato.Incluir(tipoContato);
            TipoContato tipoContato2 = TipoContato.CriarTipoContato(2, "Linkedln");
            reporTipoContato.Incluir(tipoContato2);
            TipoContato tipoContato3 = TipoContato.CriarTipoContato(3, "E-mail");
            reporTipoContato.Incluir(tipoContato3);
            return reporTipoContato.Tabela();
        }

        private static List<Contato> PreencherContato(List<TipoContato> tiposContatos)
        {
            Contato contato1 = Contato.CriarContato(1, "@wallysonalessandro", tiposContatos.FirstOrDefault(x => x.Id == 1));
            reporContato.Incluir(contato1);
            Contato contato2 = Contato.CriarContato(2, "wallyson-nabarro", tiposContatos.Where(x => x.Id == 2).FirstOrDefault());
            reporContato.Incluir(contato2);
            Contato contato3 = Contato.CriarContato(3, "wallyson.a3@gmail.com", tiposContatos.FirstOrDefault(x => x.Id == 3));
            reporContato.Incluir(contato3);
            return reporContato.Tabela();
        }

        private static List<Contato> AtualizarContato(int id, string nome, TipoContato tipo)
        {
            Contato contato = Contato.CriarContato(id, nome, tipo);
            reporContato.Alterar(id, contato);
            return reporContato.Tabela();
        }

        private static List<Contato> RemoverContato(int id)
        {
            reporContato.Remover(id);
            return reporContato.Tabela();
        }

        private static List<Endereco> PreencherEndereco()
        {
            int E = 0;
            for (int i = 0; i < 3; i++)
            {
                E++;
                reporEndereco.Incluir(Endereco.RegistrarEndereco(E, $"Rua {E}", $"Samambaia{E}", $"DF{E}", $"{E}", $"Casa {E}", $"{1425634 + E}", $"Itaipu {E}"));
            }
            return reporEndereco.Tabela();
        }

        private static List<Servico> PreencherServico()
        {
            Servico servico = Servico.RegistrarServico(1, "Aparar unha", 10.50M, "Aparar e tirar a cuticula.", 30);
            reporServico.Incluir(servico);
            Servico servico2 = Servico.RegistrarServico(2, "Corte e escova", 290.99M, "Aparar as pontas e escovar.", 140);
            reporServico.Incluir(servico2);
            Servico servico3 = Servico.RegistrarServico(3, "Tingimento", 90.10M, "Prepara o cabelo e pintar.", 200);
            reporServico.Incluir(servico3);
            return reporServico.Tabela();
        }

        private static List<RegimeContratual> PreencherRegimeContratual()
        {
            RegimeContratual regimeContratual = RegimeContratual.CriarRegimeContratual(1, "PJ");
            reporRegimeContratual.Incluir(regimeContratual);
            RegimeContratual regimeContratual2 = RegimeContratual.CriarRegimeContratual(2, "CTPS");
            reporRegimeContratual.Incluir(regimeContratual2);
            return reporRegimeContratual.Tabela();
        }

        private static List<ContratoTrabalho> PreencherContratoTrabalho(List<RegimeContratual> regimeContratuals, List<Cargo> cargos)
        {
            List<Cargo> lista1 = new();
            lista1.Add(cargos.FirstOrDefault(x => x.Id == 1)) ;
            lista1.Add(cargos.FirstOrDefault(x => x.Id == 2));
            ContratoTrabalho contrato = ContratoTrabalho.Contratar(1, regimeContratuals.FirstOrDefault(x => x.Id == 1), DateTime.Now, lista1, "25.136.009/0001-05");
            reporContratoTrabalho.Incluir(contrato);

            List<Cargo> lista2 = new();
            lista2.Add(cargos.FirstOrDefault(x => x.Id == 1));
            ContratoTrabalho contrato2 = ContratoTrabalho.Contratar(2, regimeContratuals.FirstOrDefault(x => x.Id == 2), DateTime.Now, lista2, "265265");
            reporContratoTrabalho.Incluir(contrato2);

            List<Cargo> lista3 = new();
            lista3.Add(cargos.FirstOrDefault(x => x.Id == 1));
            lista3.Add(cargos.FirstOrDefault(x => x.Id == 2));
            lista3.Add(cargos.FirstOrDefault(x => x.Id == 3));
            ContratoTrabalho contrato3 = ContratoTrabalho.Contratar(3, regimeContratuals.FirstOrDefault(x => x.Id == 2), DateTime.Now, lista3, "98562677979");
            reporContratoTrabalho.Incluir(contrato3);
            return reporContratoTrabalho.Tabela();
        }

        private static List<Cliente> PreencherCliente(List<Contato> contatos)
        {
            DateTime nascimento = new(1986, 07, 19);
            Cliente cliente = Cliente.CriarCliente(1, "Fulano de Tal", "153.468.482-10", nascimento, contatos);
            reporCliente.Incluir(cliente);
            return reporCliente.Tabela();
        }

        private static List<Colaborador> PreencherColaborador(List<Contato> contatos, List<Servico> servicos,
            List<Endereco> enderecos, List<Genero> generos, List<ContratoTrabalho> contratoTrabalhos)
        {
            Colaborador colaborador = Colaborador.CriarColaborador(1, "Eduardo", "156.425.459-79", new DateTime(2005,10,25),
                contatos, servicos, enderecos.FirstOrDefault(x => x.Id == 1), generos.FirstOrDefault(x => x.Id == 2),
                "Eduardo Cerqueira", contratoTrabalhos.FirstOrDefault(x => x.Id == 1));
            reporColaborador.Incluir(colaborador);

            List<Servico> servicos1 = new List<Servico>();
            servicos1.Add(servicos.FirstOrDefault(x => x.Id == 2));
            servicos1.Add(servicos.FirstOrDefault(x => x.Id == 3));

            Colaborador colaborador2 = Colaborador.CriarColaborador(2, "Amanda", "248.001.459-05", new DateTime(2001,05,10),
                contatos, servicos1, enderecos.FirstOrDefault(x => x.Id == 1), generos.FirstOrDefault(x => x.Id == 2),
                "", contratoTrabalhos.FirstOrDefault(x => x.Id == 1));
            reporColaborador.Incluir(colaborador2);

            return reporColaborador.Tabela();
        }

        private static List<Escala> PeencherEscala(List<Colaborador> colaboradores)
        {
            Escala escala = Escala.GerarEscala(1, DateTime.Now, DateTime.Now, colaboradores.FirstOrDefault(x => x.Id == 1));
            reporEscala.Incluir(escala);
            return reporEscala.Tabela();
        }

        private static List<OrdemServico> PreencherOrdemServico(List<Cliente> clientes)
        {
            OrdemServico ordemServico = OrdemServico.AbrirOrdemServico(1, 120, clientes.FirstOrDefault(x => x.Id == 1), StatusOS.Pendente);
            reporOrdemServico.Incluir(ordemServico);
            return reporOrdemServico.Tabela();
        }

        private static OrdemServico PegarOrdemServico(int identificador)
        {
            return reporOrdemServico.PegarOrdemServico(identificador);
        }

        private static List<Agendamento> PreecherAgendamento(int id, Servico servico, Colaborador colaboradore,
            string pessoaAtendida, DateTime dataHora, OrdemServico ordensServico)
        {
            Agendamento agendamento = Agendamento.CriarAgendamento(id, servico, colaboradore,
                pessoaAtendida, dataHora, ordensServico, DateTime.Now);
            reporAgendamento.Incluir(agendamento);

            LogAgendamento logs = new();
            logs.DataCriacao = DateTime.Now;
            logs.Agendamento = agendamento;
            logs.Status = StatusAgendamento.Agendado;
            LogAgendamento.Add(logs);
            return reporAgendamento.Tabela();
        }
    }
}
