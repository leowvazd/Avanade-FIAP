using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLIntegration.Negócios
{
    class Cliente
    {
        public int codigo;
        public string nome;
        public string endereco;
        public string email;

        public Cliente()
        {
            codigo = 0;
            nome = "";
            endereco = "";
            email = "";
        }

        public Cliente(int codigo, string nome, string endereco, string email)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.endereco = endereco;
            this.email = email;
        }
    }
}
