namespace Aula8Dezembro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.TextBox();
            this.botaoEnviar = new System.Windows.Forms.Button();
            this.labelDigitar = new System.Windows.Forms.Label();
            this.mensagemFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(276, 99);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 22);
            this.input.TabIndex = 0;
            // 
            // botaoEnviar
            // 
            this.botaoEnviar.Location = new System.Drawing.Point(276, 149);
            this.botaoEnviar.Name = "botaoEnviar";
            this.botaoEnviar.Size = new System.Drawing.Size(75, 23);
            this.botaoEnviar.TabIndex = 1;
            this.botaoEnviar.Text = "enviar";
            this.botaoEnviar.UseVisualStyleBackColor = true;
            this.botaoEnviar.Click += new System.EventHandler(this.botaoEnviar_Click);
            // 
            // labelDigitar
            // 
            this.labelDigitar.AutoSize = true;
            this.labelDigitar.Location = new System.Drawing.Point(273, 41);
            this.labelDigitar.Name = "labelDigitar";
            this.labelDigitar.Size = new System.Drawing.Size(101, 16);
            this.labelDigitar.TabIndex = 2;
            this.labelDigitar.Text = "digite um nome:";
            // 
            // mensagemFinal
            // 
            this.mensagemFinal.AutoSize = true;
            this.mensagemFinal.Location = new System.Drawing.Point(276, 201);
            this.mensagemFinal.Name = "mensagemFinal";
            this.mensagemFinal.Size = new System.Drawing.Size(124, 16);
            this.mensagemFinal.TabIndex = 3;
            this.mensagemFinal.Text = "o nome digitado foi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mensagemFinal);
            this.Controls.Add(this.labelDigitar);
            this.Controls.Add(this.botaoEnviar);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ex1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button botaoEnviar;
        private System.Windows.Forms.Label labelDigitar;
        private System.Windows.Forms.Label mensagemFinal;
    }
}

