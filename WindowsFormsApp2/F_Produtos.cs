using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class F_Produtos : Form
    {
        private Operacoes operacao = new Operacoes();
        public F_Produtos()
        {
            InitializeComponent();
        }

        private void F_Produtos_Load(object sender, EventArgs e)
        {
            try{
                dtvProdutos.DataSource = operacao.pegaTabelaProduto();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao mostrar tabela Produto");
            }
        }
    }
}
