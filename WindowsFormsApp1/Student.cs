using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Student
    {
        public string name;
        public int rost;
        private double ves = 50;
        public void Eat(double ed)
        {
            if (ed > 5 && ed < 10)
            {
                rost -= 1;
                ves += (((ed * 1000 - 1600) / 1000) / 1000) * 0.7;
            }
            else if (ed > 10)
            {
                rost -= 2;
                ves += ((ed * 1000 - 1800) / 1000) * 0.5;
            }
            else
                ves += (ed * 1000 - 1600) / 1000;
        }
        public double GetEat()
        {
            return ves;
        }
    }
}
