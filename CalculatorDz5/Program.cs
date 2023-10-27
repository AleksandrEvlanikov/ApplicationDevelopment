using System.Runtime.CompilerServices;

namespace CalculatorDz5
{
    internal class Program
    {

        delegate void myDelegate(string message);
        private static void Main(string[] args)
        {
            var calc = new Calc();
            calc.MyEventHandler += Calc_MyEventHandler;
            
            Console.Write("Введите 1 число: ");
            double ResultInput = double.Parse(Console.ReadLine());
            calc.Result = ResultInput;
            Console.Write("Введите 2 число: ");
            int x = int.Parse(Console.ReadLine());

            

            bool exitCalc = true;
            while(exitCalc == true)
            {
                Console.WriteLine("Выбери действие");
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. *");
                Console.WriteLine("4. /");
                Console.WriteLine("5. Выход");
                int inputD = int.Parse(Console.ReadLine());

                switch (inputD)
                {
                    case 1:
                        Console.WriteLine($"{calc.Result} + {x}");
                        calc.Sum(x);
                        break;
                    case 2:
                        Console.WriteLine($"{calc.Result} - {x}");
                        calc.Sub(x);
                        break;
                    case 3:
                        Console.WriteLine($"{calc.Result} * {x}");
                        calc.Multy(x);
                        break;
                    case 4:
                        Console.WriteLine($"{calc.Result} / {x}");
                        calc.Divide(x);
                        break;
                    case 5:
                        Console.WriteLine($"Выход.");
                        exitCalc = false;
                        break;

                }
            }


            //calc.Sum(10);
            //calc.Sub(1);
            //calc.Multy(5);
            //calc.Divide(3);
            //calc.CancelLast();
            //calc.CancelLast();
            //calc.CancelLast();
            //calc.CancelLast();
            //calc.CancelLast();
        }

        private static void Calc_MyEventHandler(object? sender, EventArgs e)
        {
            if (sender is Calc)
                Console.WriteLine($"Ответ = {((Calc)sender).Result}");
        }

        //Спроектируем интерфейс калькулятора, поддерживающего простые
        //арифметические действия, хранящего результат и также способного
        //выводить информацию о результате  при помощи события




        //static void Task2(List<myDelegate> delegateList)
        //{
        //    delegateList.ForEach(x => x("Привет"));
        //}


        //Создайте метод, который принимает список действий(делегат Action)
        //и выполняет их последовательно.

        //public static void Task1(List<Action> actions)
        //{
        //    actions.ForEach(action => Console.WriteLine());
        //}

        //public static void Print()
        //{
        //    Console.WriteLine("Print");
        //}

        //public static void PrintSecond() { Console.WriteLine(); }

    }
}