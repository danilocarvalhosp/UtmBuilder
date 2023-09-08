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
        [TestMethod]
        public void ShoudReturnUrlFromUtm()
        {
            var url = new Url("https://balta.io/");
            var campaign = new Campaign("src", "med", "name", "id", "term", "cnt");
            var utm = new Utm(url, campaign);

            var result = "https://balta.io/" + 
                                            "?utm_source=src" +
                                            "&utm_medium=med" +
                                            "&utm_campaign=name" +
                                            "&utm_id=id" +
                                            "&utm_term=term" +
                                            "&utm_content=cnt";
            Assert.AreEqual(result, utm.ToString());
        }
    }
}
