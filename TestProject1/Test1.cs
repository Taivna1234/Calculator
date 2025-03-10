using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using Calculator.Memory;
using System;
using System.Collections.Generic;

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
            memory.Clear();
        }

        [TestMethod]
        public void TestSaveFunctionality()
        {
            Memori memory = new Memori();
            BasicCalculator calc = new BasicCalculator(memory);

            calc.Add(15); 
            System.Threading.Thread.Sleep(100); 
            calc.Subtract(5); 
            System.Threading.Thread.Sleep(100); 
            calc.Add(10); 

            var items = memory.GetMemoryItems();
            Assert.AreEqual(3, items.Count);
            Assert.AreEqual(15, items[0].Value); 
            Assert.AreEqual(10, items[1].Value); 
            Assert.AreEqual(20, items[2].Value); 

            Assert.IsTrue(items[0].Timestamp < items[1].Timestamp);
            Assert.IsTrue(items[1].Timestamp < items[2].Timestamp);
        }

        [TestMethod]
        public void TestLastMemoryRetrieval()
        {
            Memori memory = new Memori();
            memory.Save(5);
            memory.Save(10);
            memory.Save(15);

            double? lastMemory = memory.GetLastMemory();

            Assert.AreEqual(15, lastMemory);
        }

        [TestMethod]
        public void TestLastMemoryWhenEmpty()
        {
            Memori memory = new Memori();

            double? lastMemory = memory.GetLastMemory();

            Assert.IsNull(lastMemory);
        }

        [TestMethod]
        public void TestMemoryItemTimestamp()
        {
            Memori memory = new Memori();
            DateTime beforeSave = DateTime.Now;
            memory.Save(10);
            DateTime afterSave = DateTime.Now;

            var items = memory.GetMemoryItems();

            Assert.AreEqual(1, items.Count);
            Assert.AreEqual(10, items[0].Value);
            Assert.IsTrue(items[0].Timestamp >= beforeSave);
            Assert.IsTrue(items[0].Timestamp <= afterSave);
        }
    }
}

