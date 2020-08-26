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
            this.btn_voltarvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefone:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(214, 152);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(258, 31);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(214, 213);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(258, 31);
            this.txt_Telefone.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(484, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente";
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(214, 318);
            this.btn_Gravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(146, 55);
            this.btn_Gravar.TabIndex = 2;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // lbl_Confirma
            // 
            this.lbl_Confirma.AutoSize = true;
            this.lbl_Confirma.Location = new System.Drawing.Point(403, 333);
            this.lbl_Confirma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Confirma.Name = "lbl_Confirma";
            this.lbl_Confirma.Size = new System.Drawing.Size(0, 25);
            this.lbl_Confirma.TabIndex = 3;
            // 
            // btn_zerar
            // 
            this.btn_zerar.Location = new System.Drawing.Point(214, 450);
            this.btn_zerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_zerar.Name = "btn_zerar";
            this.btn_zerar.Size = new System.Drawing.Size(146, 47);
            this.btn_zerar.TabIndex = 4;
            this.btn_zerar.Text = "Zerar Arquivo";
            this.btn_zerar.UseVisualStyleBackColor = true;
            this.btn_zerar.Click += new System.EventHandler(this.btn_zerar_Click);
            // 
            // lbl_Apagar
            // 
            this.lbl_Apagar.AutoSize = true;
            this.lbl_Apagar.Location = new System.Drawing.Point(403, 462);
            this.lbl_Apagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Apagar.Name = "lbl_Apagar";
            this.lbl_Apagar.Size = new System.Drawing.Size(0, 25);
            this.lbl_Apagar.TabIndex = 5;
            // 
            // btn_voltarvoltar
            // 
            this.btn_voltarvoltar.Location = new System.Drawing.Point(225, 530);
            this.btn_voltarvoltar.Name = "btn_voltarvoltar";
            this.btn_voltarvoltar.Size = new System.Drawing.Size(112, 34);
            this.btn_voltarvoltar.TabIndex = 6;
            this.btn_voltarvoltar.Text = "Voltar";
            this.btn_voltarvoltar.UseVisualStyleBackColor = true;
            this.btn_voltarvoltar.Click += new System.EventHandler(this.btn_voltarvoltar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btn_voltarvoltar);
            this.Controls.Add(this.lbl_Apagar);
            this.Controls.Add(this.btn_zerar);
            this.Controls.Add(this.lbl_Confirma);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button btn_voltarvoltar;
    }
}

