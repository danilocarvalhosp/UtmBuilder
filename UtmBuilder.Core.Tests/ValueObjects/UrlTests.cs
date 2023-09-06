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
        private const string InvalidUrl = "banana";
        private const string ValidUrl = "https://balta.io";

        [TestMethod("Deve retornar uma exceção quando a URL for inválida")]
        [ExpectedException(typeof(InvalidUrlException))]
        public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
        {
            new Url(InvalidUrl);
        }

        [TestMethod("Não deve retornar uma exceção quando a URL for válida")]
        public void Dado_uma_url_valida_nao_deve_retornar_uma_excecao()
        {
            new Url(ValidUrl);
            Assert.IsTrue(true);
        }

        [TestMethod("Testando lançamento de exceção")]
        [DataRow(" ", true)]
        [DataRow("http", true)]
        [DataRow("banana", true)]
        [DataRow("https://balta.io", false)]
        public void TestUrl(string link, bool expectedException)
        {
            if(expectedException)
            {
                try
                {
                    new Url(link);
                    Assert.Fail();
                }
                catch (InvalidUrlException e)
                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                new Url(link);
                Assert.IsTrue(true);
            }
        }
    }
}
