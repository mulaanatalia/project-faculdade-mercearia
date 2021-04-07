using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public class Conexao
    {
        private MySqlConnection con = new MySqlConnection();
        public Conexao()
        {
            con.ConnectionString = "server = localhost; database = mercearia;" +
                "user=root; password=;";
        }
        public MySqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void Desconectar()
        {
            if (con.State==System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
   
}
