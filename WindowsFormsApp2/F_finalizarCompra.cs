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
    public partial class F_finalizarCompra : Form
    {
        private Operacoes operacao = new Operacoes();
        private int quant;
        private string nom, bi, tel;
        public F_finalizarCompra(float vPagar, int quant, string nom, string bi, string tel)
        {
            InitializeComponent();
            lblVPagar.Text = vPagar.ToString();
            this.nom = nom;
            this.quant = quant;
            this.bi = bi;
            this.tel = tel;

        }
        public F_finalizarCompra(float vPagar, int quant)
        {
            InitializeComponent();
            lblVPagar.Text = vPagar.ToString();
            this.nom = "";
            this.quant = quant;
            this.bi = "";
            this.tel = "";

        }


        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            float trocos = float.Parse(lblVPagar.Text) - (float)upVrecebido.Value;
            if (trocos >= 0)
            {
                lblTrocos.Text = "0";
            }
            else
            {
                lblTrocos.Text = ((-1)*trocos).ToString();
            } 
        }

        private void LblTrocos_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float vR = (float) upVrecebido.Value;
            float vP = float.Parse(lblVPagar.Text);
            if (vR>=vP)
            {
                try
                {
                    if (string.IsNullOrEmpty(this.nom) || string.IsNullOrWhiteSpace(this.nom))
                    {
                        operacao.adicionarCompra(quant, (float)upVrecebido.Value);
                    }
                    else
                    {
                        operacao.adicionarCompraCompleta(quant, (float)upVrecebido.Value, nom.Split(), bi, tel);
                    }
                    MessageBox.Show(operacao.getMensagem, "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao finalizar a compra", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("O valor que inseriu e inferior ao valor total a pagar", "Insuficiencia de Fundos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void F_finalizarCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
