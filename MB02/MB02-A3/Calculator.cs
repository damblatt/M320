using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB02_A3
{
    public class Calculator
    {
        private int TempResult { get; set; } = 0;       // interne speicherung?

        public int Addition(int firstParam, int secondParam)
        {

            TempResult = firstParam + secondParam;
            return TempResult;
        }

        public int Addition(int secondParam)
        {
            TempResult += secondParam;
            return TempResult;
        }

        public int Subtraction(int firstParam, int secondParam)
        {
            TempResult = firstParam - secondParam;
            return TempResult;
        }

        public int Subtraction(int secondParam)
        {
            TempResult -= secondParam;
            return TempResult;
        }

        public int Multiplication(int firstParam, int secondParam)
        {
            TempResult = firstParam * secondParam;
            return TempResult;
        }

        public int Multiplication(int secondParam)
        {
            TempResult *= secondParam;
            return TempResult;
        }

        public int Division(int firstParam, int secondParam)
        {
            TempResult = firstParam / secondParam;
            return TempResult;
        }

        public int Division(int secondParam)
        {
            TempResult /= secondParam;
            return TempResult;
        }
    }
}
