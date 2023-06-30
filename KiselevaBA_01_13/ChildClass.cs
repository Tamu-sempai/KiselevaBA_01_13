using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiselevaBA_01_13
{
    public class ChildClass : BaseClass
    {
        public bool P;//наличие оплетки
        public double Qp;

        public ChildClass (string type, int count, int diametr, bool p) : base(type, count, diametr)//Конструктор класса наследника
        {
            P = p;
        }

        public override  int Calcilation ()//Функция, которая определяет «качество» объекта класса потомка – Qp,
        {
            double Q = Convert.ToDouble( base.Calcilation());
            if(P == true)
            {
                Qp = 2 * Q;
            } else
            {
                Qp = 0.7 * Q;
            }
            return (int)Qp;
        }
    }
}
