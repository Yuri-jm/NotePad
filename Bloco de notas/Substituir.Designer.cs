namespace Bloco_de_notas
{
    partial class Substituir
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
            this.txtBxLocalizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxSubstituir = new System.Windows.Forms.TextBox();
            this.bttnSubstituir = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxLocalizar
            // 
            this.txtBxLocalizar.Location = new System.Drawing.Point(99, 24);
            this.txtBxLocalizar.Name = "txtBxLocalizar";
            this.txtBxLocalizar.Size = new System.Drawing.Size(182, 20);
            this.txtBxLocalizar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localizar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Substituir por:";
            // 
            // txtBxSubstituir
            // 
            this.txtBxSubstituir.Location = new System.Drawing.Point(99, 49);
            this.txtBxSubstituir.Name = "txtBxSubstituir";
            this.txtBxSubstituir.Size = new System.Drawing.Size(182, 20);
            this.txtBxSubstituir.TabIndex = 3;
            // 
            // bttnSubstituir
            // 
            this.bttnSubstituir.Location = new System.Drawing.Point(287, 24);
            this.bttnSubstituir.Name = "bttnSubstituir";
            this.bttnSubstituir.Size = new System.Drawing.Size(139, 19);
            this.bttnSubstituir.TabIndex = 4;
            this.bttnSubstituir.Text = "Substituir tudo";
            this.bttnSubstituir.UseVisualStyleBackColor = true;
            this.bttnSubstituir.Click += new System.EventHandler(this.bttnSubstituir_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Location = new System.Drawing.Point(287, 50);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(139, 19);
            this.bttnCancelar.TabIndex = 5;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // Substituir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 140);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnSubstituir);
            this.Controls.Add(this.txtBxSubstituir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxLocalizar);
            this.Name = "Substituir";
            this.Text = "Substituir";
            this.Load += new System.EventHandler(this.Substituir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxSubstituir;
        private System.Windows.Forms.Button bttnCancelar;
        public System.Windows.Forms.TextBox txtBxLocalizar;
        private System.Windows.Forms.Button bttnSubstituir;
    }
}