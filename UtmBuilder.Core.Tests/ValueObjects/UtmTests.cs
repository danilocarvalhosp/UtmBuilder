using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class UtmTests
    {
        private const string Result = "https://balta.io/" +
                                        "?utm_source=src" +
                                        "&utm_medium=med" +
                                        "&utm_campaign=name" +
                                        "&utm_id=id" +
                                        "&utm_term=term" +
                                        "&utm_content=cnt";
        private readonly Url Url = new("https://balta.io/");
        private readonly Campaign Campaign = new(
            "src", "med", "name", "id", "term", "cnt");

        [TestMethod]
        public void ShoudReturnUrlFromUtm()
        {
            var utm = new Utm(Url, Campaign);

            Assert.AreEqual(Result, utm.ToString());
            Assert.AreEqual(Result, (string)utm);
        }

        [TestMethod]
        public void ShoudReturnUtmFromUrl()
        {
            Utm utm = Result;
            Assert.AreEqual("https://balta.io/", utm.Url.Address);
            Assert.AreEqual("src", utm.Campaign.Source);
            Assert.AreEqual("med", utm.Campaign.Medium);
            Assert.AreEqual("name", utm.Campaign.Name);
            Assert.AreEqual("id", utm.Campaign.Id);
            Assert.AreEqual("term", utm.Campaign.Term);
            Assert.AreEqual("cnt", utm.Campaign.Content);
        }
    }
}
