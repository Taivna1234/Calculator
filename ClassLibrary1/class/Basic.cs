using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.IOperation;

namespace Calculator.Basic;
public class BasicCalculator:Calc, IOperationing
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