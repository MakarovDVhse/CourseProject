namespace CorseProject
{
    partial class ChangeDistanceMatrix
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
            this.Matrix = new System.Windows.Forms.DataGridView();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // Matrix
            // 
            this.Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix.Location = new System.Drawing.Point(12, 12);
            this.Matrix.Name = "Matrix";
            this.Matrix.RowHeadersWidth = 51;
            this.Matrix.RowTemplate.Height = 24;
            this.Matrix.Size = new System.Drawing.Size(776, 364);
            this.Matrix.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Matrix, "Место для ввода матрицы весов рёбер.\r\nДля удобства вводите значения в ячейки спра" +
        "ва от главной диагонали.\r\nОставшиеся ячейки заполняются автоматически.\r\n\r\n");
            this.Matrix.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Matrix_CellEnter);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.Location = new System.Drawing.Point(280, 382);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(236, 65);
            this.SaveChanges.TabIndex = 14;
            this.SaveChanges.Text = "Изменить значения";
            this.toolTip3.SetToolTip(this.SaveChanges, "Сохранение значений изменённой матрицы");
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(12, 382);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(139, 65);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Очистить";
            this.toolTip2.SetToolTip(this.Clear, "Полная очистка матрицы дистанций");
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(649, 382);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(139, 65);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click_1);
            // 
            // ChangeDistanceMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Matrix);
            this.Name = "ChangeDistanceMatrix";
            this.Text = "Изменить матрицу расстояний";
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Matrix;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}