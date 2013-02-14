using System;
using System.Text;
using FileHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolishGrammarOperations.Tests
{
    /// <summary>
    ///This is a test class for VocativerTest and is intended
    ///to contain all VocativerTest Unit Tests
    ///</summary>
    [TestClass]
    public class VocativerTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        [DeploymentItem("imiona.csv", "")]
        public void TranslateTestFromFile()
        {
            var engine = new FileHelperEngine(typeof(VocativerTestRow)) {Encoding = Encoding.UTF8};
            var testData = engine.ReadFile("imiona.csv") as VocativerTestRow[];
            var failed = 0;

            foreach (var testRow in testData)
            {
                var expected = testRow.Vocative;
                var actual = Vocativer.Translate(testRow.Nominative);

                if(actual != expected)
                {
                    Console.WriteLine(@"{0} => {1} != {2}", testRow.Nominative, expected, actual);
                    failed++;
                }
            }

            if(failed > 0)
                Assert.Fail("{0} failed", failed);
        }

        [DelimitedRecord(";")] 
        private class VocativerTestRow
        {
            [FieldQuoted('"')]
            public string Nominative;
            [FieldQuoted('"')]
            public string Vocative;
        }
    }
}
