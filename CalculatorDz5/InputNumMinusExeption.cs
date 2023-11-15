using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDz5
{
    internal class InputNumMinusExeption : Exception
    {
        public InputNumMinusExeption() { }


        public InputNumMinusExeption(string message) : base(message) { }


    }
}
