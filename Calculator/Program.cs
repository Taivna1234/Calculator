using System;
using Calculator;
using Calculator.Memory;
class Programm
{
    static void Main()
    {
        BasicCalculator calc = new BasicCalculator();
        Memori memory = new Memori();

        calc.Add(10);
        Console.WriteLine($"Result after addition: {calc.Result}");
        

        calc.Subtract(4);
        Console.WriteLine($"Result after subtraction: {calc.Result}");
        

    }
}