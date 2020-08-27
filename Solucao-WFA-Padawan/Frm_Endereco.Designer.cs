namespace Solucao_WFA_Padawan
{
    partial class Frm_Endereco
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
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.Txt_Endereco = new System.Windows.Forms.TextBox();
            this.Lbl_Number = new System.Windows.Forms.Label();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Txt_Cep = new System.Windows.Forms.TextBox();
            this.Lbl_ZipCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Location = new System.Drawing.Point(37, 70);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(56, 15);
            this.Lbl_Address.TabIndex = 0;
            this.Lbl_Address.Text = "Endereço";
            // 
            // Txt_Endereco
            // 
            this.Txt_Endereco.Location = new System.Drawing.Point(37, 88);
            this.Txt_Endereco.Name = "Txt_Endereco";
            this.Txt_Endereco.Size = new System.Drawing.Size(327, 23);
            this.Txt_Endereco.TabIndex = 1;
            // 
            // Lbl_Number
            // 
            this.Lbl_Number.AutoSize = true;
            this.Lbl_Number.Location = new System.Drawing.Point(38, 118);
            this.Lbl_Number.Name = "Lbl_Number";
            this.Lbl_Number.Size = new System.Drawing.Size(51, 15);
            this.Lbl_Number.TabIndex = 0;
            this.Lbl_Number.Text = "Número";
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.Location = new System.Drawing.Point(38, 136);
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(159, 23);
            this.Txt_Numero.TabIndex = 2;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(38, 185);
            this.Btn_Salvar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(327, 46);
            this.Btn_Salvar.TabIndex = 3;
            this.Btn_Salvar.Text = "Cadastrar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Txt_Cep
            // 
            this.Txt_Cep.Location = new System.Drawing.Point(38, 38);
            this.Txt_Cep.Name = "Txt_Cep";
            this.Txt_Cep.PasswordChar = '*';
            this.Txt_Cep.Size = new System.Drawing.Size(161, 23);
            this.Txt_Cep.TabIndex = 0;
            // 
            // Lbl_ZipCode
            // 
            this.Lbl_ZipCode.AutoSize = true;
            this.Lbl_ZipCode.Location = new System.Drawing.Point(38, 20);
            this.Lbl_ZipCode.Name = "Lbl_ZipCode";
            this.Lbl_ZipCode.Size = new System.Drawing.Size(28, 15);
            this.Lbl_ZipCode.TabIndex = 0;
            this.Lbl_ZipCode.Text = "Cep";
            // 
            // Frm_Endereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 262);
            this.Controls.Add(this.Lbl_ZipCode);
            this.Controls.Add(this.Txt_Cep);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Txt_Numero);
            this.Controls.Add(this.Lbl_Number);
            this.Controls.Add(this.Txt_Endereco);
            this.Controls.Add(this.Lbl_Address);
            this.Name = "Frm_Endereco";
            this.Text = "Frm_Endereco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Address;
        private System.Windows.Forms.TextBox Txt_Endereco;
        private System.Windows.Forms.Label Lbl_Number;
        private System.Windows.Forms.TextBox Txt_Numero;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox Txt_Cep;
        private System.Windows.Forms.Label Lbl_ZipCode;
        private System.Windows.Forms.Button Btn_Salvar;
    }
}