using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseProject
{
    public class Ant
    {
        // список посещенных городов
        int[] taboo;
        // путь, пройденный муравьём
        int currentWay;
        public int[] Taboo
        {
            get
            {
                return taboo;
            }
            set
            {
                taboo = value;
            }
        }
        public int CurrentWay
        {
            get
            {
                return currentWay;
            }
            set
            {
                currentWay = value;
            }
        }
        // конструктор, создающий муравья
        public Ant(int Size)
        {
            currentWay = 0;
            taboo = new int[Size];
        }
    }
}
