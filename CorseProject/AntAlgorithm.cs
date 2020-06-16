using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorseProject
{
    // основной класс, в котором содержится реализация самого муравьиного алгоритма
    public static class AntAlgorithm
    {
        public static MainBody mainBody;
        // создание графа
        public static Graph OurGraph = new Graph();
        // константа испарения феромонов
        public static double constEvaporation;
        // константа значения альфа
        public static int constAlpha;
        // константа значения бэта
        public static int constBeta;
        // количество муравьёв в колонии
        public static int AntQuantity;
        // оптимальный путь на текущей итерации
        public static int OptimalWayonCurrentIteration;
        // оптимальный путь по вершинам на текущей итерации
        public static int[] OptimalWayonCurrentIterationbyVertex;
        // вспомагательный рандомайзер
        public static Random random = new Random();
        // единичный муравей
        public static Ant ant1;
        // рулетка
        public static Roulette rulette;
        // масссив числителей
        public static double[] Numenator;
        // знаменатель формулы вероятностного перехлда
        public static double denomenator;
        // нахождение ребра с самым большим весом
        // необходимо для подсчёта константы Q
        public static int MaxDistance()
        {
            int maxElement = 0;
            for (int i = 0; i < OurGraph.VertexQuantity; i++)
                for (int j = 0; j < OurGraph.VertexQuantity; j++)
                    if (i != j && OurGraph.DistanceMatrix[i, j] > maxElement)
                        maxElement = OurGraph.DistanceMatrix[i, j];
            return maxElement;
        }
        // проверка принадлежит ли элемент массиву
        // преимущественно для понятия какие пути ещё не в Taboo
        public static bool IsinArray(int element)
        {
            bool ok = false;
            for (int i = 0; i < OurGraph.VertexQuantity; i++)
            {
                if (ant1.Taboo[i] == element)
                    ok = true;
            }
            return ok;
        }
        // подсчёт значения числителя вероятности прохода по ребру
        // часть формулы вероятности прохода по ребру
        // знаменатель будет высчитываться по сумме всех числителей
        public static double ChanceNumenator(int TabooPosition, int CurrentPosition)
        {
            double secondpart = Math.Pow(1/(double)OurGraph.DistanceMatrix[ant1.Taboo[TabooPosition] - 1, CurrentPosition - 1], constBeta);
            double firstpart = Math.Pow(OurGraph.FeromoneMatrix[ant1.Taboo[TabooPosition] - 1, CurrentPosition - 1], constAlpha);            
            double answer = firstpart * secondpart;
            return answer;
        }
        // подсчёт знаменателя формулы вероятности прохода по ребру
        // подсчитывается каак сумма числителей
        public static double Denumenator()
        {
            double denumenator = 0;
            for (int i = 0; i < Numenator.Length; i++)
            {
                denumenator += Numenator[i];
            }
            return denumenator;
        }
        // создание отдельного муравья
        public static void CreateAnt(ref Ant ant1)
        {
            ant1 = new Ant(OurGraph.VertexQuantity);
            ant1.Taboo[0] = random.Next(1, OurGraph.VertexQuantity);
        }
        // нахождение муравьём возможных вариантов
        public static void PossibleVariants(ref int j, ref int i, ref int index)
        {
            if (!IsinArray(j))
            {
                rulette.Edge[index] = j;
                Numenator[index] = ChanceNumenator(i - 1, j);
                index++;
            }
        }
        // создание рулетки со значениями вероятности перехода по вершинам
        public static void RouletteMaker(ref int j, ref int index)
        {
            if (!IsinArray(j))
            {
                if (index == 0)
                    rulette.RulettePercentage[index] = Numenator[index] / denomenator * 100;
                else
                    rulette.RulettePercentage[index] = Numenator[index] / denomenator * 100 + rulette.RulettePercentage[index - 1];
                index++;
            }
        }
        // выбор вероятности случайным способом на рулетке
        public static void RouletteChoice(ref double Point, ref bool RightPositionCheck, ref int RightPosition, ref int j)
        {
            if (Point <= rulette.RulettePercentage[j] && !RightPositionCheck)
            {
                RightPosition = j;
                RightPositionCheck = true;
            }
        }
        // логика выбора пути муравьём
        public static void AntChoices(ref int i)
        {
            rulette = new Roulette(OurGraph.VertexQuantity - i);
            Numenator = new double[OurGraph.VertexQuantity - i];
            int index = 0;
            for (int j = 1; j < OurGraph.VertexQuantity + 1; j++)
            {
                PossibleVariants(ref j, ref i, ref index);
            }
            index = 0;
            denomenator = Denumenator();
            for (int j = 1; j < OurGraph.VertexQuantity + 1; j++)
            {
                RouletteMaker(ref j, ref index);
            }
            double Point = random.NextDouble() * 100;
            int RightPosition = 0;
            bool RightPositionCheck = false;
            for (int j = 0; j < rulette.RulettePercentage.Length; j++)
            {
                RouletteChoice(ref Point, ref RightPositionCheck, ref RightPosition, ref j);
            }
            ant1.Taboo[i] = rulette.Edge[RightPosition];
        }
        // добавление последней вершины в Taboo
        public static void AddLastVertextoTaboo(ref bool CheckVertex, ref int i)
        {
            CheckVertex = false;
            for (int j = 0; j < ant1.Taboo.Length - 1; j++)
            {
                if (i == ant1.Taboo[j])
                {
                    CheckVertex = true;
                }
            }
            if (!CheckVertex)
                ant1.Taboo[OurGraph.VertexQuantity - 1] = i;
        }
        // подсчёт пути, пройденного муравьём
        public static void CurrentWayConting(ref int i)
        {
            if (i == OurGraph.VertexQuantity - 1)
                ant1.CurrentWay += OurGraph.DistanceMatrix[ant1.Taboo[i] - 1, ant1.Taboo[0] - 1];
            else
                ant1.CurrentWay += OurGraph.DistanceMatrix[ant1.Taboo[i] - 1, ant1.Taboo[i + 1] - 1];
        }
        // обновление матрицы на текущей итерации
        public static void FeromoneMatrixUpdate(ref int i, ref double feromone)
        {
            if (i == OurGraph.VertexQuantity - 1)
                OurGraph.FeromoneMartrixbyCurrentIteration[ant1.Taboo[i] - 1, ant1.Taboo[0] - 1] += feromone;
            else
                OurGraph.FeromoneMartrixbyCurrentIteration[ant1.Taboo[i] - 1, ant1.Taboo[i + 1] - 1] += feromone;
        }
        // проверка является ли путь пройденный муравьём наименьшим на итерации
        public static void CheckOptimalWayonCurrentIteration()
        {
            if (ant1.CurrentWay < OptimalWayonCurrentIteration)
            {
                OptimalWayonCurrentIteration = ant1.CurrentWay;
                OptimalWayonCurrentIterationbyVertex = ant1.Taboo;
            }
        }
        // проход одного муравья по вершинам графа
        public static void OneAntPassage(ref double constQ)
        {
            CreateAnt(ref ant1);
            for (int i = 1; i < OurGraph.VertexQuantity - 1; i++)
            {
                AntChoices(ref i);
            }
            bool CheckVertex = false;
            for (int i = 1; i < OurGraph.VertexQuantity + 1; i++)
            {
                AddLastVertextoTaboo(ref CheckVertex, ref i);
            }
            for (int i = 0; i < OurGraph.VertexQuantity; i++)
            {
                CurrentWayConting(ref i);
            }
            double feromone = (constQ / (double)ant1.CurrentWay)/(double)OurGraph.VertexQuantity;
            for (int i = 0; i < OurGraph.VertexQuantity; i++)
            {
                FeromoneMatrixUpdate(ref i, ref feromone);
            }
            CheckOptimalWayonCurrentIteration();
        }
        // проверка является ли минамльный путь на итерации меньше оптимального + (возможное присваинвания и обнуление проходов)
        public static void CheckOptimalWay(ref int iteration)
        {
            if (OptimalWayonCurrentIteration < OurGraph.OptimalWay)
            {
                OurGraph.OptimalWay = OptimalWayonCurrentIteration;
                OurGraph.OptimalWaybyVertex = OptimalWayonCurrentIterationbyVertex;
                iteration = 0;
            }
        }
        // одна итерация 
        public static void OneIteration(ref double constQ, ref int iteration)
        {
            OurGraph.FeromoneMatrixbyCurrentItterationNew(OurGraph.VertexQuantity);
            OptimalWayonCurrentIteration = OurGraph.VertexQuantity * MaxDistance();
            OptimalWayonCurrentIterationbyVertex = new int[OurGraph.VertexQuantity];
            for (int ant = 0; ant < AntQuantity; ant++)
            {
                OneAntPassage(ref constQ);
            }
            OurGraph.FeromoneMatrixAfterIteration();
            CheckOptimalWay(ref iteration);
        }
        // сам алгоритм
        public static void MainAlgorithm()
        {
            double constQ = (double)MaxDistance() * (double)OurGraph.VertexQuantity / 2;
            OurGraph.FirstFeromoneMatrix(OurGraph.VertexQuantity);
            OurGraph.OptimalWay = OurGraph.VertexQuantity * MaxDistance();
            for (int iteration = 0; iteration < 20; iteration++)
            {
                OneIteration(ref constQ, ref iteration);
            }
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainBody = new MainBody());
        }
    }
}
