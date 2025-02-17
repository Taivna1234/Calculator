using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Memory;
 public class MemoryItem
{
    public double Value { get; }
    public DateTime Timestamp { get; }

    public MemoryItem(double value)
    {
        Value = value;
        Timestamp = DateTime.Now;
    }
}
