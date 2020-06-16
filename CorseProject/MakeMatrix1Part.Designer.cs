namespace CorseProject
{
    partial class MakeMatrix1Part
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GenerateNewGraph = new System.Windows.Forms.Button();
            this.InputNewGraph = new System.Windows.Forms.Button();
            this.Colony = new System.Windows.Forms.Label();
            this.VertexQuantity = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // GenerateNewGraph
            // 
            this.GenerateNewGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateNewGraph.Location = new System.Drawing.Point(112, 88);
            this.GenerateNewGraph.Name = "GenerateNewGraph";
            this.GenerateNewGraph.Size = new System.Drawing.Size(303, 65);
            this.GenerateNewGraph.TabIndex = 3;
            this.GenerateNewGraph.Text = "Сгенерировать граф";
            this.toolTip2.SetToolTip(this.GenerateNewGraph, "Генерация массива датчиком случайных чисел");
            this.GenerateNewGraph.UseVisualStyleBackColor = true;
            this.GenerateNewGraph.Click += new System.EventHandler(this.GenerateNewGraph_Click);
            // 
            // InputNewGraph
            // 
            this.InputNewGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputNewGraph.Location = new System.Drawing.Point(112, 159);
            this.InputNewGraph.Name = "InputNewGraph";
            this.InputNewGraph.Size = new System.Drawing.Size(303, 65);
            this.InputNewGraph.TabIndex = 4;
            this.InputNewGraph.Text = "Ввести граф";
            this.toolTip3.SetToolTip(this.InputNewGraph, "Ввод графа вручную");
            this.InputNewGraph.UseVisualStyleBackColor = true;
            this.InputNewGraph.Click += new System.EventHandler(this.InputNewGraph_Click);
            // 
            // Colony
            // 
            this.Colony.AutoSize = true;
            this.Colony.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Colony.Location = new System.Drawing.Point(86, 37);
            this.Colony.Name = "Colony";
            this.Colony.Size = new System.Drawing.Size(267, 25);
            this.Colony.TabIndex = 5;
            this.Colony.Text = "Количество вершин графа:";
            // 
            // VertexQuantity
            // 
            this.VertexQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VertexQuantity.Location = new System.Drawing.Point(374, 37);
            this.VertexQuantity.Name = "VertexQuantity";
            this.VertexQuantity.Size = new System.Drawing.Size(71, 30);
            this.VertexQuantity.TabIndex = 7;
            this.toolTip1.SetToolTip(this.VertexQuantity, "Место для ввода количества вершин графа");
            this.VertexQuantity.TextChanged += new System.EventHandler(this.VertexQuantity_TextChanged);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(385, 241);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(139, 65);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // MakeMatrix1Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(536, 318);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.VertexQuantity);
            this.Controls.Add(this.Colony);
            this.Controls.Add(this.InputNewGraph);
            this.Controls.Add(this.GenerateNewGraph);
            this.Name = "MakeMatrix1Part";
            this.Text = "Выбор создания масссива";
            this.Load += new System.EventHandler(this.MakeMatrix1Part_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateNewGraph;
        private System.Windows.Forms.Button InputNewGraph;
        private System.Windows.Forms.Label Colony;
        private System.Windows.Forms.TextBox VertexQuantity;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}