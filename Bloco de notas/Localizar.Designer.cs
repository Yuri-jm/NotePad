namespace Bloco_de_notas
{
    partial class Localizar
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
            this.txtBxLocalizar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chckBxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.chckBxPalavraInteira = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Localizar:";
            // 
            // txtBxLocalizar
            // 
            this.txtBxLocalizar.Location = new System.Drawing.Point(62, 20);
            this.txtBxLocalizar.Multiline = true;
            this.txtBxLocalizar.Name = "txtBxLocalizar";
            this.txtBxLocalizar.Size = new System.Drawing.Size(195, 20);
            this.txtBxLocalizar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Localizar todas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chckBxCaseSensitive
            // 
            this.chckBxCaseSensitive.AutoSize = true;
            this.chckBxCaseSensitive.Location = new System.Drawing.Point(7, 70);
            this.chckBxCaseSensitive.Name = "chckBxCaseSensitive";
            this.chckBxCaseSensitive.Size = new System.Drawing.Size(202, 17);
            this.chckBxCaseSensitive.TabIndex = 4;
            this.chckBxCaseSensitive.Text = "Diferenciar maiúsculas de minúsculas";
            this.chckBxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // chckBxPalavraInteira
            // 
            this.chckBxPalavraInteira.AutoSize = true;
            this.chckBxPalavraInteira.Location = new System.Drawing.Point(7, 93);
            this.chckBxPalavraInteira.Name = "chckBxPalavraInteira";
            this.chckBxPalavraInteira.Size = new System.Drawing.Size(135, 17);
            this.chckBxPalavraInteira.TabIndex = 5;
            this.chckBxPalavraInteira.Text = "Coincidir palavra inteira";
            this.chckBxPalavraInteira.UseVisualStyleBackColor = true;
            // 
            // Localizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 131);
            this.Controls.Add(this.chckBxPalavraInteira);
            this.Controls.Add(this.chckBxCaseSensitive);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBxLocalizar);
            this.Controls.Add(this.label1);
            this.Name = "Localizar";
            this.Text = "Localizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBxLocalizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chckBxCaseSensitive;
        private System.Windows.Forms.CheckBox chckBxPalavraInteira;
    }
}