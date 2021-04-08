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
    public partial class F_compra : Form
    {
        private Validar validar = new Validar();
        private Operacoes operacao = new Operacoes();
        public F_compra()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                validar.Campo(txtProduto.Text);
                string termo = cbTermo.Text;
                if (termo.Equals("Id"))
                {
                    dtvProd.DataSource = operacao.pegaProdutoId(int.Parse(txtProduto.Text));
                    MessageBox.Show(operacao.getMensagem);
                }
                else
                {
                    if (termo.Equals("Marca"))
                    {
                        dtvProd.DataSource = operacao.pegaProdutoMarca(txtProduto.Text);
                        MessageBox.Show(operacao.getMensagem);
                    }
                    else
                    {
                        dtvProd.DataSource = operacao.pegaProdutoNome(txtProduto.Text);
                        MessageBox.Show(operacao.getMensagem);
                    }
                }

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Preencha o campo", "Entrada invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira um numero Inteiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
