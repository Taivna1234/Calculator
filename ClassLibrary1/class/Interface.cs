using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Basic;

namespace Calculator.IOperation;
internal interface IOperation
{
    void Add(double number);
    void Subtract(double number);
}
