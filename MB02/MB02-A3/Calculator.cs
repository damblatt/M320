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

        public int Addition(params int[] parameters)
        {
            if(parameters.Length == 1)
            {
                TempResult += parameters[0];
            }
            else if(parameters.Length >= 2)
            {
                TempResult = 0;
                foreach(var parameter in parameters)
                {
                    TempResult += parameter;
                }
            }
            return TempResult;
        }

        public int Subtraction(params int[] parameters)
        {
            if (parameters.Length == 1)
            {
                TempResult -= parameters[0];
            }
            else if (parameters.Length >= 2)
            {
                TempResult = parameters[0] * 2;     // da in der foreach schleife, der erste parameter ebenfalls subtrahiert wird, wird hier mal 2 gerechnet
                foreach (var parameter in parameters)
                {
                    TempResult -= parameter;
                }
            }
            return TempResult;
        }

        public int Multiplication(params int[] parameters)
        {
            if (parameters.Length == 1)
            {
                TempResult *= parameters[0];
            }
            else if (parameters.Length >= 2)
            {
                TempResult = 1;
                foreach (var parameter in parameters)
                {
                    TempResult *= parameter;
                }
            }
            return TempResult;
        }

        public int Division(params int[] parameters)
        {
            if (parameters.Length == 1)
            {
                TempResult /= parameters[0];
            }
            else if (parameters.Length >= 2)
            {
                TempResult = parameters[0] * parameters[0];     // da in der foreach schleife, der erste parameter ebenfalls dividiert wird, wird hier hoch 2 gerechnet
                foreach (var parameter in parameters)
                {
                    TempResult /= parameter;
                }
            }
            return TempResult;
        }
    }
}
