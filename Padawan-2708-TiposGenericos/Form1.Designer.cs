namespace Padawan_2708_TiposGenericos
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
            this.Txt_Adicionar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Remover = new System.Windows.Forms.TextBox();
            this.Lista = new System.Windows.Forms.Label();
            this.Txt_Lista = new System.Windows.Forms.TextBox();
            this.Btn_Remover = new System.Windows.Forms.Button();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar";
            // 
            // Txt_Adicionar
            // 
            this.Txt_Adicionar.Location = new System.Drawing.Point(36, 42);
            this.Txt_Adicionar.Name = "Txt_Adicionar";
            this.Txt_Adicionar.Size = new System.Drawing.Size(150, 23);
            this.Txt_Adicionar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Remover";
            // 
            // Txt_Remover
            // 
            this.Txt_Remover.Location = new System.Drawing.Point(222, 42);
            this.Txt_Remover.Multiline = true;
            this.Txt_Remover.Name = "Txt_Remover";
            this.Txt_Remover.Size = new System.Drawing.Size(150, 23);
            this.Txt_Remover.TabIndex = 1;
            // 
            // Lista
            // 
            this.Lista.AutoSize = true;
            this.Lista.Location = new System.Drawing.Point(401, 23);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(31, 15);
            this.Lista.TabIndex = 0;
            this.Lista.Text = "Lista";
            // 
            // Txt_Lista
            // 
            this.Txt_Lista.Location = new System.Drawing.Point(401, 42);
            this.Txt_Lista.Multiline = true;
            this.Txt_Lista.Name = "Txt_Lista";
            this.Txt_Lista.Size = new System.Drawing.Size(348, 273);
            this.Txt_Lista.TabIndex = 1;
            // 
            // Btn_Remover
            // 
            this.Btn_Remover.Location = new System.Drawing.Point(222, 84);
            this.Btn_Remover.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Remover.Name = "Btn_Remover";
            this.Btn_Remover.Size = new System.Drawing.Size(150, 46);
            this.Btn_Remover.TabIndex = 6;
            this.Btn_Remover.Text = "Remover";
            this.Btn_Remover.UseVisualStyleBackColor = true;
            this.Btn_Remover.Click += new System.EventHandler(this.Btn_Remover_Click);
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.Location = new System.Drawing.Point(36, 84);
            this.Btn_Adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(150, 46);
            this.Btn_Adicionar.TabIndex = 6;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = true;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Adicionar);
            this.Controls.Add(this.Btn_Remover);
            this.Controls.Add(this.Txt_Lista);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.Txt_Remover);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Adicionar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Adicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Remover;
        private System.Windows.Forms.Label Lista;
        private System.Windows.Forms.TextBox Txt_Lista;
        private System.Windows.Forms.Button Btn_Remover;
        private System.Windows.Forms.Button Btn_Adicionar;
    }
}

