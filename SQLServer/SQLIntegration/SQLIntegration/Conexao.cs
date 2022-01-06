using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLIntegration
{
    class Conexao
    {
        string strCon;
        SqlConnection con;

        public Conexao()
        {
            strCon = "Data Source=WINAPCVODEH6WW3;" +           // Servidor SQL Server
                     "Initial Catalog=conexao;" +             // Banco que será conectado
                     "Integrated Security=True";         // Ativando a segurança integrada do Windows
        }

        public SqlConnection GetConnection()
        {
            con = new SqlConnection(strCon);

            try
            {
                con.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar o banco\n" + ex.Message);
            }

            return con;
        }
    }
}
