using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GCodeSender
{
    public partial class Form1 : Form
    {

        //Codigo para mover janela quando nao tem a barra de titulo
        //Como encontrado em: https://codeproject.com/articles/11114/Move-window-form-without-titlebar-in-C
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();//Expandir...

        //Variaveis Globais

        //Inicia Programa
        public Form1()
        {
            InitializeComponent();
        }

        //Botao de fechar o programa
        private void FechaForm_Click(object sender, EventArgs e)
        {
            this.Close(); //Fecha o Form
        }

        //Evento quando mouseDown dentro do Form, usado para movimentar a janela
        //Como encontrado em: https://codeproject.com/articles/11114/Move-window-form-without-titlebar-in-C
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //Botao para minimizar a janela
        private void BtMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Botao de enviar comando ao historico e a lista de espera da desenhadora
        private void BtEnviar_Click(object sender, EventArgs e)
        {
            //Verifica se foi escrito algo na caixa de comandos
            if (TextEnvio.Text.Length == 0)
                return;

            //Variavel que indica o numero de linhas do historico
            int TotalLinhas = ListaHistorico.Items.Count;

            //Se tem 12 linhas diminui o tamanho da coluna do comando
            //já que nesse momento aparece a barre de rolagem vertical, ocupando espaco da lista
            if (TotalLinhas == 12)
                ListaHistorico.Columns[1].Width = 140;  //Coluna[1] é a coluna de comandos

            string he = TotalLinhas.ToString();
            string[] linha = { he, he, he };
            var LinhaLista = new ListViewItem(linha);

            //Adiciona item na lista, 1 item = tres strings (tres colunas)
            ListaHistorico.Items.Add(LinhaLista);

            //Move a barra de rolagem para baixo
            ListaHistorico.Items[TotalLinhas].EnsureVisible();

            //Muda Numero ao lado da caixa de envio, indicando qual o numero do proximo comando
            LbNumEnvio.Text = (TotalLinhas + 1).ToString() + '.';

            //Limpa caixa de texto de envio, ja que o comando ja foi enviado
            TextEnvio.Text = null;
        }
    }
}
