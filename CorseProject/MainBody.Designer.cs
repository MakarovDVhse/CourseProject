namespace CorseProject
{
    public partial class MainBody
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.графToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьМатрицуРасстоянийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьМатрицуФеромоновToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьМатрицуРасстоянийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGraph = new System.Windows.Forms.Button();
            this.VisualizeGraph = new System.Windows.Forms.Button();
            this.Colony = new System.Windows.Forms.Label();
            this.AntsQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Alpha = new System.Windows.Forms.TextBox();
            this.Beta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Evaporation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FindSolution = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OptimalWay = new System.Windows.Forms.Label();
            this.OptimalWayText = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // графToolStripMenuItem
            // 
            this.графToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьМатрицуРасстоянийToolStripMenuItem,
            this.показатьМатрицуФеромоновToolStripMenuItem,
            this.изменитьМатрицуРасстоянийToolStripMenuItem});
            this.графToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.графToolStripMenuItem.Name = "графToolStripMenuItem";
            this.графToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.графToolStripMenuItem.Text = "Граф";
            // 
            // показатьМатрицуРасстоянийToolStripMenuItem
            // 
            this.показатьМатрицуРасстоянийToolStripMenuItem.Name = "показатьМатрицуРасстоянийToolStripMenuItem";
            this.показатьМатрицуРасстоянийToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.показатьМатрицуРасстоянийToolStripMenuItem.Text = "Показать матрицу расстояний";
            this.показатьМатрицуРасстоянийToolStripMenuItem.Click += new System.EventHandler(this.показатьМатрицуРасстоянийToolStripMenuItem_Click);
            // 
            // показатьМатрицуФеромоновToolStripMenuItem
            // 
            this.показатьМатрицуФеромоновToolStripMenuItem.Name = "показатьМатрицуФеромоновToolStripMenuItem";
            this.показатьМатрицуФеромоновToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.показатьМатрицуФеромоновToolStripMenuItem.Text = "Показать матрицу феромонов";
            this.показатьМатрицуФеромоновToolStripMenuItem.Click += new System.EventHandler(this.показатьМатрицуФеромоновToolStripMenuItem_Click);
            // 
            // изменитьМатрицуРасстоянийToolStripMenuItem
            // 
            this.изменитьМатрицуРасстоянийToolStripMenuItem.Name = "изменитьМатрицуРасстоянийToolStripMenuItem";
            this.изменитьМатрицуРасстоянийToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.изменитьМатрицуРасстоянийToolStripMenuItem.Text = "Изменить матрицу расстояний";
            this.изменитьМатрицуРасстоянийToolStripMenuItem.Click += new System.EventHandler(this.изменитьМатрицуРасстоянийToolStripMenuItem_Click);
            // 
            // NewGraph
            // 
            this.NewGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGraph.Location = new System.Drawing.Point(1067, 49);
            this.NewGraph.Name = "NewGraph";
            this.NewGraph.Size = new System.Drawing.Size(303, 65);
            this.NewGraph.TabIndex = 2;
            this.NewGraph.Text = "Создать новый граф";
            this.toolTip1.SetToolTip(this.NewGraph, "Задать граф для дальнейшей работы с ним");
            this.NewGraph.UseVisualStyleBackColor = true;
            this.NewGraph.Click += new System.EventHandler(this.NewGraph_Click);
            // 
            // VisualizeGraph
            // 
            this.VisualizeGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisualizeGraph.Location = new System.Drawing.Point(1067, 581);
            this.VisualizeGraph.Name = "VisualizeGraph";
            this.VisualizeGraph.Size = new System.Drawing.Size(303, 65);
            this.VisualizeGraph.TabIndex = 3;
            this.VisualizeGraph.Text = "Визуализировать решение";
            this.toolTip7.SetToolTip(this.VisualizeGraph, "Визуализировать граф с решением.\r\nСначала необходимо найти решение для данного гр" +
        "афа");
            this.VisualizeGraph.UseVisualStyleBackColor = true;
            this.VisualizeGraph.Click += new System.EventHandler(this.VisualizeGraph_Click);
            // 
            // Colony
            // 
            this.Colony.AutoSize = true;
            this.Colony.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Colony.Location = new System.Drawing.Point(6, 53);
            this.Colony.Name = "Colony";
            this.Colony.Size = new System.Drawing.Size(221, 25);
            this.Colony.TabIndex = 4;
            this.Colony.Text = "Количество  муравьёв\r\n";
            // 
            // AntsQuantity
            // 
            this.AntsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AntsQuantity.Location = new System.Drawing.Point(226, 78);
            this.AntsQuantity.Name = "AntsQuantity";
            this.AntsQuantity.Size = new System.Drawing.Size(71, 30);
            this.AntsQuantity.TabIndex = 5;
            this.toolTip2.SetToolTip(this.AntsQuantity, "Количество муравьёв в колонии (целое число)");
            this.AntsQuantity.TextChanged += new System.EventHandler(this.AntsQuantity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "в колонии:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Значение Бэта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Значение Альфа:";
            // 
            // Alpha
            // 
            this.Alpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alpha.Location = new System.Drawing.Point(226, 183);
            this.Alpha.Name = "Alpha";
            this.Alpha.Size = new System.Drawing.Size(71, 30);
            this.Alpha.TabIndex = 9;
            this.toolTip4.SetToolTip(this.Alpha, "Значение, определяющее стадность алгоритма");
            this.Alpha.TextChanged += new System.EventHandler(this.Alpha_TextChanged);
            // 
            // Beta
            // 
            this.Beta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Beta.Location = new System.Drawing.Point(226, 224);
            this.Beta.Name = "Beta";
            this.Beta.Size = new System.Drawing.Size(71, 30);
            this.Beta.TabIndex = 10;
            this.toolTip5.SetToolTip(this.Beta, "Значение, определяющее жадность алгоритма");
            this.Beta.TextChanged += new System.EventHandler(this.Beta_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Evaporation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Colony);
            this.groupBox1.Controls.Add(this.Beta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Alpha);
            this.groupBox1.Controls.Add(this.AntsQuantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1067, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 279);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дополнительные параметры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "испарения (< 1):";
            // 
            // Evaporation
            // 
            this.Evaporation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Evaporation.Location = new System.Drawing.Point(226, 131);
            this.Evaporation.Name = "Evaporation";
            this.Evaporation.Size = new System.Drawing.Size(71, 30);
            this.Evaporation.TabIndex = 12;
            this.toolTip3.SetToolTip(this.Evaporation, "Коэффициент испарения феромонов после итерации (вещественное число от 0 до 1)");
            this.Evaporation.TextChanged += new System.EventHandler(this.Evaporation_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Коэффициент";
            // 
            // FindSolution
            // 
            this.FindSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindSolution.Location = new System.Drawing.Point(1067, 405);
            this.FindSolution.Name = "FindSolution";
            this.FindSolution.Size = new System.Drawing.Size(303, 65);
            this.FindSolution.TabIndex = 12;
            this.FindSolution.Text = "Найти решение";
            this.toolTip6.SetToolTip(this.FindSolution, "Нахождение оптимального пути для данного графа.\r\nНевозможно запустить, пока не со" +
        "здан граф и не введены дополнительные параметры\r\n");
            this.FindSolution.UseVisualStyleBackColor = true;
            this.FindSolution.Click += new System.EventHandler(this.FindSolution_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1049, 615);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.toolTip8.SetToolTip(this.pictureBox1, "Пространство для визуализации графа");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1067, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Оптимальный путь для";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1067, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "данного графа:";
            // 
            // OptimalWay
            // 
            this.OptimalWay.AutoSize = true;
            this.OptimalWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OptimalWay.Location = new System.Drawing.Point(1143, 523);
            this.OptimalWay.Name = "OptimalWay";
            this.OptimalWay.Size = new System.Drawing.Size(0, 25);
            this.OptimalWay.TabIndex = 16;
            // 
            // OptimalWayText
            // 
            this.OptimalWayText.AutoSize = true;
            this.OptimalWayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OptimalWayText.Location = new System.Drawing.Point(1228, 523);
            this.OptimalWayText.Name = "OptimalWayText";
            this.OptimalWayText.Size = new System.Drawing.Size(0, 25);
            this.OptimalWayText.TabIndex = 17;
            // 
            // MainBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1382, 658);
            this.Controls.Add(this.OptimalWayText);
            this.Controls.Add(this.OptimalWay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FindSolution);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VisualizeGraph);
            this.Controls.Add(this.NewGraph);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainBody";
            this.Text = "Ant Algorithm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem графToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьМатрицуРасстоянийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьМатрицуФеромоновToolStripMenuItem;
        public System.Windows.Forms.Button NewGraph;
        public System.Windows.Forms.Button VisualizeGraph;
        private System.Windows.Forms.Label Colony;
        public System.Windows.Forms.TextBox AntsQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Alpha;
        public System.Windows.Forms.TextBox Beta;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button FindSolution;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Evaporation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem изменитьМатрицуРасстоянийToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label OptimalWay;
        private System.Windows.Forms.Label OptimalWayText;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip8;
    }
}