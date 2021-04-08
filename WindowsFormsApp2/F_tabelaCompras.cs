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
    public partial class F_tabelaCompras : Form
    {
        public F_tabelaCompras()
        {
            InitializeComponent();
        }

        private void DtvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Operacoes operacao = new Operacoes();
        private void F_tabelaCompras_Load(object sender, EventArgs e)
        {
            try
            {
                dtvCompras.DataSource = operacao.pegaTabelaCompra();
            }
            catch (Exception)
            {
                MessageBox.Show(operacao.getMensagem, "Erro");
            }
        }
    }
}
