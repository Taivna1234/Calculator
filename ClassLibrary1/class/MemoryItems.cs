using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Memory;
using Calculator;

namespace Calculator.Memory
{
    public class Memori
    {
        private List<MemoryItem> memoryItems = new List<MemoryItem>();

        public void Save(double value)
        {
            memoryItems.Add(new MemoryItem(value));
        }

        public void Clear()
        {
            memoryItems.Clear();
        }

        public List<MemoryItem> GetMemoryItems()
        {
            return memoryItems;
        }
        public double? GetLastMemory()
        {
            if (memoryItems.Count > 0)
            {
                return memoryItems.Last().Value; 
            }
            return null; 
        }

    }
}
