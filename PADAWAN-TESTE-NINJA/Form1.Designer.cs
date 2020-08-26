namespace PADAWAN_TESTE_NINJA
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Sobre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.txt_ResultJson = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(198, 26);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(165, 23);
            this.txt_Nome.TabIndex = 4;
            this.txt_Nome.Text = "Teste";
            // 
            // txt_Sobre
            // 
            this.txt_Sobre.Location = new System.Drawing.Point(198, 66);
            this.txt_Sobre.Name = "txt_Sobre";
            this.txt_Sobre.Size = new System.Drawing.Size(165, 20);
            this.txt_Sobre.TabIndex = 7;
            this.txt_Sobre.Text = "Teste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sobrenome";
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(37, 103);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(165, 94);
            this.btn_Gravar.TabIndex = 8;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(37, 231);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(581, 107);
            this.btn_Print.TabIndex = 9;
            this.btn_Print.Text = "button2";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // txt_ResultJson
            // 
            this.txt_ResultJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ResultJson.Location = new System.Drawing.Point(246, 103);
            this.txt_ResultJson.Multiline = true;
            this.txt_ResultJson.Name = "txt_ResultJson";
            this.txt_ResultJson.Size = new System.Drawing.Size(372, 94);
            this.txt_ResultJson.TabIndex = 10;
            this.txt_ResultJson.Text = "Teste";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 62);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Teste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 445);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_ResultJson);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.txt_Sobre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Sobre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.TextBox txt_ResultJson;
        private System.Windows.Forms.TextBox textBox1;
    }
}

