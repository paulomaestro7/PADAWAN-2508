namespace Solucao_WFA_Padawan
{
    partial class Frm_Login
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
            this.Lbl_User = new System.Windows.Forms.Label();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Lbl_CreateUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_User
            // 
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.Location = new System.Drawing.Point(37, 31);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(47, 15);
            this.Lbl_User.TabIndex = 0;
            this.Lbl_User.Text = "Usuário";
            this.Lbl_User.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(37, 49);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(198, 23);
            this.Txt_Login.TabIndex = 0;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(37, 143);
            this.Btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(198, 46);
            this.Btn_Login.TabIndex = 2;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(37, 86);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(39, 15);
            this.Lbl_Password.TabIndex = 0;
            this.Lbl_Password.Text = "Senha";
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(37, 103);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '#';
            this.Txt_Senha.Size = new System.Drawing.Size(198, 23);
            this.Txt_Senha.TabIndex = 1;
            // 
            // Lbl_CreateUser
            // 
            this.Lbl_CreateUser.AutoSize = true;
            this.Lbl_CreateUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_CreateUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Lbl_CreateUser.Location = new System.Drawing.Point(37, 205);
            this.Lbl_CreateUser.Name = "Lbl_CreateUser";
            this.Lbl_CreateUser.Size = new System.Drawing.Size(104, 15);
            this.Lbl_CreateUser.TabIndex = 3;
            this.Lbl_CreateUser.Text = "Cadastrar Usuário";
            this.Lbl_CreateUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 240);
            this.Controls.Add(this.Lbl_CreateUser);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.Lbl_User);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.TextBox Txt_Login;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label Lbl_CreateUser;
    }
}