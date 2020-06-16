namespace CorseProject
{
    partial class ShowDistanceMatrix
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
            this.DistanceMatrix = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // DistanceMatrix
            // 
            this.DistanceMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DistanceMatrix.Location = new System.Drawing.Point(12, 43);
            this.DistanceMatrix.Name = "DistanceMatrix";
            this.DistanceMatrix.RowHeadersWidth = 51;
            this.DistanceMatrix.RowTemplate.Height = 24;
            this.DistanceMatrix.Size = new System.Drawing.Size(776, 364);
            this.DistanceMatrix.TabIndex = 2;
            // 
            // ShowDistanceMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DistanceMatrix);
            this.Name = "ShowDistanceMatrix";
            this.Text = "Матрица расстояний";
            ((System.ComponentModel.ISupportInitialize)(this.DistanceMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DistanceMatrix;
    }
}