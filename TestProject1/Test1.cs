using System;
using Calculator.Basic;
using CustomCalculator;

namespace TestProject1
{
    namespace TestProject1
    {
        [TestClass]
        public sealed class Test1
        {
            [TestMethod]
            public void TestAddition()
            {
                BasicCalculator calc = new BasicCalculator();
                calc.Add(10);
                Assert.AreEqual(10, calc.Result);
            }

            [TestMethod]
            public void TestSubtraction()
            {
                BasicCalculator calc = new BasicCalculator();
                calc.Add(10);
                calc.Subtract(4);
                Assert.AreEqual(6, calc.Result);
            }

            [TestMethod]
            public void TestMemory()
            {
                Memori memory = new Memori();
                memory.Save(10);
                memory.Save(6);
                var items = memory.GetMemoryItems();
                Assert.AreEqual(2, items.Count);
                Assert.AreEqual(10, items[0].Value);
                Assert.AreEqual(6, items[1].Value);
            }
        }
    }
}
