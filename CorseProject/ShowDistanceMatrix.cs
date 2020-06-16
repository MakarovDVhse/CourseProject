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
    public partial class ShowDistanceMatrix : Form
    {
        public void CreateMatrix()
        {
            for (int i = 1; i <= AntAlgorithm.OurGraph.VertexQuantity; i++)
            {
                DistanceMatrix.Columns.Add($"{i}", $"{i}");
                DistanceMatrix.Columns[i - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
                DistanceMatrix.Rows.Add();
                DistanceMatrix.Rows[i - 1].HeaderCell.Value = $"{i}";
            }
            DistanceMatrix.AllowUserToAddRows = false;
        }
        public void BanCells()
        {
            for (int i = 0; i < AntAlgorithm.OurGraph.VertexQuantity; i++)
                for (int j = 0; j < AntAlgorithm.OurGraph.VertexQuantity; j++)
                {
                    DistanceMatrix.Rows[i].Cells[j].Value = AntAlgorithm.OurGraph.DistanceMatrix[i, j].ToString();
                    DistanceMatrix.Rows[i].Cells[j].ReadOnly = true;
                }
        }
        public ShowDistanceMatrix()
        {
            InitializeComponent();
            CreateMatrix();
            BanCells();
        }
    }
}
