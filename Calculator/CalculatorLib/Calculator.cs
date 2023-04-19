using System;
using CalculatorLib;
using System.Collections.Generic;
using System.Data;

namespace CalculatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> expressions = new List<string>() { "15+5", "15-5/2", "2*3-1/5+8", "4+2C2+3" };
            List<decimal?> results = new List<decimal?>();

            foreach (string expression in expressions)
            {
                decimal? result = Calculate(expression);

                if (expression.EndsWith("C"))
                {
                    Console.Clear();
                }

                results.Add(result);
            }

            Console.WriteLine("Expressions:\tResults:");

            for (int i = 0; i < expressions.Count; i++)
            {
                Console.WriteLine($"{expressions[i]}\t=\t{results[i]}");
            }
        }



        static decimal? Calculate(string expression)
        {
            Console.Write(expression);
            Console.Write("=");

            var calculator = new Calculator();

            foreach (var c in expression)
            {
                calculator.KeyPress(c);
            }

            return calculator.Result;
        }
    }
}



namespace CalculatorLib
{
    public class Calculator
    {
        private string _result = null;
        public void KeyPress(char key)
        {
            if (key == 'C')
            {
                _result = null;
            }
            else if (key == '=')
            {
                if (_result == null) return;

                try
                {
                    _result = new DataTable().Compute(_result, null).ToString();
                }
                catch (Exception)
                {
                    _result = null;
                }
            }
            else
            {
                if (_result == null)
                {
                    _result = key.ToString();
                }
                else
                {
                    _result += key.ToString();
                }
            }
        }

        public decimal? Result
        {
            get
            {
                if (_result == null) return null;

                decimal result;
                if (decimal.TryParse(_result, out result))
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}