namespace WindowsFormsApp2
{
    partial class F_Actualizar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.upPreco = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtvProduto = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.upID = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProduto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upID)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.upID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMarca);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.upPreco);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dtvProduto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 468);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Novo preço";
            // 
            // upPreco
            // 
            this.upPreco.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upPreco.Location = new System.Drawing.Point(141, 364);
            this.upPreco.Name = "upPreco";
            this.upPreco.Size = new System.Drawing.Size(215, 27);
            this.upPreco.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(266, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Novo Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(141, 276);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 29);
            this.txtNome.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tan;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(264, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 35);
            this.button3.TabIndex = 20;
            this.button3.Text = "Atualizar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 48);
            this.label10.TabIndex = 19;
            this.label10.Text = "ID do Produto";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // dtvProduto
            // 
            this.dtvProduto.AllowUserToAddRows = false;
            this.dtvProduto.AllowUserToDeleteRows = false;
            this.dtvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtvProduto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvProduto.Location = new System.Drawing.Point(13, 136);
            this.dtvProduto.Name = "dtvProduto";
            this.dtvProduto.Size = new System.Drawing.Size(345, 100);
            this.dtvProduto.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Atualizar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 27);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.AdicionarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.EliminarToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nova Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(143, 320);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(215, 29);
            this.txtMarca.TabIndex = 26;
            // 
            // upID
            // 
            this.upID.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upID.Location = new System.Drawing.Point(97, 73);
            this.upID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.upID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upID.Name = "upID";
            this.upID.Size = new System.Drawing.Size(163, 27);
            this.upID.TabIndex = 28;
            this.upID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // F_Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Actualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProduto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtvProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown upPreco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.NumericUpDown upID;
    }
}