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
    partial class ChangeDistanceMatrix : Form
    {
        public void InputDistanceMatrix()
        {
            for (int i = 0; i < AntAlgorithm.OurGraph.VertexQuantity; i++)
                for (int j = 0; j < AntAlgorithm.OurGraph.VertexQuantity; j++)
                    if (i != j)
                        AntAlgorithm.OurGraph.DistanceMatrix[i, j] = int.Parse((Matrix.Rows[i].Cells[j].Value).ToString());
        }
        public bool MatrixCheckText()
        {
            bool ok = true;
            int check;
            for (int i = 0; i < AntAlgorithm.OurGraph.VertexQuantity; i++)
                for (int j = 0; j < AntAlgorithm.OurGraph.VertexQuantity; j++)
                    if (i != j && !int.TryParse((Matrix.Rows[i].Cells[j].Value).ToString(), out check))
                        ok = false;
            return ok;
        }
        public bool MatrixCheckInt()
        {
            bool ok = true;
            for (int i = 0; i < AntAlgorithm.OurGraph.VertexQuantity; i++)
                for (int j = 0; j < AntAlgorithm.OurGraph.VertexQuantity; j++)
                    if (i != j && int.Parse((Matrix.Rows[i].Cells[j].Value).ToString()) < 0)
                        ok = false;
            return ok;
        }
        public bool TotalCheck()
        {
            bool ok = true;
            if (!MatrixCheckText())
            {
                MessageBox.Show($"Некоторые ячейки содержат значения\n" + "неверного типа", "Входные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            else if (!MatrixCheckInt())
            {
                MessageBox.Show($"Некоторые ячейки содержат \n" + "отрицательные значения", "Входные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            return ok;
        }
        public void CreateMatrix()
        {
            for (int i = 1; i <= AntAlgorithm.OurGraph.VertexQuantity; i++)
            {
                Matrix.Columns.Add($"{i}", $"{i}");
                Matrix.Columns[i - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
                Matrix.Rows.Add();
                Matrix.Rows[i - 1].HeaderCell.Value = $"{i}";
            }
            Matrix.AllowUserToAddRows = false;
        }
        public void ClearMatrix()
        {
            for (int i = 0; i < AntAlgorithm.OurGraph.VertexQuantity; i++)
                for (int j = 0; j < AntAlgorithm.OurGraph.VertexQuantity; j++)
                    if (i != j)
                        Matrix.Rows[i].Cells[j].Value = "";
        }
        public void MakeBan()
        {
            for (int i = 0; i < AntAlgorithm.OurGraph.VertexQuantity; i++)
                for (int j = 0; j < AntAlgorithm.OurGraph.VertexQuantity; j++)
                {
                    if (i == j)
                    {
                        Matrix.Rows[i].Cells[j].Value = "0";
                        Matrix.Rows[i].Cells[j].ReadOnly = true;
                    }
                    else if (j < i)
                    {
                        Matrix.Rows[i].Cells[j].Value = AntAlgorithm.OurGraph.DistanceMatrix[i, j];
                        Matrix.Rows[i].Cells[j].ReadOnly = true;
                    }
                    else
                        Matrix.Rows[i].Cells[j].Value = AntAlgorithm.OurGraph.DistanceMatrix[i, j];
                }
        }
        public ChangeDistanceMatrix()
        {
            InitializeComponent();
            CreateMatrix();
            MakeBan();
        }

        private void Matrix_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < AntAlgorithm.OurGraph.VertexQuantity; i++)
                for (int j = 0; j < AntAlgorithm.OurGraph.VertexQuantity; j++)
                    if (j < i)
                    {
                        Matrix.Rows[i].Cells[j].Value = Matrix.Rows[j].Cells[i].Value;
                    }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (TotalCheck())
            {
                AntAlgorithm.OurGraph.MakeDistanceMatrix(AntAlgorithm.OurGraph.VertexQuantity);
                InputDistanceMatrix();
                MainBody.MadeMatrixCheck = true;
                if (AntAlgorithm.mainBody.ParametrsCheck(AntAlgorithm.mainBody.AntsQuantity.Text, AntAlgorithm.mainBody.Evaporation.Text, AntAlgorithm.mainBody.Alpha.Text, AntAlgorithm.mainBody.Beta.Text) && MainBody.MadeMatrixCheck)
                {
                    AntAlgorithm.mainBody.FindSolution.Enabled = true;
                    AntAlgorithm.mainBody.VisualizeGraph.Enabled = false;
                }
                AntAlgorithm.mainBody.pictureBox1.Controls.Remove(MainBody.viewer);
                Close();
            }
        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            ClearMatrix();
        }
    }
}
