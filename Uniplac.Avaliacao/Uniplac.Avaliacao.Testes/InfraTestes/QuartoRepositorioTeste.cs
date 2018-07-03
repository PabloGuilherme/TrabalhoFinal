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
    public class QuartoRepositorioTeste
    {
        private AvaliacaoContexto _contextoTeste;
        private QuartoRepositorio _repositorio;
        private Quarto _quartoTest;

        [TestInitialize]
        public void Inicializador()
        {
            Database.SetInitializer(new InicializadorBanco<AvaliacaoContexto>());

            _contextoTeste = new AvaliacaoContexto();

            _repositorio = new QuartoRepositorio();

            _quartoTest = ConstrutorObjeto.CriarQuarto();

            _contextoTeste.Database.Initialize(true);
        }

        [TestMethod]
        public void Deveria_adicionar_um_novo_quarto()
        {
            //Preparação

            //Ação
            _repositorio.Adicionar(_quartoTest);

            //Afirmar
            var todosQuartos = _contextoTeste.Quartos.ToList();

            Assert.AreEqual(2, todosQuartos.Count);
        }

        [TestMethod]
        public void Deveria_editar_um_quarto()
        {
            //Preparação
            var quartoEditado = _contextoTeste.Quartos.Find(1);
            quartoEditado.Nome = "EDITADO";

            //Ação
            _repositorio.Editar(quartoEditado);

            //Afirmar
            var quartoBuscado = _contextoTeste.Quartos.Find(1);

            Assert.AreEqual("EDITADO", quartoBuscado.Nome);
        }

        [TestMethod]
        public void Deveria_deletar_um_quarto()
        {
            //Preparação
            var quartoDeletado = _contextoTeste.Quartos.Find(1);

            //Ação
            _repositorio.Deletar(quartoDeletado);

            //Afirmar
            var todosQuartos = _contextoTeste.Quartos.ToList();

            Assert.AreEqual(0, todosQuartos.Count);
        }

        [TestMethod]
        public void Deveria_buscar_quarto_por_id()
        {

            //Preparação

            //Ação
            var quartoBuscado = _repositorio.BuscarPor(1);

            //Afirmar

            Assert.IsNotNull(quartoBuscado);
        }

        [TestMethod]
        public void Deveria_buscar_todos_os_quartos()
        {
            //Preparação

            //Ação
            var quartoBuscado = _repositorio.BuscarTudo();

            //Afirmar

            Assert.IsNotNull(quartoBuscado);
        }

        [TestMethod]
        public void Deveria_buscar_quarto_por_nome()
        {
            //Preparação

            //Ação
            var quartoBuscado = _repositorio.BuscarPorNome("Basico");

            //Afirmar

            Assert.IsNotNull(quartoBuscado);
        }
    }
}
