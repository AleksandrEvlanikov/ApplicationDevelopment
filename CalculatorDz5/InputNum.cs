using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDz5
{
    public class InputNum
    {
        private double num;
        bool exitCalc = true;
        private Calc calc = new Calc();
        public double InputNumOne()
        {

            double inputOneNum = 0;

            while (exitCalc == true)
            {
                Console.Write("Введите 1 положительное число: ");
                bool ResultInput = calc.DoubleTryPars(Console.ReadLine(), out num);

                try
                {
                    if (num > 0)
                    {
                        inputOneNum = num;
                        exitCalc = false;
                    }
                    else
                    {
                        throw new InputNumMinusExeption("меньше 0");
                    }
                }
                catch (InputNumMinusExeption ex)
                {
                    Console.WriteLine($"Число {num} " + ex.Message);
                }
                
            }
            return inputOneNum;
        }
        public double InputNumTwo()
        {
            double inputTwoNum = 0;
            exitCalc = true;
            while (exitCalc == true)
            {

                Console.Write("Введите 2 положительное число: ");
                bool inputDuble = calc.DoubleTryPars(Console.ReadLine(), out num);
                try
                {
                    if (num > 0)
                    {
                        inputTwoNum = num;
                        exitCalc = false;
                    }
                    else
                    {
                        throw new InputNumMinusExeption("меньше 0");
                    }
                }
                catch (InputNumMinusExeption ex)
                {
                    Console.WriteLine($"Число {num} " + ex.Message);
                }

            }
            return inputTwoNum;
        }








    }
}
