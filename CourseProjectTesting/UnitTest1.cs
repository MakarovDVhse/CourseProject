using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CorseProject;

namespace CourseProjectTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AntClassTest()
        {
            // arrange
            int size = 5;
            int cw = 0;
            int[] mas = new int[5] { 1, 2, 3, 4, 5 };
            // act
            Ant ant = new Ant(size);
            // assert
            Assert.AreEqual(cw, ant.CurrentWay);
            // act
            ant.CurrentWay = 50;
            ant.Taboo = mas;
            // assert
            Assert.AreEqual(mas, ant.Taboo);
            Assert.AreEqual(50, ant.CurrentWay);
        }
        [TestMethod]
        public void GraphClassTest()
        {
            // arrange
            int vq = 5;
            // act
            Graph graph = new Graph();
            Graph graph1 = new Graph(vq);
            // assert
            Assert.AreNotEqual(graph, null);
            Assert.AreNotEqual(graph1, null);
            // act
            graph1.VertexQuantity = vq;
            graph1.OptimalWay = 15;
            graph1.OptimalWaybyVertex = new int[5] { 1, 2, 3, 4, 5};
            // assert
            Assert.AreEqual(graph1.VertexQuantity, 5);
            Assert.AreEqual(graph1.OptimalWay, 15);
            Assert.AreNotEqual(graph1.OptimalWaybyVertex, null);
            // act
            graph1.FirstFeromoneMatrix(vq);
            // assert
            Assert.AreNotEqual(graph1.FeromoneMatrix, null);
            // act
            graph1.FeromoneMatrixbyCurrentItterationNew(vq);
            // assert
            Assert.AreNotEqual(graph1.FeromoneMartrixbyCurrentIteration, null);
            // act
            graph1.FeromoneMatrixAfterIteration();
            // assert
            Assert.AreNotEqual(graph1.FeromoneMatrix, null);
            // act
            graph1.MakeDistanceMatrix(vq);
            // assert
            Assert.AreNotEqual(graph1.DistanceMatrix, null);
            // act
            graph1.GenerateDistanceMatrix(vq);
            // assert
            Assert.AreNotEqual(graph1.DistanceMatrix, null);
        }
        [TestMethod]
        public void RouletteClassTest()
        {
            // arrange
            int size = 5;
            // act
            Roulette roulette = new Roulette(size);
            // assert
            Assert.AreNotEqual(roulette, null);
            // act
            roulette.Edge = new int[3] { 1, 2, 3 };
            roulette.RulettePercentage = new double[3] { 15.1, 48.3, 100 };
            // assert
            Assert.AreNotEqual(roulette.Edge, null);
            Assert.AreNotEqual(roulette.RulettePercentage, null);
        }
        [TestMethod]
        public void AntAlgprithmTest()
        {
            // arrange
            int size = 5;
            // act
            AntAlgorithm.OurGraph = new Graph(size);
            AntAlgorithm.OurGraph.GenerateDistanceMatrix(size);
            AntAlgorithm.constAlpha = 1;
            AntAlgorithm.constBeta = 1;
            AntAlgorithm.constEvaporation = 0.8;
            AntAlgorithm.AntQuantity = 10;
            AntAlgorithm.MainAlgorithm();
            // assert
            Assert.AreNotEqual(AntAlgorithm.OurGraph.OptimalWay, null);
        }
    }
}
