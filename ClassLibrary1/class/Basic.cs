using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.Memory;

namespace Calculator
{
    public class BasicCalculator : Calc, IOperationing
    {
        private Memori memory;

        public BasicCalculator(Memori mem)
        {
            memory = mem;
        }

        public void Add(double number)
        {
            Result += number;
            memory.Save(Result); 
        }

        public void Subtract(double number)
        {
            Result -= number;
            memory.Save(Result); 
        }
    }
}
