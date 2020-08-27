namespace Solucao_WFA_Padawan
{
    partial class Frm_Menu
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn_Endereco = new System.Windows.Forms.Button();
            this.Btn_Usuario = new System.Windows.Forms.Button();
            this.Btn_Cliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Btn_Endereco
            // 
            this.Btn_Endereco.Location = new System.Drawing.Point(217, 182);
            this.Btn_Endereco.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Endereco.Name = "Btn_Endereco";
            this.Btn_Endereco.Size = new System.Drawing.Size(327, 46);
            this.Btn_Endereco.TabIndex = 6;
            this.Btn_Endereco.Text = "Cadastrar Endereço";
            this.Btn_Endereco.UseVisualStyleBackColor = true;
            this.Btn_Endereco.Click += new System.EventHandler(this.Btn_Endereco_Click);
            // 
            // Btn_Usuario
            // 
            this.Btn_Usuario.Location = new System.Drawing.Point(217, 252);
            this.Btn_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Usuario.Name = "Btn_Usuario";
            this.Btn_Usuario.Size = new System.Drawing.Size(327, 46);
            this.Btn_Usuario.TabIndex = 6;
            this.Btn_Usuario.Text = "Cadastrar Usuário";
            this.Btn_Usuario.UseVisualStyleBackColor = true;
            this.Btn_Usuario.Click += new System.EventHandler(this.Btn_Usuario_Click);
            // 
            // Btn_Cliente
            // 
            this.Btn_Cliente.Location = new System.Drawing.Point(217, 113);
            this.Btn_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cliente.Name = "Btn_Cliente";
            this.Btn_Cliente.Size = new System.Drawing.Size(327, 46);
            this.Btn_Cliente.TabIndex = 6;
            this.Btn_Cliente.Text = "Cadastrar Cliente";
            this.Btn_Cliente.UseVisualStyleBackColor = true;
            this.Btn_Cliente.Click += new System.EventHandler(this.Btn_Cliente_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Cliente);
            this.Controls.Add(this.Btn_Usuario);
            this.Controls.Add(this.Btn_Endereco);
            this.Name = "Frm_Menu";
            this.Text = "Frm_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Btn_Endereco;
        private System.Windows.Forms.Button Btn_Usuario;
        private System.Windows.Forms.Button Btn_Cliente;
    }
}