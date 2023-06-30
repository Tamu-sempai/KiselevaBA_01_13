using System;

namespace KiselevaBA_01_13
{
    class Program
    {
        static void Main (string[] args)
        {
            BaseClass baseClass = new BaseClass("Металический", 2, 10);//вывод информации об объектах базового класса
            Console.WriteLine(baseClass.PrintInfo());
            Console.WriteLine("-------------------------------------------");

            ChildClass childClass = new ChildClass("Медный", 3, 9, false);//вывод информации об объектах класса потомка
            Console.WriteLine($"Qp = {childClass.Calcilation()}");
        }
    }
}
