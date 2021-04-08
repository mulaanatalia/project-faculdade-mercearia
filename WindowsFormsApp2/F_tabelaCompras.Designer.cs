namespace WindowsFormsApp2
{
    partial class F_tabelaCompras
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
            this.dtvCompras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvCompras
            // 
            this.dtvCompras.AllowUserToAddRows = false;
            this.dtvCompras.AllowUserToDeleteRows = false;
            this.dtvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCompras.Location = new System.Drawing.Point(12, 12);
            this.dtvCompras.Name = "dtvCompras";
            this.dtvCompras.ReadOnly = true;
            this.dtvCompras.Size = new System.Drawing.Size(761, 381);
            this.dtvCompras.TabIndex = 0;
            this.dtvCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtvCompras_CellContentClick);
            // 
            // F_tabelaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 405);
            this.Controls.Add(this.dtvCompras);
            this.Name = "F_tabelaCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras Efectuadas";
            this.Load += new System.EventHandler(this.F_tabelaCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvCompras;
    }
}