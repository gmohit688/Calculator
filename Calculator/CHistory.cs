using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class CHistory
    {
        public string Name { get; set; }
        public double firstNumber { get; set; }
        public double secondNumber { get; set; }
        public string stringOperation { get; set; }
        public string Phone { get; set; }
        public CHistory(double firstNum, double secondNum, string op)
        {
            firstNumber = firstNum;
            secondNumber = secondNum;
            stringOperation = op;
        }

    }
}
