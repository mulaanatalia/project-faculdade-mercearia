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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Mostra a tela de actualizar
            F_Actualizar fa = new F_Actualizar();
            fa.FormClosed += (s, args)=> this.Show();
            fa.Show();
            this.Hide();

        }
    }
}
