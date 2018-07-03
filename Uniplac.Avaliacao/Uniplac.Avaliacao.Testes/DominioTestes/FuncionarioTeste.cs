using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uniplac.Avaliacao.Dominio.Entidades;
using Uniplac.Avaliacao.Dominio.Excecoes;
using Uniplac.Avaliacao.Testes.Base;

namespace Uniplac.Avaliacao.Testes.DominioTestes
{
    [TestClass]
    public class FuncionarioTeste
    {
        private Funcionario _funcionario;

        [TestInitialize]
        public void Inicializador()
        {
            _funcionario = ConstrutorObjeto.CriarFuncionario();
        }
        [TestMethod]
        public void Funcionario_deve_ter_nome()
        {
            Assert.AreEqual("Pablo", _funcionario.Nome);
        }
        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Funcionario_deve_ter_um_cargo()
        {
            _funcionario.Cargo = "";

            _funcionario.Validar();
        }
        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Funcionario_deve_ter_CPF_valido()
        {
            var _funcionario = ConstrutorObjeto.CriarFuncionario();

            _funcionario.CPF = "";

            _funcionario.Validar();
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Funcionario_deve_ter_salario_valido()
        {
            var _funcionario = ConstrutorObjeto.CriarFuncionario();

            _funcionario.Salario = 0;

            _funcionario.Validar();
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Funcionario_deve_ter_data_nascimento_valido()
        {
            var _funcionario = ConstrutorObjeto.CriarFuncionario();

            _funcionario.DataNascimento = new DateTime(0001, 01, 01);

            _funcionario.Validar();
        }
        [TestMethod]
        [ExpectedException(typeof(DominioException))]

        public void Funcionario_deve_ter_cliente_valido()
        {
            var _funcionario = ConstrutorObjeto.CriarFuncionario();

            _funcionario.Cliente = null;
            _funcionario.Validar();
        }
    }
    }

