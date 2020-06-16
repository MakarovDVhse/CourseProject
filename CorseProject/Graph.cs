using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseProject
{
    public class Graph
    {
        // количество вершин графа
        int vertexQuantity;
        // матрица весов вершин
        public int[,] DistanceMatrix;
        // оптимальный путь в графе
        int optimalWay;
        // оптимальный путь по вершинам
        int[] optimalWaybyVertex;
        // матрица феромонов
        public double[,] FeromoneMatrix;
        // матрица обновления феромона на текущей итерации
        public double[,] FeromoneMartrixbyCurrentIteration;
        public int VertexQuantity
        {
            get
            {
                return vertexQuantity;
            }
            set
            {
                vertexQuantity = value;
            }
        }
        public int OptimalWay
        {
            get
            {
                return optimalWay;
            }
            set
            {
                optimalWay = value;
            }
        }
        public int[] OptimalWaybyVertex
        {
            get
            {
                return optimalWaybyVertex;
            }
            set
            {
                optimalWaybyVertex = value;
            }
        }
        // конструктор без параметра
        public Graph()
        {
            vertexQuantity = 0;
            optimalWay = 0;
            optimalWaybyVertex = new int[vertexQuantity];
        }
        // конструктор с параметрами
        public Graph(int vq)
        {
            vertexQuantity = vq;
            optimalWay = 0;
            optimalWaybyVertex = new int[vertexQuantity];
        }
        // метод, создающий начальную матрицу феромонов
        public void FirstFeromoneMatrix(int Size)
        {
            FeromoneMatrix = new double[Size, Size];
            for (int i=0; i<Size; i++)
            {
                for (int j = 0; j< Size; j++)
                {
                    if (i != j)
                        FeromoneMatrix[i, j] = 1.0;
                }
            }
        }
        // создание новой матрицы обновления феромонов нна текущей итерации
        public void FeromoneMatrixbyCurrentItterationNew(int Size)
        {
            FeromoneMartrixbyCurrentIteration = new double[Size, Size];
        }
        // метод, обновляющий матрицу феромонов после текущей итерации
        public void FeromoneMatrixAfterIteration()
        {
            for (int i = 0; i < vertexQuantity; i++)
            {
                for (int j = 0; j < vertexQuantity; j++)
                {
                    FeromoneMatrix[i, j] = AntAlgorithm.constEvaporation * FeromoneMatrix[i, j] + FeromoneMartrixbyCurrentIteration[i, j];
                }
            }
        }
        // метод, создающий ДСЧ матрицу весов для графа
        public void GenerateDistanceMatrix(int Size)
        {
            DistanceMatrix = new int[Size, Size];
            Random random = new Random();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (j > i)
                        DistanceMatrix[i, j] = random.Next(10, 190);
                }
            }
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i > j)
                        DistanceMatrix[i, j] = DistanceMatrix[j, i];
                }
            }
        }
        // метод, создающий пустой масссив
        public void MakeDistanceMatrix(int Size)
        {
            DistanceMatrix = new int[Size, Size];
        }
    }
}
