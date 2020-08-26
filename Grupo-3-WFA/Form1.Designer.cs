namespace Grupo_3_WFA
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.lbl_Confirma = new System.Windows.Forms.Label();
            this.btn_zerar = new System.Windows.Forms.Button();
            this.lbl_Apagar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefone:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(150, 91);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(182, 23);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(150, 128);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(182, 23);
            this.txt_Telefone.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(339, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente";
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(150, 191);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(102, 33);
            this.btn_Gravar.TabIndex = 2;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // lbl_Confirma
            // 
            this.lbl_Confirma.AutoSize = true;
            this.lbl_Confirma.Location = new System.Drawing.Point(282, 200);
            this.lbl_Confirma.Name = "lbl_Confirma";
            this.lbl_Confirma.Size = new System.Drawing.Size(0, 15);
            this.lbl_Confirma.TabIndex = 3;
            // 
            // btn_zerar
            // 
            this.btn_zerar.Location = new System.Drawing.Point(150, 270);
            this.btn_zerar.Name = "btn_zerar";
            this.btn_zerar.Size = new System.Drawing.Size(102, 28);
            this.btn_zerar.TabIndex = 4;
            this.btn_zerar.Text = "Zerar Arquivo";
            this.btn_zerar.UseVisualStyleBackColor = true;
            this.btn_zerar.Click += new System.EventHandler(this.btn_zerar_Click);
            // 
            // lbl_Apagar
            // 
            this.lbl_Apagar.AutoSize = true;
            this.lbl_Apagar.Location = new System.Drawing.Point(282, 277);
            this.lbl_Apagar.Name = "lbl_Apagar";
            this.lbl_Apagar.Size = new System.Drawing.Size(0, 15);
            this.lbl_Apagar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Apagar);
            this.Controls.Add(this.btn_zerar);
            this.Controls.Add(this.lbl_Confirma);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Label lbl_Confirma;
        private System.Windows.Forms.Button btn_zerar;
        private System.Windows.Forms.Label lbl_Apagar;
    }
}

