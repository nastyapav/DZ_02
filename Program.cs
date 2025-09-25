using System;
using System.Xml.Linq;
using ConsoleApp1.Enums;
using ConsoleApp1.Structs;
namespace Type
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 1:\nИнформация о типах данных:");
            Console.WriteLine($"sbyte       – {sbyte.MaxValue} – {sbyte.MinValue}");
            Console.WriteLine($"byte        – {byte.MaxValue} – {byte.MinValue}");
            Console.WriteLine($"short       – {short.MaxValue} – {short.MinValue}");
            Console.WriteLine($"ushort      – {ushort.MaxValue} – {ushort.MinValue}");
            Console.WriteLine($"int         – {int.MaxValue} – {int.MinValue}");
            Console.WriteLine($"uint        – {uint.MaxValue} – {uint.MinValue}");
            Console.WriteLine($"long        – {long.MaxValue} – {long.MinValue}");
            Console.WriteLine($"ulong       – {ulong.MaxValue} – {ulong.MinValue}");
            Console.WriteLine($"float       – {float.MaxValue} – {float.MinValue}");
            Console.WriteLine($"double      – {double.MaxValue} – {double.MinValue}");
            Console.WriteLine($"decimal     – {decimal.MaxValue} – {decimal.MinValue}");
            Console.Write($"\nЗадание 2:\nВведите имя:");
            string a = Console.ReadLine();
            Console.Write($"Введите город:");
            string b = Console.ReadLine();
            Console.Write($"Введите возраст:");
            string c = Console.ReadLine();
            int d;
            if (!int.TryParse(c, out d))
            {
                Console.WriteLine("Ошибка: возраст должен быть числом.");
                Console.WriteLine("Нажмите любую клавишу для выхода...");
            }
            Console.Write("Введите PIN-код: ");
            string e = Console.ReadLine();
            Console.WriteLine($"Информация пользователя:\nИмя:{a}\nГород:{b}\nВозраст:{c}\nPIN-код:{e}");
            Console.Write("\nЗадание 3:\nВведите строку: ");
            string input = Console.ReadLine();
            string result = "";
            foreach (char f in input)
            {
                if (char.IsUpper(f))
                {
                    result += char.ToLower(f);
                }
                else if (char.IsLower(f))
                {
                    result += char.ToUpper(f);
                }
                else
                {
                    result += f;
                }
            }
            Console.WriteLine("Результат:" + result);
            Console.Write("\nЗадание 4:\nВведите строку:");
            string x = Console.ReadLine();
            Console.Write("Введите подстроку:");
            string y = Console.ReadLine();
            int count = 0;
            int index = 0;
            while (true)
            {
                int found = x.IndexOf(y, index);
                if (found == -1)
                    break;
                count++;
                index = found + 1;
            }
            Console.WriteLine("Количество вхождений:" + count);
            Console.WriteLine("\n\nЗадание 5:\nВведите через Enter:обычную цену за бутылку/скидку в %/ стоимость отпуска");
            int normPrice = int.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());
            int holidayPrice = int.Parse(Console.ReadLine());
            int salePrice = normPrice - (normPrice * discountPercent) / 100;
            int save = normPrice - salePrice;
            int bottles = holidayPrice / save;
            Console.WriteLine($"Количество бутылок c экономии на отпуск: {bottles}");
            Console.WriteLine("\nЗадание 6:");
            DrinkType drink1 = new DrinkType("Водка", 40.0);
            Student student1 = new Student("Иванов", "Иван", 1, new DateTime(2000, 5, 15),
                AlcoholismCategory.Alcoholic, drink1, 1.5);
            DrinkType drink2 = new DrinkType("Пиво", 5.0);
            Student student2 = new Student("Петров", "Петр", 2, new DateTime(2001, 3, 22),
                AlcoholismCategory.NonAlcoholicButDrinks, drink2, 3.0);
            DrinkType drink3 = new DrinkType("Шампанское", 12.0);
            Student student3 = new Student("Сидорова", "Анна", 3, new DateTime(1999, 11, 8),
                AlcoholismCategory.DrinksOnHolidays, drink3, 0.75);
            DrinkType drink4 = new DrinkType("Минералка", 0.0);
            Student student4 = new Student("Козлов", "Дмитрий", 4, new DateTime(2002, 7, 30),
                AlcoholismCategory.Abstinent, drink4, 2.0);
            DrinkType drink5 = new DrinkType("Виски", 43.0);
            Student student5 = new Student("Морозова", "Елена", 5, new DateTime(2000, 1, 10),
                AlcoholismCategory.Alcoholic, drink5, 0.5);
            Student[] students = new Student[5];
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;
            students[3] = student4;
            students[4] = student5;
            double totalVolume = 0;
            double totalAlcoholVolume = 0;
            Console.WriteLine("Список студентов:");
            int i = 0;
            while (i < students.Length)
            {
                Console.WriteLine(students[i]);
                totalVolume += students[i].VolumeConsumed;
                totalAlcoholVolume += students[i].GetAlcoholVolume();
                i++;
            }
            Console.WriteLine("\nСтатистика:");
            Console.WriteLine("Общий объем выпитой жидкости:" + totalVolume.ToString("F2") + " л");
            Console.WriteLine("Общий объем алкоголя (спирта):" + totalAlcoholVolume.ToString("F2") + " л");

            if (totalVolume > 0)
            {
                double alcoholPercentage = (totalAlcoholVolume / totalVolume) * 100;
                Console.WriteLine("Процент алкоголя от общего объема: " + alcoholPercentage.ToString("F2") + "%");
            }
            else
            {
                Console.WriteLine("Ничего не выпили.");
            }




        }
    }


}
   




     
