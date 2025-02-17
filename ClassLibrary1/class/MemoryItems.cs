using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Memory;

namespace CustomCalculator
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

    public void PrintMemory()
    {
        Console.WriteLine("Memory:");
        foreach (var item in memoryItems)
        {
            Console.WriteLine($"Value: {item.Value}, Saved at: {item.Timestamp}");
        }
    }
        public List<MemoryItem> GetMemoryItems()
        {
            return memoryItems;
        }

    }
}
