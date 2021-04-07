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
    public partial class F_Actualizar : Form
    {
        public Validar validar = new Validar();
        private Operacoes operacao = new Operacoes();
        public F_Actualizar()
        {
            InitializeComponent();
        }

        private void AdicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Adicionar fAdicionar = new F_Adicionar();
            fAdicionar.FormClosed += (s, args) => this.Close();
            fAdicionar.Show();
            this.Hide();
        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Eliminar fe = new F_Eliminar();
            fe.FormClosed += (s, args) => this.Close();
            fe.Show();
            this.Hide();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            dtvProduto.DataSource = (operacao.pegaProdutoId((int) upID.Value));
            MessageBox.Show(operacao.getMensagem);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                validar.Campo(txtNome.Text);
                validar.Campo(txtMarca.Text);
                if (upPreco.Value <= 0)
                {
                    throw new ArgumentException();
                }
                int c= (int) MessageBox.Show("Tem a certeza que deseja modificar essas informacoes?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (c == 1)
                {
                    operacao.actualizarProduto((int)upID.Value, txtMarca.Text, txtNome.Text, (float)upPreco.Value);
                    MessageBox.Show(operacao.getMensagem, "Relatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Preencha os campos com valores validos", "Campos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
