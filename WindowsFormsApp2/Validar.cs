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
            if (campo == "")
            {
                throw new ArgumentException();
            }
        }
    }
}
