using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNumbersDz4
{
    //Дан массив и число.Найдите три числа в массиве сумма которых равна искомому числу.Подсказка: если взять первое число в массиве, 
    //    можно ли найти в оставшейся его части два числа равных по сумме первому.
    public class ArrayNumberFind
    {
        public void FindTarget(int target, int[] arr)
        {

            HashSet<int> setArr = new HashSet<int>();

            int theeArr;
            foreach (var item0 in arr)
            {
                foreach (var item1 in arr)
                {
                    if (setArr.Contains(target - item0 - item1))
                    {
                        Console.WriteLine($"{target - item0 - item1} {item0} {item1} ");
                        return;
                    }   
                }
                setArr.Add(item0);
            }
            Console.WriteLine("Число не найдено");
        } 
    }
}
