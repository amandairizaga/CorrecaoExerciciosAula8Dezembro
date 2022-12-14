namespace Aula8Dezembro
{
    partial class Form2
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
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.inputTexto = new System.Windows.Forms.TextBox();
            this.tela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.BackColor = System.Drawing.Color.Gray;
            this.botaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLimpar.ForeColor = System.Drawing.Color.Black;
            this.botaoLimpar.Location = new System.Drawing.Point(505, 39);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(120, 45);
            this.botaoLimpar.TabIndex = 0;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = false;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // inputTexto
            // 
            this.inputTexto.Location = new System.Drawing.Point(46, 53);
            this.inputTexto.Name = "inputTexto";
            this.inputTexto.Size = new System.Drawing.Size(191, 22);
            this.inputTexto.TabIndex = 1;
            this.inputTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // tela
            // 
            this.tela.Location = new System.Drawing.Point(46, 103);
            this.tela.Multiline = true;
            this.tela.Name = "tela";
            this.tela.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tela.Size = new System.Drawing.Size(433, 325);
            this.tela.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.inputTexto);
            this.Controls.Add(this.botaoLimpar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.TextBox inputTexto;
        private System.Windows.Forms.TextBox tela;
    }
}