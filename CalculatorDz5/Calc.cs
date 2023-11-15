using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDz5
{
    public class Calc : ICalc
    {

        public double Result { get; set; } = 0;
        //private Stack<double> LastResult { get; set; } = new Stack<double>();
        
        public event EventHandler<EventArgs> MyEventHandler;
        //InputNum inputNum = new InputNum();

        private void PrintResult()
        {
            MyEventHandler?.Invoke(this, new EventArgs());
        }

        

        public void Divide(double x)
        {
            Result /= x;
            PrintResult();
            //LastResult.Push(Result);
        }

        public void Multy(double x)
        {
            Result *= x;
            PrintResult();
            //LastResult.Push(Result);
        }

        public void Sub(double x)
        {
            try
            {
                
                if (Result - x < 0)
                {
                    Console.WriteLine("Результат не может быть отрицательный.");
                    Console.WriteLine("Попробуйте еще раз. ");

                }
                else
                {
                    Result -= x;
                    PrintResult();
                }

            }
            catch(InputNumMinusExeption e)
            {
                Console.WriteLine($"Результат {Result} " + e.Message);
            }

            
            //LastResult.Push(Result);
        }

        public void Sum(double x)
        {
            Result += x;
            PrintResult();
            //LastResult.Push(Result);
        }


        public bool DoubleTryPars(string input, out double num)
        {
            num = 0;
            try
            {
                num = Convert.ToDouble(input);

            }
            catch(FormatException e)
            {
                Console.WriteLine("Неверный формат ввода -> " + e);
                return false;
            }
            return true;
        }

        //public void CancelLast()
        //{
        //    if (LastResult.TryPop(out double res))
        //    {
        //        Result = res;
        //        Console.WriteLine("Последнее действие отменено. Результат равен:");
        //        PrintResult();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Невозможно отменить послдеднее действие!");
        //    }
        //}
    }
}
//Арифметические методы должны выполняться как обычно а метод
//CancelLast должен отменять последнее действие. При этом метод
//может отменить последовательно все действия вплоть до самого
//последнего. Спросите как студенты планируют реализовать отмену
//действия и если будут трудности с ответами то подскажите им про стек

