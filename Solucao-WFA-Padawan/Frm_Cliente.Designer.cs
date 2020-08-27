namespace Solucao_WFA_Padawan
{
    partial class Frm_Cliente
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
            this.Txt_Nascimento = new System.Windows.Forms.TextBox();
            this.Lbl_Birth = new System.Windows.Forms.Label();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Txt_Cpf = new System.Windows.Forms.TextBox();
            this.Lbl_Cpf = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Rbl_Masculino = new System.Windows.Forms.RadioButton();
            this.Lbl_Male = new System.Windows.Forms.Label();
            this.Rbl_Feminino = new System.Windows.Forms.RadioButton();
            this.Rbl_NaoBinario = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Txt_Nascimento
            // 
            this.Txt_Nascimento.Location = new System.Drawing.Point(205, 91);
            this.Txt_Nascimento.Name = "Txt_Nascimento";
            this.Txt_Nascimento.Size = new System.Drawing.Size(161, 23);
            this.Txt_Nascimento.TabIndex = 2;
            // 
            // Lbl_Birth
            // 
            this.Lbl_Birth.AutoSize = true;
            this.Lbl_Birth.Location = new System.Drawing.Point(205, 73);
            this.Lbl_Birth.Name = "Lbl_Birth";
            this.Lbl_Birth.Size = new System.Drawing.Size(98, 15);
            this.Lbl_Birth.TabIndex = 0;
            this.Lbl_Birth.Text = "Data Nascimento";
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(39, 189);
            this.Btn_Salvar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(327, 46);
            this.Btn_Salvar.TabIndex = 6;
            this.Btn_Salvar.Text = "Cadastrar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Txt_Cpf
            // 
            this.Txt_Cpf.Location = new System.Drawing.Point(39, 91);
            this.Txt_Cpf.Name = "Txt_Cpf";
            this.Txt_Cpf.Size = new System.Drawing.Size(159, 23);
            this.Txt_Cpf.TabIndex = 1;
            // 
            // Lbl_Cpf
            // 
            this.Lbl_Cpf.AutoSize = true;
            this.Lbl_Cpf.Location = new System.Drawing.Point(39, 73);
            this.Lbl_Cpf.Name = "Lbl_Cpf";
            this.Lbl_Cpf.Size = new System.Drawing.Size(26, 15);
            this.Lbl_Cpf.TabIndex = 0;
            this.Lbl_Cpf.Text = "Cpf";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(39, 37);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(327, 23);
            this.Txt_Nome.TabIndex = 0;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(39, 19);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(40, 15);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "Nome";
            // 
            // Rbl_Masculino
            // 
            this.Rbl_Masculino.AutoSize = true;
            this.Rbl_Masculino.Location = new System.Drawing.Point(39, 150);
            this.Rbl_Masculino.Name = "Rbl_Masculino";
            this.Rbl_Masculino.Size = new System.Drawing.Size(80, 19);
            this.Rbl_Masculino.TabIndex = 3;
            this.Rbl_Masculino.TabStop = true;
            this.Rbl_Masculino.Text = "Masculino";
            this.Rbl_Masculino.UseVisualStyleBackColor = true;
            this.Rbl_Masculino.CheckedChanged += new System.EventHandler(this.Rbl_Masculino_CheckedChanged);
            // 
            // Lbl_Male
            // 
            this.Lbl_Male.AutoSize = true;
            this.Lbl_Male.Location = new System.Drawing.Point(39, 132);
            this.Lbl_Male.Name = "Lbl_Male";
            this.Lbl_Male.Size = new System.Drawing.Size(32, 15);
            this.Lbl_Male.TabIndex = 0;
            this.Lbl_Male.Text = "Sexo";
            // 
            // Rbl_Feminino
            // 
            this.Rbl_Feminino.AutoSize = true;
            this.Rbl_Feminino.Location = new System.Drawing.Point(125, 150);
            this.Rbl_Feminino.Name = "Rbl_Feminino";
            this.Rbl_Feminino.Size = new System.Drawing.Size(75, 19);
            this.Rbl_Feminino.TabIndex = 4;
            this.Rbl_Feminino.TabStop = true;
            this.Rbl_Feminino.Text = "Feminino";
            this.Rbl_Feminino.UseVisualStyleBackColor = true;
            this.Rbl_Feminino.CheckedChanged += new System.EventHandler(this.Rbl_Feminino_CheckedChanged);
            // 
            // Rbl_NaoBinario
            // 
            this.Rbl_NaoBinario.AutoSize = true;
            this.Rbl_NaoBinario.Location = new System.Drawing.Point(206, 150);
            this.Rbl_NaoBinario.Name = "Rbl_NaoBinario";
            this.Rbl_NaoBinario.Size = new System.Drawing.Size(87, 19);
            this.Rbl_NaoBinario.TabIndex = 4;
            this.Rbl_NaoBinario.TabStop = true;
            this.Rbl_NaoBinario.Text = "Não Binário";
            this.Rbl_NaoBinario.UseVisualStyleBackColor = true;
            this.Rbl_NaoBinario.CheckedChanged += new System.EventHandler(this.Rbl_NaoBinario_CheckedChanged);
            // 
            // Frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 271);
            this.Controls.Add(this.Rbl_NaoBinario);
            this.Controls.Add(this.Rbl_Feminino);
            this.Controls.Add(this.Lbl_Male);
            this.Controls.Add(this.Rbl_Masculino);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Lbl_Cpf);
            this.Controls.Add(this.Txt_Cpf);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Lbl_Birth);
            this.Controls.Add(this.Txt_Nascimento);
            this.Name = "Frm_Cliente";
            this.Text = "Frm_Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nascimento;
        private System.Windows.Forms.Label Lbl_Birth;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.TextBox Txt_Cpf;
        private System.Windows.Forms.Label Lbl_Cpf;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.RadioButton Rbl_Masculino;
        private System.Windows.Forms.Label Lbl_Male;
        private System.Windows.Forms.RadioButton Rbl_Feminino;
        private System.Windows.Forms.RadioButton Rbl_NaoBinario;
    }
}