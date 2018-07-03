using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uniplac.Avaliacao.Dominio.Entidades;
using Uniplac.Avaliacao.Dominio.Excecoes;
using Uniplac.Avaliacao.Testes.Base;

namespace Uniplac.Avaliacao.Testes.DominioTestes
{
    [TestClass]
    public class ClienteTeste
    {
        private Cliente _cliente;

        [TestInitialize]
        public void Inicializador()
        {
            _cliente = ConstrutorObjeto.CriarCliente();
        }
        [TestMethod]
        public void Cliente_deve_ter_nome()
        {
            Assert.AreEqual("Guilherme", _cliente.Nome);
        }
        [TestMethod]
        [ExpectedException(typeof(DominioException))]
       
        
        public void Cliente_deve_ter_CPF_valido()
        {
            var _cliente = ConstrutorObjeto.CriarCliente();

            _cliente.CPF = "";

            _cliente.Validar();
        }


        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Cliente_deve_ter_data_nascimento_valido()
        {
            var _cliente = ConstrutorObjeto.CriarCliente();

            _cliente.DataNascimento = new DateTime(0001, 01, 01);

            _cliente.Validar();
        }
        

       
    }
}
