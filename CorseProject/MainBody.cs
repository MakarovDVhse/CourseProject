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
    public partial class MainBody : Form
    {
        public static MakeMatrix1Part makeMatrix1;
        public static bool MadeMatrixCheck = false;
        public static Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        public bool ParametrsCheck(string AntQuantity, string Evaporation, string Alpha, string Beta)
        {
            bool check = false;
            int antQuantity;
            double evaporation;
            int alpha;
            int beta;
            if (int.TryParse(AntQuantity, out antQuantity) && double.TryParse(Evaporation, out evaporation) && int.TryParse(Alpha, out alpha) && int.TryParse(Beta, out beta))
            {
                if (antQuantity > 0 && evaporation < 1 && evaporation > 0 && alpha > 0 && beta > 0)
                {
                    check = true;
                }
            }
            return check;
        }
        public bool IsinOptimalWaybyVertex(int i, int j)
        {
            bool IsinArray = false;
            for (int k = 0; k < AntAlgorithm.OurGraph.VertexQuantity; k++)
            {
                if (k != AntAlgorithm.OurGraph.VertexQuantity - 1)
                {
                    if (i == AntAlgorithm.OurGraph.OptimalWaybyVertex[k] && j == AntAlgorithm.OurGraph.OptimalWaybyVertex[k + 1] || j == AntAlgorithm.OurGraph.OptimalWaybyVertex[k] && i == AntAlgorithm.OurGraph.OptimalWaybyVertex[k + 1])
                        IsinArray = true;
                }
                else
                {
                    if (i == AntAlgorithm.OurGraph.OptimalWaybyVertex[k] && j == AntAlgorithm.OurGraph.OptimalWaybyVertex[0] || j == AntAlgorithm.OurGraph.OptimalWaybyVertex[k] && i == AntAlgorithm.OurGraph.OptimalWaybyVertex[0])
                        IsinArray = true;
                }
            }
            return IsinArray;
        }
        public void ShowOptimalWay(ref Microsoft.Msagl.Drawing.Graph graph)
        {
            for (int i = 0; i < AntAlgorithm.OurGraph.VertexQuantity; i++)
            {
                if (i != AntAlgorithm.OurGraph.VertexQuantity - 1)
                    graph.AddEdge(AntAlgorithm.OurGraph.OptimalWaybyVertex[i].ToString(), AntAlgorithm.OurGraph.DistanceMatrix[AntAlgorithm.OurGraph.OptimalWaybyVertex[i] - 1, AntAlgorithm.OurGraph.OptimalWaybyVertex[i + 1] - 1].ToString(), AntAlgorithm.OurGraph.OptimalWaybyVertex[i + 1].ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                else
                    graph.AddEdge(AntAlgorithm.OurGraph.OptimalWaybyVertex[i].ToString(), AntAlgorithm.OurGraph.DistanceMatrix[AntAlgorithm.OurGraph.OptimalWaybyVertex[i] - 1, AntAlgorithm.OurGraph.OptimalWaybyVertex[0] - 1].ToString(), AntAlgorithm.OurGraph.OptimalWaybyVertex[0].ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            }
        }
        public void MakeEdges(ref Microsoft.Msagl.Drawing.Graph graph)

        {
            for (int i = 1; i < AntAlgorithm.OurGraph.VertexQuantity; i++)
                for (int j = i + 1; j < AntAlgorithm.OurGraph.VertexQuantity + 1; j++)
                {
                    if (!IsinOptimalWaybyVertex(i, j))
                    {
                        graph.AddEdge(i.ToString(), AntAlgorithm.OurGraph.DistanceMatrix[i - 1, j - 1].ToString(), j.ToString()).Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                    }
                }
        }
        public void GraphMaker()
        {
            pictureBox1.Controls.Remove(viewer);
            viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("Граф");
            graph.Directed = false;
            MakeEdges(ref graph);
            ShowOptimalWay(ref graph);
            viewer.Graph = graph;
            pictureBox1.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            pictureBox1.Controls.Add(viewer);
            pictureBox1.ResumeLayout();
        }
        public MainBody()
        {
            InitializeComponent();
            FindSolution.Enabled = false;
            VisualizeGraph.Enabled = false;
        }

        private void AntsQuantity_TextChanged(object sender, EventArgs e)
        {
            if (ParametrsCheck(AntsQuantity.Text, Evaporation.Text, Alpha.Text, Beta.Text) && MadeMatrixCheck)
            {
                FindSolution.Enabled = true;
                VisualizeGraph.Enabled = false;
                pictureBox1.Controls.Remove(viewer);
            }
            else
            {
                FindSolution.Enabled = false;
                VisualizeGraph.Enabled = false;
            }
        }

        private void показатьМатрицуФеромоновToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AntAlgorithm.OurGraph.FeromoneMatrix != null)
            {
                ShowFeromoneMatrix form = new ShowFeromoneMatrix();
                form.ShowDialog();
            }
        }

        private void FindSolution_Click(object sender, EventArgs e)
        {
            AntAlgorithm.AntQuantity = int.Parse(AntsQuantity.Text);
            AntAlgorithm.constEvaporation = double.Parse(Evaporation.Text);
            AntAlgorithm.constAlpha = int.Parse(Alpha.Text);
            AntAlgorithm.constBeta = int.Parse(Beta.Text);
            AntAlgorithm.MainAlgorithm();
            MessageBox.Show($"Оптимальное расстояние = {AntAlgorithm.OurGraph.OptimalWay}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OptimalWayText.Text = AntAlgorithm.OurGraph.OptimalWay.ToString();
            VisualizeGraph.Enabled = true;
        }

        private void NewGraph_Click(object sender, EventArgs e)
        {
            makeMatrix1 = new MakeMatrix1Part();
            makeMatrix1.ShowDialog();
        }

        private void Evaporation_TextChanged(object sender, EventArgs e)
        {
            if (ParametrsCheck(AntsQuantity.Text, Evaporation.Text, Alpha.Text, Beta.Text) && MadeMatrixCheck)
            {
                FindSolution.Enabled = true;
                VisualizeGraph.Enabled = false;
                pictureBox1.Controls.Remove(viewer);
            }
            else
            {
                FindSolution.Enabled = false;
                VisualizeGraph.Enabled = false;
            }
        }

        private void Alpha_TextChanged(object sender, EventArgs e)
        {
            if (ParametrsCheck(AntsQuantity.Text, Evaporation.Text, Alpha.Text, Beta.Text) && MadeMatrixCheck)
            {
                FindSolution.Enabled = true;
                VisualizeGraph.Enabled = false;
                pictureBox1.Controls.Remove(viewer);
            }
            else
            {
                FindSolution.Enabled = false;
                VisualizeGraph.Enabled = false;
            }
        }

        private void Beta_TextChanged(object sender, EventArgs e)
        {
            if (ParametrsCheck(AntsQuantity.Text, Evaporation.Text, Alpha.Text, Beta.Text) && MadeMatrixCheck)
            {
                FindSolution.Enabled = true;
                VisualizeGraph.Enabled = false;
                pictureBox1.Controls.Remove(viewer);
            }
            else
            {
                FindSolution.Enabled = false;
                VisualizeGraph.Enabled = false;
            }
        }

        private void VisualizeGraph_Click(object sender, EventArgs e)
        {
            GraphMaker();
        }

        private void показатьМатрицуРасстоянийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MadeMatrixCheck)
            {
                ShowDistanceMatrix form = new ShowDistanceMatrix();
                form.ShowDialog();
            }
        }

        private void изменитьМатрицуРасстоянийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MadeMatrixCheck)
            {
                ChangeDistanceMatrix form = new ChangeDistanceMatrix();
                form.ShowDialog();
            }
        }
    }
}
