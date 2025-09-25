using System;
using DZ02.Enums;
using DZ02.Structs;
class Tumakov
{
    static void Main()
    {
        Bankaccount a = Bankaccount.Savings;
        Bankaccount b = Bankaccount.Current;
        Console.WriteLine($"Задание 3.1:\nТипы банковского счета:{a},{b}");
        BankAccount acc = new BankAccount(
            accountNumber: "777",
            accountType: "Сберегательный",
            balance: 1000.50m
            );

        Console.WriteLine($"Задание 3.2:\nНомер счета:{acc.AccountNumber}\nТип счета:{acc.AccountType}\nБаланс:{acc.Balance:C}");
        Student student1 = new Student("Николай Герасимов", ВУЗ.КГУ);
        Student student2 = new Student("Анна Бусова", ВУЗ.КАИ);
        Student student3 = new Student("Иван Гущин", ВУЗ.КХТИ);
        Console.WriteLine($"Задание 3.1:\nИмя:{student1.Name}\nВУЗ:{student1.University}");
        Console.WriteLine($"Имя:{student2.Name}\nВУЗ:{student2.University}");
        Console.WriteLine($"Имя:{student3.Name}\nВУЗ:{student3.University}");


    }
}



