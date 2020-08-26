namespace Grupo_3_WFA
{
    partial class Menu
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
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_endereco = new System.Windows.Forms.Button();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELA MENU";
            // 
            // btn_cliente
            // 
            this.btn_cliente.Location = new System.Drawing.Point(347, 158);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(112, 34);
            this.btn_cliente.TabIndex = 1;
            this.btn_cliente.Text = "CLIENTE";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_endereco
            // 
            this.btn_endereco.Location = new System.Drawing.Point(347, 239);
            this.btn_endereco.Name = "btn_endereco";
            this.btn_endereco.Size = new System.Drawing.Size(112, 34);
            this.btn_endereco.TabIndex = 1;
            this.btn_endereco.Text = "ENDERECO";
            this.btn_endereco.UseVisualStyleBackColor = true;
            this.btn_endereco.Click += new System.EventHandler(this.btn_endereco_Click);
            // 
            // btn_usuario
            // 
            this.btn_usuario.Location = new System.Drawing.Point(347, 315);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(112, 34);
            this.btn_usuario.TabIndex = 1;
            this.btn_usuario.Text = "USUARIO";
            this.btn_usuario.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_usuario);
            this.Controls.Add(this.btn_endereco);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_endereco;
        private System.Windows.Forms.Button btn_usuario;
    }
}