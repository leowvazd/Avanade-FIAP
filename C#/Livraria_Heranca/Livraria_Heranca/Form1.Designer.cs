
namespace Livraria_Heranca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageDVD = new System.Windows.Forms.TabControl();
            this.TabPageLivro = new System.Windows.Forms.TabPage();
            this.btnListarLivro = new System.Windows.Forms.Button();
            this.btnVenderVender = new System.Windows.Forms.Button();
            this.btnComprarLivro = new System.Windows.Forms.Button();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.txtEdição = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditora2 = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageCD = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVenderCD = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnComprarCD = new System.Windows.Forms.Button();
            this.txtGravadora = new System.Windows.Forms.TextBox();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnCadastrarCD = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVenderDVD = new System.Windows.Forms.Button();
            this.btnComprarDVD = new System.Windows.Forms.Button();
            this.btnCadastrarDVD = new System.Windows.Forms.Button();
            this.txtCensura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPageDVD.SuspendLayout();
            this.TabPageLivro.SuspendLayout();
            this.tabPageCD.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição do Produto:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(28, 44);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(345, 23);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(28, 100);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(345, 23);
            this.txtGenero.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genêro do Produto:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(29, 160);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(165, 23);
            this.txtEstoque.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estoque do Produto:";
            // 
            // tabPageDVD
            // 
            this.tabPageDVD.Controls.Add(this.TabPageLivro);
            this.tabPageDVD.Controls.Add(this.tabPageCD);
            this.tabPageDVD.Controls.Add(this.tabPage1);
            this.tabPageDVD.Location = new System.Drawing.Point(26, 272);
            this.tabPageDVD.Name = "tabPageDVD";
            this.tabPageDVD.SelectedIndex = 0;
            this.tabPageDVD.Size = new System.Drawing.Size(345, 252);
            this.tabPageDVD.TabIndex = 6;
            // 
            // TabPageLivro
            // 
            this.TabPageLivro.Controls.Add(this.btnListarLivro);
            this.TabPageLivro.Controls.Add(this.btnVenderVender);
            this.TabPageLivro.Controls.Add(this.btnComprarLivro);
            this.TabPageLivro.Controls.Add(this.btnCadastrarLivro);
            this.TabPageLivro.Controls.Add(this.txtEdição);
            this.TabPageLivro.Controls.Add(this.label5);
            this.TabPageLivro.Controls.Add(this.txtEditora2);
            this.TabPageLivro.Controls.Add(this.txtEditora);
            this.TabPageLivro.Controls.Add(this.txtAutor);
            this.TabPageLivro.Controls.Add(this.label4);
            this.TabPageLivro.Location = new System.Drawing.Point(4, 24);
            this.TabPageLivro.Name = "TabPageLivro";
            this.TabPageLivro.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageLivro.Size = new System.Drawing.Size(337, 224);
            this.TabPageLivro.TabIndex = 0;
            this.TabPageLivro.Text = "Livro";
            this.TabPageLivro.UseVisualStyleBackColor = true;
            // 
            // btnListarLivro
            // 
            this.btnListarLivro.Location = new System.Drawing.Point(171, 180);
            this.btnListarLivro.Name = "btnListarLivro";
            this.btnListarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnListarLivro.TabIndex = 9;
            this.btnListarLivro.Text = "Listar";
            this.btnListarLivro.UseVisualStyleBackColor = true;
            this.btnListarLivro.Click += new System.EventHandler(this.btnListarLivro_Click);
            // 
            // btnVenderVender
            // 
            this.btnVenderVender.Location = new System.Drawing.Point(254, 180);
            this.btnVenderVender.Name = "btnVenderVender";
            this.btnVenderVender.Size = new System.Drawing.Size(75, 23);
            this.btnVenderVender.TabIndex = 8;
            this.btnVenderVender.Text = "Vender";
            this.btnVenderVender.UseVisualStyleBackColor = true;
            this.btnVenderVender.Click += new System.EventHandler(this.btnVenderVender_Click);
            // 
            // btnComprarLivro
            // 
            this.btnComprarLivro.Location = new System.Drawing.Point(90, 180);
            this.btnComprarLivro.Name = "btnComprarLivro";
            this.btnComprarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnComprarLivro.TabIndex = 7;
            this.btnComprarLivro.Text = "Comprar";
            this.btnComprarLivro.UseVisualStyleBackColor = true;
            this.btnComprarLivro.Click += new System.EventHandler(this.btnComprarLivro_Click);
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Location = new System.Drawing.Point(6, 180);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarLivro.TabIndex = 6;
            this.btnCadastrarLivro.Text = "Cadastrar";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // txtEdição
            // 
            this.txtEdição.Location = new System.Drawing.Point(6, 130);
            this.txtEdição.Name = "txtEdição";
            this.txtEdição.Size = new System.Drawing.Size(324, 23);
            this.txtEdição.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edição:";
            // 
            // txtEditora2
            // 
            this.txtEditora2.Location = new System.Drawing.Point(5, 76);
            this.txtEditora2.Name = "txtEditora2";
            this.txtEditora2.Size = new System.Drawing.Size(324, 23);
            this.txtEditora2.TabIndex = 3;
            // 
            // txtEditora
            // 
            this.txtEditora.AutoSize = true;
            this.txtEditora.Location = new System.Drawing.Point(5, 57);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(47, 15);
            this.txtEditora.TabIndex = 2;
            this.txtEditora.Text = "Editora:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(6, 22);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(324, 23);
            this.txtAutor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Autor:";
            // 
            // tabPageCD
            // 
            this.tabPageCD.Controls.Add(this.button1);
            this.tabPageCD.Controls.Add(this.btnVenderCD);
            this.tabPageCD.Controls.Add(this.label12);
            this.tabPageCD.Controls.Add(this.label10);
            this.tabPageCD.Controls.Add(this.btnComprarCD);
            this.tabPageCD.Controls.Add(this.txtGravadora);
            this.tabPageCD.Controls.Add(this.txtArtista);
            this.tabPageCD.Controls.Add(this.txtPais);
            this.tabPageCD.Controls.Add(this.btnCadastrarCD);
            this.tabPageCD.Controls.Add(this.label11);
            this.tabPageCD.Location = new System.Drawing.Point(4, 24);
            this.tabPageCD.Name = "tabPageCD";
            this.tabPageCD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCD.Size = new System.Drawing.Size(337, 224);
            this.tabPageCD.TabIndex = 1;
            this.tabPageCD.Text = "CD";
            this.tabPageCD.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVenderCD
            // 
            this.btnVenderCD.Location = new System.Drawing.Point(254, 180);
            this.btnVenderCD.Name = "btnVenderCD";
            this.btnVenderCD.Size = new System.Drawing.Size(75, 23);
            this.btnVenderCD.TabIndex = 35;
            this.btnVenderCD.Text = "Vender";
            this.btnVenderCD.UseVisualStyleBackColor = true;
            this.btnVenderCD.Click += new System.EventHandler(this.btnVenderCD_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Artista:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "País de Origem:";
            // 
            // btnComprarCD
            // 
            this.btnComprarCD.Location = new System.Drawing.Point(87, 180);
            this.btnComprarCD.Name = "btnComprarCD";
            this.btnComprarCD.Size = new System.Drawing.Size(75, 23);
            this.btnComprarCD.TabIndex = 34;
            this.btnComprarCD.Text = "Comprar";
            this.btnComprarCD.UseVisualStyleBackColor = true;
            this.btnComprarCD.Click += new System.EventHandler(this.btnComprarCD_Click);
            // 
            // txtGravadora
            // 
            this.txtGravadora.Location = new System.Drawing.Point(5, 76);
            this.txtGravadora.Name = "txtGravadora";
            this.txtGravadora.Size = new System.Drawing.Size(324, 23);
            this.txtGravadora.TabIndex = 30;
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(6, 22);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(324, 23);
            this.txtArtista.TabIndex = 28;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(6, 130);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(324, 23);
            this.txtPais.TabIndex = 32;
            // 
            // btnCadastrarCD
            // 
            this.btnCadastrarCD.Location = new System.Drawing.Point(6, 180);
            this.btnCadastrarCD.Name = "btnCadastrarCD";
            this.btnCadastrarCD.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCD.TabIndex = 33;
            this.btnCadastrarCD.Text = "Cadastrar";
            this.btnCadastrarCD.UseVisualStyleBackColor = true;
            this.btnCadastrarCD.Click += new System.EventHandler(this.btnCadastrarCD_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Gravadora:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnVenderDVD);
            this.tabPage1.Controls.Add(this.btnComprarDVD);
            this.tabPage1.Controls.Add(this.btnCadastrarDVD);
            this.tabPage1.Controls.Add(this.txtCensura);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtDuracao);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtDiretor);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(337, 224);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "DVD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Listar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVenderDVD
            // 
            this.btnVenderDVD.Location = new System.Drawing.Point(254, 180);
            this.btnVenderDVD.Name = "btnVenderDVD";
            this.btnVenderDVD.Size = new System.Drawing.Size(75, 23);
            this.btnVenderDVD.TabIndex = 17;
            this.btnVenderDVD.Text = "Vender";
            this.btnVenderDVD.UseVisualStyleBackColor = true;
            this.btnVenderDVD.Click += new System.EventHandler(this.btnVenderDVD_Click);
            // 
            // btnComprarDVD
            // 
            this.btnComprarDVD.Location = new System.Drawing.Point(87, 180);
            this.btnComprarDVD.Name = "btnComprarDVD";
            this.btnComprarDVD.Size = new System.Drawing.Size(75, 23);
            this.btnComprarDVD.TabIndex = 16;
            this.btnComprarDVD.Text = "Comprar";
            this.btnComprarDVD.UseVisualStyleBackColor = true;
            this.btnComprarDVD.Click += new System.EventHandler(this.btnComprarDVD_Click);
            // 
            // btnCadastrarDVD
            // 
            this.btnCadastrarDVD.Location = new System.Drawing.Point(6, 180);
            this.btnCadastrarDVD.Name = "btnCadastrarDVD";
            this.btnCadastrarDVD.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarDVD.TabIndex = 15;
            this.btnCadastrarDVD.Text = "Cadastrar";
            this.btnCadastrarDVD.UseVisualStyleBackColor = true;
            this.btnCadastrarDVD.Click += new System.EventHandler(this.btnCadastrarDVD_Click);
            // 
            // txtCensura
            // 
            this.txtCensura.Location = new System.Drawing.Point(6, 130);
            this.txtCensura.Name = "txtCensura";
            this.txtCensura.Size = new System.Drawing.Size(324, 23);
            this.txtCensura.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Censura:";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(5, 76);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(324, 23);
            this.txtDuracao.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Duração:";
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(6, 22);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(324, 23);
            this.txtDiretor.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Diretor:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(206, 160);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(165, 23);
            this.txtPreco.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Preço do Produto:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(30, 220);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(165, 23);
            this.txtQuantidade.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "QTD Compra ou Venda:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 593);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabPageDVD);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPageDVD.ResumeLayout(false);
            this.TabPageLivro.ResumeLayout(false);
            this.TabPageLivro.PerformLayout();
            this.tabPageCD.ResumeLayout(false);
            this.tabPageCD.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabPageDVD;
        private System.Windows.Forms.TabPage TabPageLivro;
        private System.Windows.Forms.TabPage tabPageCD;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnVenderVender;
        private System.Windows.Forms.Button btnComprarLivro;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.TextBox txtEdição;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEditora2;
        private System.Windows.Forms.Label txtEditora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVenderCD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnComprarCD;
        private System.Windows.Forms.TextBox txtGravadora;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button btnCadastrarCD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVenderDVD;
        private System.Windows.Forms.Button btnComprarDVD;
        private System.Windows.Forms.Button btnCadastrarDVD;
        private System.Windows.Forms.TextBox txtCensura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnListarLivro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

