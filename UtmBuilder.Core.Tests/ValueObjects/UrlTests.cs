using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        [TestMethod("Deve retornar uma exceção quando a URL for inválida")]
        [ExpectedException(typeof(InvalidUrlException))]
        public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
        {
            new Url("banana");
        }

        [TestMethod("Não deve retornar uma exceção quando a URL for válida")]
        public void Dado_uma_url_valida_nao_deve_retornar_uma_excecao()
        {
            new Url("https://balta.io");
            Assert.IsTrue(true);
        }
    }
}
