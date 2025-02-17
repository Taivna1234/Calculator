using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.IOperation;

namespace Calculator.Basic;
internal class BasicCalculator:Calc, IOperations
{
    public void Add(double number)
    {
        Result += number;
    }

    public void Subtract(double number)
    {
        Result -= number;
    }
}