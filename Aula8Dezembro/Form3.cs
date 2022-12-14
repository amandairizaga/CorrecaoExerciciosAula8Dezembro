using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8Dezembro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void botaoEnviar_Click(object sender, EventArgs e)
        {
            labelMensagemFinal.Text = "As informações digitadas foram: \n\r" + 
                "Nome: " +inputNome.Text + "\n\r" +
                "Idade: "+ inputIdade.Text + "\n\r" +
                "Email: "+ inputEmail.Text;
        }
    }
}
