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
    public partial class ShowFeromoneMatrix : Form
    {
        public void CreateMatrix()
        {
            for (int i = 1; i <= AntAlgorithm.OurGraph.VertexQuantity; i++)
            {
                FeromoneMatrix.Columns.Add($"{i}", $"{i}");
                FeromoneMatrix.Columns[i - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
                FeromoneMatrix.Rows.Add();
                FeromoneMatrix.Rows[i - 1].HeaderCell.Value = $"{i}";
            }
            FeromoneMatrix.AllowUserToAddRows = false;
        }
        public void BanCells()
        {
            for (int i = 0; i < AntAlgorithm.OurGraph.VertexQuantity; i++)
                for (int j = 0; j < AntAlgorithm.OurGraph.VertexQuantity; j++)
                {
                    FeromoneMatrix.Rows[i].Cells[j].Value = AntAlgorithm.OurGraph.FeromoneMatrix[i, j].ToString();
                    FeromoneMatrix.Rows[i].Cells[j].ReadOnly = true;
                }
        }
        public ShowFeromoneMatrix()
        {
            InitializeComponent();
            CreateMatrix();
            BanCells();
        }
    }
}
