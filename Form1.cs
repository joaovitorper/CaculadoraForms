using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaculadoraForms
{
    public partial class btnDividido : Form
       
        

    {
        // Variavel global
        bool operadorClicado = true;
        public btnDividido()
        {
            InitializeComponent();
        }

        private void btnigual_Click(object sender, EventArgs e)

        {
            //implementar Depois...
        }
        private void numero_Click(object sender, EventArgs e)
        {
            // obter o botão que está chamando esse evento:
            Button BotaoClicado = (Button)sender;
            //Adicionar o Text do botão Clicando no TextBox
            //"abaixar Banderinha"
            operadorClicado = false;
            txtTela.Text += BotaoClicado.Text;

        }
        private void operador_Click(object sender, EventArgs e ) 
        {
            // obter o botão que está chamando esse evento:
            Button BotaoClicado = (Button)sender;
            //Adicionar o Text do botão Clicando no TextBox
            txtTela.Text += BotaoClicado.Text;
            if (operadorClicado == false)
            {
                //Obter um botão que está chamando esse evento:
                Button botaoClicado = (Button)sender;
                //adicionar o text do botão criado no TextBox:
                txtTela.Text += botaoClicado.Text;
                //mudar o operadorClicado para true:
                operadorClicado = true;
            }

        }




        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void txtTela_TextChanged(object sender, EventArgs e)
        {

        }
    }
}