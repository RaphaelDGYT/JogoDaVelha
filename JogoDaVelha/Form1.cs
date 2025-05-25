using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        private Button[] botoes;
        private string jogadorSimbolo = "X";
        private string maquinaSimbolo = "O";
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            botoes = new Button[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 };
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            jogadorSimbolo = rbX.Checked ? "X" : "O";
            maquinaSimbolo = rbX.Checked ? "O" : "X";

            foreach (var btn in botoes)
            {
                btn.Text = "";
                btn.BackColor = default;
                btn.Enabled = true;
            }
        }

        private void Botao_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text == "")
            {
                btn.Text = jogadorSimbolo;
                btn.BackColor = Color.Blue;
                btn.Enabled = false;

                if (VerificarVitoria(jogadorSimbolo)) return;

                JogadaMaquina();
            }
        }

        private void JogadaMaquina()
        {
            var disponiveis = new System.Collections.Generic.List<Button>();
            foreach (var b in botoes) if (b.Text == "") disponiveis.Add(b);

            if (disponiveis.Count == 0) return;

            var escolha = disponiveis[random.Next(disponiveis.Count)];
            escolha.Text = maquinaSimbolo;
            escolha.BackColor = Color.Yellow;
            escolha.Enabled = false;

            VerificarVitoria(maquinaSimbolo);
        }

        private bool VerificarVitoria(string simbolo)
        {
            int[][] combinacoes = new int[][]
            {
                new[]{0,1,2}, new[]{3,4,5}, new[]{6,7,8},
                new[]{0,3,6}, new[]{1,4,7}, new[]{2,5,8},
                new[]{0,4,8}, new[]{2,4,6}
            };

            foreach (var c in combinacoes)
            {
                if (botoes[c[0]].Text == simbolo && botoes[c[1]].Text == simbolo && botoes[c[2]].Text == simbolo)
                {
                    Color cor = simbolo == jogadorSimbolo ? Color.Green : Color.Red;
                    botoes[c[0]].BackColor = botoes[c[1]].BackColor = botoes[c[2]].BackColor = cor;

                    string msg = simbolo == jogadorSimbolo ? "Parabéns pela vitória!" : "A máquina venceu. Tente novamente!";
                    MessageBox.Show(msg, "Fim de jogo");
                    return true;
                }
            }

            return false;
        }
    }
}