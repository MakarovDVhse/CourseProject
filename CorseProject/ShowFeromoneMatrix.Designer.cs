namespace CorseProject
{
    partial class ShowFeromoneMatrix
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
            this.FeromoneMatrix = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FeromoneMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // FeromoneMatrix
            // 
            this.FeromoneMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeromoneMatrix.Location = new System.Drawing.Point(12, 43);
            this.FeromoneMatrix.Name = "FeromoneMatrix";
            this.FeromoneMatrix.RowHeadersWidth = 51;
            this.FeromoneMatrix.RowTemplate.Height = 24;
            this.FeromoneMatrix.Size = new System.Drawing.Size(776, 364);
            this.FeromoneMatrix.TabIndex = 1;
            // 
            // ShowFeromoneMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeromoneMatrix);
            this.Name = "ShowFeromoneMatrix";
            this.Text = "Матрица феромонов";
            ((System.ComponentModel.ISupportInitialize)(this.FeromoneMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FeromoneMatrix;
    }
}