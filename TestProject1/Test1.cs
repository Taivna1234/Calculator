using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using Calculator.Memory;
using System;
using System.Collections.Generic;
using System.Threading;

namespace TestProject1
{
    /// <summary>
    /// BasicCalculator-ийн нэгжийн тестүүдийг агуулсан класс.
    /// </summary>
    [TestClass]
    public sealed class Test1
    {
        /// <summary>
        /// Нэмэх үйлдлийг шалгах тест.
        /// </summary>
        [TestMethod]
        public void TestAddition()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.Add(10);
            Assert.AreEqual(10, calc.Result);
        }

        /// <summary>
        /// Хасах үйлдлийг шалгах тест.
        /// </summary>
        [TestMethod]
        public void TestSubtraction()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.Add(10);
            calc.Subtract(4);
            Assert.AreEqual(6, calc.Result);
        }

        /// <summary>
        /// Санах ойд хадгалах үйлдлийг шалгах тест.
        /// </summary>
        [TestMethod]
        public void TestMemorySave()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.MS(10);
            Assert.AreEqual(10, calc.GetLastMemory());

            calc.MS(20);
            Assert.AreEqual(20, calc.GetLastMemory());
        }

        /// <summary>
        /// Санах ойд нэмэх (M+) үйлдлийг шалгах тест.
        /// </summary>
        [TestMethod]
        public void TestMemoryAddition()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.MS(10);
            calc.MPlus(5);
            Assert.AreEqual(15, calc.GetLastMemory());

            calc.MPlus(10);
            Assert.AreEqual(25, calc.GetLastMemory());
        }

        /// <summary>
        /// Санах ойгоос хасах (M-) үйлдлийг шалгах тест.
        /// </summary>
        [TestMethod]
        public void TestMemorySubtraction()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.MS(20);
            calc.MMinus(5);
            Assert.AreEqual(15, calc.GetLastMemory());

            calc.MMinus(10);
            Assert.AreEqual(5, calc.GetLastMemory());
        }

        /// <summary>
        /// Санах ойн хамгийн сүүлийн хадгалсан утгыг шалгах тест.
        /// </summary>
        [TestMethod]
        public void TestLastMemoryRetrieval()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.MS(5);
            calc.MS(10);
            calc.MS(15);

            Assert.AreEqual(15, calc.GetLastMemory());
        }

        /// <summary>
        /// Хоосон үед санах ойн утга null эсэхийг шалгах тест.
        /// </summary>
        [TestMethod]
        public void TestLastMemoryWhenEmpty()
        {
            BasicCalculator calc = new BasicCalculator();
            Assert.IsNull(calc.GetLastMemory());
        }

        /// <summary>
        /// Санах ойг цэвэрлэх үйлдлийг шалгах тест.
        /// </summary>
        [TestMethod]
        public void TestMemoryClear()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.MS(50);
            Assert.AreEqual(50, calc.GetLastMemory());

            calc.ClearMemory();
            Assert.IsNull(calc.GetLastMemory());
        }

        /// <summary>
        /// Санах ойд хадгалах үеийн огноог шалгах тест.
        /// </summary>
        [TestMethod]
        public void TestMemoryItemTimestamp()
        {
            BasicCalculator calc = new BasicCalculator();
            DateTime beforeSave = DateTime.Now;
            calc.MS(10);
            DateTime afterSave = DateTime.Now;

            var items = calc.GetLastMemory();
            Assert.AreEqual(10, items);
            Assert.IsTrue(beforeSave <= afterSave);
        }

        /// <summary>
        /// Тооцооллын үр дүнг хадгалах үйлдлийг шалгах тест.
        /// </summary>
        [TestMethod]
        public void TestSaveFunctionality()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.Add(15);
            Thread.Sleep(100);
            calc.Subtract(5);
            Thread.Sleep(100);
            calc.Add(10);

            Assert.AreEqual(20, calc.GetLastMemory());
        }
    }
}

