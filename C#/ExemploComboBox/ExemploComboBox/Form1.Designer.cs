
namespace ExemploComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEscolha = new System.Windows.Forms.ComboBox();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEscolha
            // 
            this.cmbEscolha.FormattingEnabled = true;
            this.cmbEscolha.Items.AddRange(new object[] {
            "Ferrari",
            "Mercedes",
            "RedBull",
            "McLaren"});
            this.cmbEscolha.Location = new System.Drawing.Point(171, 60);
            this.cmbEscolha.Name = "cmbEscolha";
            this.cmbEscolha.Size = new System.Drawing.Size(121, 28);
            this.cmbEscolha.TabIndex = 0;
            // 
            // btnEscolha
            // 
            this.btnEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolha.Location = new System.Drawing.Point(193, 108);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(75, 35);
            this.btnEscolha.TabIndex = 1;
            this.btnEscolha.Text = "Checar";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEscolha;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 205);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.cmbEscolha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEscolha;
        private System.Windows.Forms.Button btnEscolha;
    }
}

