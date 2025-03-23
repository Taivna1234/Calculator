using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.Memory;

namespace Calculator
{
    /// <summary>
    /// `BasicCalculator` нь үндсэн тооцоолол болон санах ойн үйлдлүүдийг гүйцэтгэдэг анги юм.
    /// </summary>
    public class BasicCalculator : Calc, IOperationing
    {
        /// <summary>
        /// Санах ойн объект.
        /// </summary>
        private readonly Memori memory;

        /// <summary>
        /// Тооцооллын үр дүнг хадгалах хувьсагч.
        /// </summary>
        public new double Result;

        /// <summary>
        /// `BasicCalculator`-ийн анхны утга оноох конструктор. Шинэ `Memori` объект үүсгэнэ.
        /// </summary>
        public BasicCalculator() : this(new Memori()) { }

        /// <summary>
        /// `BasicCalculator`-ийг өгөгдсөн `Memori` объекттой хамт үүсгэнэ.
        /// </summary>
        /// <param name="mem">Санах ой хадгалах объект.</param>
        public BasicCalculator(Memori mem)
        {
            memory = mem;
        }

        /// <summary>
        /// Өгөгдсөн тоог үр дүнд нэмэх үйлдэл.
        /// </summary>
        /// <param name="number">Нэмэх тоо.</param>
        public void Add(double number)
        {
            Result += number;
        }

        /// <summary>
        /// Өгөгдсөн тоог үр дүнгээс хасах үйлдэл.
        /// </summary>
        /// <param name="number">Хасах тоо.</param>
        public void Subtract(double number)
        {
            Result -= number;
        }

        /// <summary>
        /// Санах ойд тоог хадгалах үйлдэл.
        /// </summary>
        /// <param name="number">Хадгалах тоо.</param>
        public void MS(double number)
        {
            var memoryItem = new MemoryItem(number);
            memory.Save(new MemoryItem(number));
        }

        /// <summary>
        /// Санах ойн сүүлийн утганд тоог нэмэх үйлдэл.
        /// </summary>
        /// <param name="number">Нэмэх тоо.</param>
        public void MPlus(double number, int ID)
        {
            memory.MPlus(number, ID); 
        }

        // Use the version with two parameters
        public void MMinus(double number, int ID)
        {
            memory.MMinus(number, ID); 
        }


        /// <summary>
        /// Санах ойн хамгийн сүүлийн утгыг авах функц.
        /// </summary>
        /// <returns>Санах ойн сүүлийн утга, эсвэл null.</returns>
        public double? GetLastMemory()
        {
            return memory.GetLastMemory()?.Value;
        }
        public List<MemoryItem> GetMemoryItems()
        {
            return memory.GetMemoryItems();
        }
        public void UpdateMemoryItem(double updatedValue)
        {
            // Get the last memory item and update its value
            var lastMemoryItem = memory.GetLastMemory();
            lastMemoryItem.Value = updatedValue; // Update the memory value
        }

        /// <summary>
        /// Санах ойг цэвэрлэх функц.
        /// </summary>
        public void ClearMemory()
        {
            memory.Clear();
        }
    }
}
