using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseProject
{
    public class Roulette
    {
        // массив возможных рёбер
        int[] edge;
        // рулетка
        double[] rulettePercentage;
        public int[] Edge
        {
            get
            {
                return edge;
            }
            set
            {
                edge = value;
            }
        }
        public double[] RulettePercentage
        {
            get
            {
                return rulettePercentage;
            }
            set
            {
                rulettePercentage = value;
            }
        }
        // конструктор рулетки
        public Roulette(int Size)
        {
            edge = new int[Size];
            rulettePercentage = new double[Size];
        }
    }
}
