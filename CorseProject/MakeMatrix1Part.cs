using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorseProject
{
    public partial class MakeMatrix1Part : Form
    {
        public static int VertexCheck; 
        public static bool TextCheck(string vertexQuantity)
        {
            bool check = false;
            if (int.TryParse(vertexQuantity, out VertexCheck))
            {
                if (VertexCheck > 0)
                {
                    check = true;
                }
            }
            return check;
        }
        public static bool QuantityCheck(string vertexQuantity)
        {
            bool check = true;
            if (int.Parse(vertexQuantity) < 4)
            {
                check = false;
            }
            return check;
        }
        public static void MakeGraph(string vertexQuantity)
        {
            AntAlgorithm.OurGraph = new Graph(int.Parse(vertexQuantity));
        }
        public MakeMatrix1Part()
        {
            InitializeComponent();
        }

        private void MakeMatrix1Part_Load(object sender, EventArgs e)
        {
            GenerateNewGraph.Enabled = false;
            InputNewGraph.Enabled = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GenerateNewGraph_Click(object sender, EventArgs e)
        {
            if (QuantityCheck(VertexQuantity.Text))
            {
                MakeGraph(VertexQuantity.Text);
                AntAlgorithm.OurGraph.GenerateDistanceMatrix(AntAlgorithm.OurGraph.VertexQuantity);
                MainBody.MadeMatrixCheck = true;
                if (AntAlgorithm.mainBody.ParametrsCheck(AntAlgorithm.mainBody.AntsQuantity.Text, AntAlgorithm.mainBody.Evaporation.Text, AntAlgorithm.mainBody.Alpha.Text, AntAlgorithm.mainBody.Beta.Text) && MainBody.MadeMatrixCheck)
                {
                    AntAlgorithm.mainBody.FindSolution.Enabled = true;
                    AntAlgorithm.mainBody.VisualizeGraph.Enabled = false;
                }
                AntAlgorithm.mainBody.pictureBox1.Controls.Remove(MainBody.viewer);
                Close();
            }
            else
            {
                MessageBox.Show($"Для размерности {VertexQuantity.Text} \n" + "не имеет смысл применять алгоритм", "Размерность массив", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InputNewGraph_Click(object sender, EventArgs e)
        {
            if (QuantityCheck(VertexQuantity.Text))
            {
                MakeGraph(VertexQuantity.Text);
                MakeMatrix2Part makeMatrix2 = new MakeMatrix2Part();
                makeMatrix2.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Для размерности {VertexQuantity.Text} \n" + "не имеет смысл применять алгоритм", "Размерность массива", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void VertexQuantity_TextChanged(object sender, EventArgs e)
        {
            bool check = TextCheck(VertexQuantity.Text);
            if (check)
            {
                GenerateNewGraph.Enabled = true;
                InputNewGraph.Enabled = true;
            }
            else
            {
                GenerateNewGraph.Enabled = false;
                InputNewGraph.Enabled = false;
            }
        }
    }
}
