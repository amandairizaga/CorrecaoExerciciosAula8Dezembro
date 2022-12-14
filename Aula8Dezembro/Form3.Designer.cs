namespace Aula8Dezembro
{
    partial class Form3
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
            this.labelNome = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.labelIdade = new System.Windows.Forms.Label();
            this.inputIdade = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.botaoEnviar = new System.Windows.Forms.Button();
            this.labelMensagemFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(42, 24);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(47, 16);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // inputNome
            // 
            this.inputNome.Location = new System.Drawing.Point(45, 43);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(100, 22);
            this.inputNome.TabIndex = 1;
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(45, 90);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(45, 16);
            this.labelIdade.TabIndex = 2;
            this.labelIdade.Text = "Idade:";
            // 
            // inputIdade
            // 
            this.inputIdade.Location = new System.Drawing.Point(48, 120);
            this.inputIdade.Name = "inputIdade";
            this.inputIdade.Size = new System.Drawing.Size(100, 22);
            this.inputIdade.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(48, 175);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 16);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email:";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(51, 194);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(100, 22);
            this.inputEmail.TabIndex = 5;
            // 
            // botaoEnviar
            // 
            this.botaoEnviar.Location = new System.Drawing.Point(51, 250);
            this.botaoEnviar.Name = "botaoEnviar";
            this.botaoEnviar.Size = new System.Drawing.Size(75, 23);
            this.botaoEnviar.TabIndex = 6;
            this.botaoEnviar.Text = "Enviar";
            this.botaoEnviar.UseVisualStyleBackColor = true;
            this.botaoEnviar.Click += new System.EventHandler(this.botaoEnviar_Click);
            // 
            // labelMensagemFinal
            // 
            this.labelMensagemFinal.AutoSize = true;
            this.labelMensagemFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagemFinal.Location = new System.Drawing.Point(48, 311);
            this.labelMensagemFinal.Name = "labelMensagemFinal";
            this.labelMensagemFinal.Size = new System.Drawing.Size(0, 32);
            this.labelMensagemFinal.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMensagemFinal);
            this.Controls.Add(this.botaoEnviar);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.inputIdade);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.labelNome);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.TextBox inputIdade;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Button botaoEnviar;
        private System.Windows.Forms.Label labelMensagemFinal;
    }
}