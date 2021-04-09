using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Validar
    {
        public void Campo(string campo)
        {
            if (string.IsNullOrEmpty(campo))
            {
                throw new ArgumentException();
            }
        }
        public void celulaSelecionada(int linha)
        {
            if (linha <= 0)
            {
                throw new ArgumentException();
            }
        }
        public void telefone(string tel)
        {
            if (((tel.Length < 9) && (tel.Length !=0)) || (tel.Length>9))
            {
                throw new FormatException();
            }
            else
            {
                if (!(string.IsNullOrEmpty(tel) || string.IsNullOrWhiteSpace(tel)))
                {
                    try
                    {
                        int.Parse(tel);
                    }
                    catch (Exception)
                    {
                        throw new FormatException();
                    }
                }
                
            }
        }
    }
}
