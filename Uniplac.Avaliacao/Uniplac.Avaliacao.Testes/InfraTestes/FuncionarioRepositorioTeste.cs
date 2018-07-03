using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uniplac.Avaliacao.Dominio.Entidades;
using Uniplac.Avaliacao.Infra.Dados.Contexto;
using Uniplac.Avaliacao.Infra.Dados.Repositorios;
using Uniplac.Avaliacao.Testes.Base;

namespace Uniplac.Avaliacao.Testes.InfraTestes
{
    [TestClass]
    public class FuncionarioRepositorioTeste
    {
        private AvaliacaoContexto _contextoTeste;
        private FuncionarioRepositorio _repositorio;
        private Funcionario _funcionarioTest;

        [TestInitialize]
        public void Inicializador()
        {
            Database.SetInitializer(new InicializadorBanco<AvaliacaoContexto>());

            _contextoTeste = new AvaliacaoContexto();

            _repositorio = new FuncionarioRepositorio();

            _funcionarioTest = ConstrutorObjeto.CriarFuncionario();

            _contextoTeste.Database.Initialize(true);
        }

        [TestMethod]
        public void Deveria_adicionar_um_novo_funcionario()
        {
            //Preparação

            //Ação
            _repositorio.Adicionar(_funcionarioTest);

            //Afirmar
            var todosFuncionarios = _contextoTeste.Funcionarios.ToList();

            Assert.AreEqual(2, todosFuncionarios.Count);
        }

        [TestMethod]
        public void Deveria_editar_um_funcionario()
        {
            //Preparação
            var funcionarioEditado = _contextoTeste.Funcionarios.Find(1);
            funcionarioEditado.Nome = "EDITADO";

            //Ação
            _repositorio.Editar(funcionarioEditado);

            //Afirmar
            var funcionarioBuscado = _contextoTeste.Funcionarios.Find(1);

            Assert.AreEqual("EDITADO", funcionarioBuscado.Nome);
        }

        [TestMethod]
        public void Deveria_deletar_um_funcionario()
        {
            //Preparação
            var funcionarioDeletado = _contextoTeste.Funcionarios.Find(1);

            //Ação
            _repositorio.Deletar(funcionarioDeletado);

            //Afirmar
            var todosFuncionarios = _contextoTeste.Funcionarios.ToList();

            Assert.AreEqual(0, todosFuncionarios.Count);
        }

        [TestMethod]
        public void Deveria_buscar_funcionario_por_id()
        {

            //Preparação

            //Ação
            var funcionarioBuscado = _repositorio.BuscarPor(1);

            //Afirmar

            Assert.IsNotNull(funcionarioBuscado);
        }

        [TestMethod]
        public void Deveria_buscar_todos_os_funcionarios()
        {
            //Preparação

            //Ação
            var funcionarioBuscado = _repositorio.BuscarTudo();

            //Afirmar

            Assert.IsNotNull(funcionarioBuscado);
        }

        [TestMethod]
        public void Deveria_buscar_funcionario_por_nome()
        {
            //Preparação

            //Ação
            var funcionarioBuscado = _repositorio.BuscarPorNome("Pablo");

            //Afirmar

            Assert.IsNotNull(funcionarioBuscado);
        }
    }
}

