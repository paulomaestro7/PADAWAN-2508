namespace Grupo_5_WFA
{
    partial class FormEnderecoG5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Rua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_Complemento = new System.Windows.Forms.TextBox();
            this.txt_Localidade = new System.Windows.Forms.TextBox();
            this.txt_UF = new System.Windows.Forms.TextBox();
            this.btn_GravarEndereco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Localidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "UF:";
            // 
            // txt_Rua
            // 
            this.txt_Rua.Location = new System.Drawing.Point(219, 93);
            this.txt_Rua.Name = "txt_Rua";
            this.txt_Rua.Size = new System.Drawing.Size(181, 23);
            this.txt_Rua.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Complemento:";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(219, 125);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(181, 23);
            this.txt_Numero.TabIndex = 3;
            // 
            // txt_Complemento
            // 
            this.txt_Complemento.Location = new System.Drawing.Point(219, 162);
            this.txt_Complemento.Name = "txt_Complemento";
            this.txt_Complemento.Size = new System.Drawing.Size(181, 23);
            this.txt_Complemento.TabIndex = 3;
            // 
            // txt_Localidade
            // 
            this.txt_Localidade.Location = new System.Drawing.Point(219, 196);
            this.txt_Localidade.Name = "txt_Localidade";
            this.txt_Localidade.Size = new System.Drawing.Size(181, 23);
            this.txt_Localidade.TabIndex = 3;
            // 
            // txt_UF
            // 
            this.txt_UF.Location = new System.Drawing.Point(219, 226);
            this.txt_UF.Name = "txt_UF";
            this.txt_UF.Size = new System.Drawing.Size(181, 23);
            this.txt_UF.TabIndex = 3;
            // 
            // btn_GravarEndereco
            // 
            this.btn_GravarEndereco.Location = new System.Drawing.Point(219, 272);
            this.btn_GravarEndereco.Name = "btn_GravarEndereco";
            this.btn_GravarEndereco.Size = new System.Drawing.Size(181, 76);
            this.btn_GravarEndereco.TabIndex = 5;
            this.btn_GravarEndereco.Text = "Gravar Endereço";
            this.btn_GravarEndereco.UseVisualStyleBackColor = true;
            this.btn_GravarEndereco.Click += new System.EventHandler(this.btn_GravarEndereco_Click);
            // 
            // formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 574);
            this.Controls.Add(this.btn_GravarEndereco);
            this.Controls.Add(this.txt_UF);
            this.Controls.Add(this.txt_Localidade);
            this.Controls.Add(this.txt_Complemento);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Rua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formulario";
            this.Load += new System.EventHandler(this.FormEnderecoG5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Rua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_Complemento;
        private System.Windows.Forms.TextBox txt_Localidade;
        private System.Windows.Forms.TextBox txt_UF;
        private System.Windows.Forms.Button btn_GravarEndereco;
    }
}