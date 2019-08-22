using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_Lesson_9.extension;

namespace Base_Lesson_9.Practice
{
    public static class Practice
    {
        /// <summary>
        /// L9-P-EX-1/2
        /// Создать структуру Coordinates (трехмерных). 
        /// Добавить экземплярный метод деконструкции значений координат.
        /// Вывести на консоль длину вектора по координатам.
        /// </summary>
        public static void L9_P_EX_1_from_2()
        {
            
        }

        





        /// <summary>
        /// L9-P-EX-2/2. 
        /// Создать деконструктор для обьекта DateTime 
        /// (год, месяц, день, час, минуты, секунды). 
        /// Получить и вывести на консоль текущее время.
        /// Использовать пустые параметры.
        /// </summary>
        public static void L9_P_EX_2_from_2()
        {
            //var p = new DateDeconstract();
           var p = DateTime.Now;
            var (_, _, _, hour, minute, second) = p;
            Console.WriteLine($"time {hour}:{minute}:{second}");
            Console.ReadLine();
        }

        //public class DateDeconstract
        //{
        //    int year = DateTime.Now.Year;
        //    int month = DateTime.Now.Month;
        //    int day = DateTime.Now.Day;
        //    int hour = DateTime.Now.Hour;
        //    int minute = DateTime.Now.Minute;
        //    int second = DateTime.Now.Second;

            


        //}

        

    }
}
