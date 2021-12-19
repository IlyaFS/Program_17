using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount<int> bankAccount = new BankAccount<int>(10, "Депозит", 1000, "Petya");
            Console.WriteLine("Информация о счете:");
            bankAccount.Print();
            Console.WriteLine();
            BankAccount<string> bankAccount2 = new BankAccount<string>("10EF-2", "Кредит", 50, "Vasya");
            Console.WriteLine("Информация о счете:");
            bankAccount2.Print();

            Console.ReadKey();
        }
    }
       class BankAccount<T>
    {
        public T AccountNumber { get; private set; }
        public string AccountType { get; private set; }
        public decimal AccountBalance { get; private set; }
        public string AccountOwner { get; private set; }
        public BankAccount(T number, string type, decimal balans, string owner)
        {
            AccountType = type;
            AccountNumber = number;
            AccountBalance = balans;
            AccountOwner = owner;
        }
        public void Print()
        {
            Console.WriteLine("Номер счета:\t {0}", AccountNumber);
            Console.WriteLine("Тип счета:\t {0}", AccountType);
            Console.WriteLine("Баланс счета:\t {0} ", AccountBalance);
            Console.WriteLine("Владелец счета:\t {0} ", AccountOwner);
        }
    }
}


//Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
//    Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета.
//    Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
//    Создать  несколько экземпляров класса, параметризированного различными типам. Заполнить его поля и вывести информацию об экземпляре класса на печать.