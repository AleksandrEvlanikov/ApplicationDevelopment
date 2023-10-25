using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitLabyrinth
{
    public class Labyrinth
    {


            /*
            Есть лабиринт описанный в виде двумерного массива 
            где 1 это стены, 0 - проход, 2 - искомая цель.
            Пример лабиринта:
            1 1 1 1 1 1 1
            1 0 0 0 0 0 1
            1 0 1 1 1 0 1
            0 0 0 0 1 0 2
            1 1 0 0 1 1 1
            1 1 1 1 1 1 1
            1 1 1 1 1 1 1
            Напишите алгоритм определяющий наличие выхода из 
            лабиринта и выводящий на экран  координаты точки выхода если таковые имеются.
            */

            //Доработайте приложение поиска пути в лабиринте, но на этот раз вам нужно
            //    определить сколько всего выходов имеется в лабиринте:

            int[,] l = new int[,]
                {
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 0, 0, 0, 0, 0, 1 },
                {1, 0, 1, 1, 1, 0, 1 },
                {0, 0, 0, 0, 1, 0, 2 },
                {1, 1, 0, 0, 1, 1, 1 },
                {1, 1, 1, 0, 1, 1, 1 },
                {1, 1, 1, 2, 1, 1, 1 }
                };

        public bool HasExix(int startI, int startJ)
        {
            var stack = new Stack<Tuple<int, int>>();
            if (l[startI, startJ] == 0)
            {
                stack.Push(new Tuple<int, int>(startI, startJ));

            }
            else if (l[startI, startJ] == 1)
            {
                Console.WriteLine("Начальная точка находится в стене!");
                return false;
            }
            
            stack.Push(new(startI, startJ));

            int count = 0;
            List<Tuple<int, int>> path = new List<Tuple<int, int>>();
            while (stack.Count > 0)
            {
                var temp = stack.Pop();

                
                if (l[temp.Item1, temp.Item2] == 2)
                {
                    count++;
                    path.Add(temp);
                    Console.WriteLine($"Кординаты выхода = {temp}");
                }
                

                l[temp.Item1, temp.Item2] = 1;

                if (temp.Item2 > 0 && l[temp.Item1, temp.Item2 - 1] != 1)
                    stack.Push(new(temp.Item1, temp.Item2 - 1)); // вверх

                if (temp.Item2 + 1 < l.GetLength(1) && l[temp.Item1, temp.Item2 + 1] != 1)
                    stack.Push(new(temp.Item1, temp.Item2 + 1)); // низ

                if (temp.Item1 >= 0 && l[temp.Item1 - 1, temp.Item2] != 1)
                    stack.Push(new(temp.Item1 - 1, temp.Item2)); // лево

                if (temp.Item1 + 1 < l.GetLength(0) && l[temp.Item1 + 1, temp.Item2] != 1)
                    stack.Push(new(temp.Item1 + 1, temp.Item2)); // право
            }
            Console.WriteLine($"Выходы найдены! Их = {count}");
            return false;


        }
    }

}

