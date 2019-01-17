using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var p = new DateDeconstract();
            var (_, _, _, hour, minute, second) = p;
            Console.WriteLine($"time {hour}:{minute}:{second}");
            Console.ReadLine();
        }

        public class DateDeconstract
        {
            public int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            public void Deconstruct(out int year_1, out int month_1, out int day_1, out int hour_1, out int minute_1, out int second_1)
            {
                year_1 = year;
                month_1 = month;
                day_1 = day;
                hour_1 = hour;
                minute_1 = minute;
                second_1 = second;
            }

        }
    }
}
