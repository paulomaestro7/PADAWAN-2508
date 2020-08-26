namespace Grupo_2_WFA
{
    partial class Login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 0;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(49, 155);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(37, 15);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(49, 199);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(39, 15);
            this.lbl_Senha.TabIndex = 2;
            this.lbl_Senha.Text = "Senha";
            this.lbl_Senha.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(168, 239);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 4;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.comboBox1.Location = new System.Drawing.Point(388, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(427, 155);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(39, 15);
            this.lbl_Status.TabIndex = 1;
            this.lbl_Status.Text = "Status";
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(639, 449);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Endereco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_Status;
    }
}

