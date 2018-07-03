using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uniplac.Avaliacao.Dominio.Entidades;
using Uniplac.Avaliacao.Dominio.Excecoes;
using Uniplac.Avaliacao.Testes.Base;

namespace Uniplac.Avaliacao.Testes.DominioTestes
{
    [TestClass]
    public class QuartoTest
    {
        private Quarto _quarto;

        [TestInitialize]
        public void Inicializador()
        {
            _quarto = ConstrutorObjeto.CriarQuarto();
        }
        [TestMethod]
        public void Quarto_deve_ter_nome()
        {
            Assert.AreEqual("Basico", _quarto.Nome);
        }
        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        
        public void Quarto_deve_ter_um_valor()
        {
            _quarto.Valor = 0;

            _quarto.Validar();
        }



    }
}
