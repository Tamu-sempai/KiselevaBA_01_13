using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiselevaBA_01_13
{
    public class BaseClass
    {
        public string Type;//тип кабеля
        public int Count;//количество жил кабеля
        public int Diametr;//диаметр кабеля
        public int Q;

        public BaseClass(string type, int count, int diametr)//Конструктор базового класса
        {
            Type = type;
            Count = count;
            Diametr = diametr;
        }

        public virtual int Calcilation ()//Функция, которая определяет качество объекта – Q по заданной формуле;
        {
            Q = Diametr / Count;
            return Q;
        }

        public virtual string PrintInfo ()//Вывод информации об объекте
        {
            return $"Тип кабеля: {Type}\nКоличесвто жил кабеля: {Count}\nДиаметр кабеля: {Diametr}\nQ = {Calcilation()}";
        }
    }
}
