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
    }
}
