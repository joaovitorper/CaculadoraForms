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
            string expressao = txtTela.Text;

            // Criar um DataTable para usar o método Compute:
            var dt = new System.Data.DataTable();

            // Calcular a expressão:
            var resultado = dt.Compute(expressao, "");
            // Mostrar na tela:
            txtTela.Text = resultado.ToString();

            // Verificar se a divisão foi feita por zero, e mostrar o erro:
            if (txtTela.Text == "∞")
            {
                btnLimpar.PerformClick();
                MessageBox.Show("Impossível divir por zero!", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // "levantar a bandeirinha"
            operadorClicado = true;
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
           
            if (operadorClicado == false)
            {
                //Obter um botão que está chamando esse evento:
                Button botaoClicado = (Button)sender;
                //adicionar o text do botão criado no TextBox:
                txtTela.Text += botaoClicado.Text;
               
                //Mudar o operadorClicado para true:
                operadorClicado = true;

            }

        }




        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar a Tela:
            txtTela.Text = "";
            //voltar o operador clicando para true:
            operadorClicado = true;

        }

        private void txtTela_TextChanged(object sender, EventArgs e)
        {

        }
    }
}