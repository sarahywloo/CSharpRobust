using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PreventXSS;

namespace PreventXSSWithTests.Test {
    [TestClass]
    public class PreventXSSTests {
        [TestMethod]
        public void TestMethod1() {

            var testing = new Security();

            string badScript = "<b>hello</b><script>evil</script>";

            var testSanitize = testing.SanitizeHTML(badScript, "<b></b>");

            Assert.AreEqual("<b>hello</b>&lt;script&gt;evil&lt;script&gt;", testSanitize);

        }
    }
}
