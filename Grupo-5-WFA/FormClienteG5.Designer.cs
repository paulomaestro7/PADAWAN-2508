namespace Grupo_5_WFA
{
    partial class FormClienteG5
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
			this.lbl_Titulo = new System.Windows.Forms.Label();
			this.lbl_Nome = new System.Windows.Forms.Label();
			this.lbl_Sobrenome = new System.Windows.Forms.Label();
			this.lbl_Cpf = new System.Windows.Forms.Label();
			this.txt_NomeCliente = new System.Windows.Forms.TextBox();
			this.txt_SobrenomeCliente = new System.Windows.Forms.TextBox();
			this.txt_CpfCliente = new System.Windows.Forms.TextBox();
			this.btn_GravarCliente = new System.Windows.Forms.Button();
			this.lbl_DataNascimentoCliente = new System.Windows.Forms.Label();
			this.txt_DataNascimentoCliente = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbl_Titulo
			// 
			this.lbl_Titulo.AutoSize = true;
			this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_Titulo.Location = new System.Drawing.Point(35, 40);
			this.lbl_Titulo.Name = "lbl_Titulo";
			this.lbl_Titulo.Size = new System.Drawing.Size(192, 25);
			this.lbl_Titulo.TabIndex = 0;
			this.lbl_Titulo.Text = "Cadastro de Clientes";
			// 
			// lbl_Nome
			// 
			this.lbl_Nome.AutoSize = true;
			this.lbl_Nome.Location = new System.Drawing.Point(35, 108);
			this.lbl_Nome.Name = "lbl_Nome";
			this.lbl_Nome.Size = new System.Drawing.Size(43, 15);
			this.lbl_Nome.TabIndex = 1;
			this.lbl_Nome.Text = "Nome:";
			// 
			// lbl_Sobrenome
			// 
			this.lbl_Sobrenome.AutoSize = true;
			this.lbl_Sobrenome.Location = new System.Drawing.Point(35, 142);
			this.lbl_Sobrenome.Name = "lbl_Sobrenome";
			this.lbl_Sobrenome.Size = new System.Drawing.Size(71, 15);
			this.lbl_Sobrenome.TabIndex = 1;
			this.lbl_Sobrenome.Text = "Sobrenome:";
			// 
			// lbl_Cpf
			// 
			this.lbl_Cpf.AutoSize = true;
			this.lbl_Cpf.Location = new System.Drawing.Point(35, 178);
			this.lbl_Cpf.Name = "lbl_Cpf";
			this.lbl_Cpf.Size = new System.Drawing.Size(34, 15);
			this.lbl_Cpf.TabIndex = 1;
			this.lbl_Cpf.Text = "CPF: ";
			// 
			// txt_NomeCliente
			// 
			this.txt_NomeCliente.Location = new System.Drawing.Point(166, 105);
			this.txt_NomeCliente.Name = "txt_NomeCliente";
			this.txt_NomeCliente.Size = new System.Drawing.Size(75, 23);
			this.txt_NomeCliente.TabIndex = 2;
			// 
			// txt_SobrenomeCliente
			// 
			this.txt_SobrenomeCliente.Location = new System.Drawing.Point(166, 139);
			this.txt_SobrenomeCliente.Name = "txt_SobrenomeCliente";
			this.txt_SobrenomeCliente.Size = new System.Drawing.Size(75, 23);
			this.txt_SobrenomeCliente.TabIndex = 2;
			// 
			// txt_CpfCliente
			// 
			this.txt_CpfCliente.Location = new System.Drawing.Point(166, 175);
			this.txt_CpfCliente.Name = "txt_CpfCliente";
			this.txt_CpfCliente.Size = new System.Drawing.Size(75, 23);
			this.txt_CpfCliente.TabIndex = 2;
			// 
			// btn_GravarCliente
			// 
			this.btn_GravarCliente.Location = new System.Drawing.Point(50, 264);
			this.btn_GravarCliente.Name = "btn_GravarCliente";
			this.btn_GravarCliente.Size = new System.Drawing.Size(177, 54);
			this.btn_GravarCliente.TabIndex = 3;
			this.btn_GravarCliente.Text = "Gravar Cliente";
			this.btn_GravarCliente.UseVisualStyleBackColor = true;
			this.btn_GravarCliente.Click += new System.EventHandler(this.btn_GravarCliente_Click);
			// 
			// lbl_DataNascimentoCliente
			// 
			this.lbl_DataNascimentoCliente.AutoSize = true;
			this.lbl_DataNascimentoCliente.Location = new System.Drawing.Point(35, 215);
			this.lbl_DataNascimentoCliente.Name = "lbl_DataNascimentoCliente";
			this.lbl_DataNascimentoCliente.Size = new System.Drawing.Size(115, 15);
			this.lbl_DataNascimentoCliente.TabIndex = 1;
			this.lbl_DataNascimentoCliente.Text = "Data de nascimento:";
			// 
			// txt_DataNascimentoCliente
			// 
			this.txt_DataNascimentoCliente.Location = new System.Drawing.Point(166, 212);
			this.txt_DataNascimentoCliente.Name = "txt_DataNascimentoCliente";
			this.txt_DataNascimentoCliente.Size = new System.Drawing.Size(75, 23);
			this.txt_DataNascimentoCliente.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 347);
			this.Controls.Add(this.txt_DataNascimentoCliente);
			this.Controls.Add(this.lbl_DataNascimentoCliente);
			this.Controls.Add(this.btn_GravarCliente);
			this.Controls.Add(this.txt_CpfCliente);
			this.Controls.Add(this.txt_SobrenomeCliente);
			this.Controls.Add(this.txt_NomeCliente);
			this.Controls.Add(this.lbl_Cpf);
			this.Controls.Add(this.lbl_Sobrenome);
			this.Controls.Add(this.lbl_Nome);
			this.Controls.Add(this.lbl_Titulo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lbl_Titulo;
		private System.Windows.Forms.Label lbl_Nome;
		private System.Windows.Forms.Label lbl_Sobrenome;
		private System.Windows.Forms.Label lbl_Cpf;
		private System.Windows.Forms.TextBox txt_NomeCliente;
		private System.Windows.Forms.TextBox txt_SobrenomeCliente;
		private System.Windows.Forms.TextBox txt_CpfCliente;
		private System.Windows.Forms.Button btn_GravarCliente;
		private System.Windows.Forms.Label lbl_DataNascimentoCliente;
		private System.Windows.Forms.TextBox txt_DataNascimentoCliente;
	}
}

