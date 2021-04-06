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
    public partial class F_Adicionar : Form
    {
        public F_Adicionar()
        {
            InitializeComponent();
        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Eliminar fe = new F_Eliminar();
            fe.FormClosed += (s, args) => this.Close();
            fe.Show();
            this.Hide();
        }

        private void ActualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Actualizar fa = new F_Actualizar();
            fa.FormClosed += (s, args) => this.Close();
            fa.Show();
            this.Hide();
        }
    }
}
