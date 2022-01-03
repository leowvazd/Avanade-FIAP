using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Usuario
{
    public class Usuario
    {
        // ATRIBUTOS:
        public string nome { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        
        // CONSTRUTOR:
        // Método que é executado quando um objeto é instanciado.
        public Usuario()
        {
            // Pelo menos, "zerar" os objetos 

            this.nome = "";
            this.email = "";
            this.login = "";
            this.senha = "";
        }

        public void provarExistencia()
        {
            MessageBox.Show("Olá " + this.nome + "!!!");
        }
    }
}
