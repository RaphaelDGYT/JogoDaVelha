using System.Windows.Forms;

namespace JogoDaVelha
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnIniciar, btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8;
        private RadioButton rbX, rbO;
        private TextBox txtNome;
        private Label lblSimbolo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnIniciar = new Button();
            this.txtNome = new TextBox();
            this.rbX = new RadioButton();
            this.rbO = new RadioButton();
            this.lblSimbolo = new Label();
            this.btn0 = new Button();
            this.btn1 = new Button();
            this.btn2 = new Button();
            this.btn3 = new Button();
            this.btn4 = new Button();
            this.btn5 = new Button();
            this.btn6 = new Button();
            this.btn7 = new Button();
            this.btn8 = new Button();

            this.SuspendLayout();
            var botoes = new[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 };
            for (int i = 0; i < botoes.Length; i++)
            {
                botoes[i].Location = new System.Drawing.Point(10 + (i % 3) * 60, 100 + (i / 3) * 60);
                botoes[i].Size = new System.Drawing.Size(50, 50);
                botoes[i].Click += Botao_Click;
                this.Controls.Add(botoes[i]);
            }

            this.txtNome.Location = new System.Drawing.Point(10, 10);

            // Em versões anteriores, o texto do placeholder era definido assim:
            // this.txtNome.Text = "Nome do Jogador";

            this.txtNome.PlaceholderText = "Digite seu nome";
            this.Controls.Add(this.txtNome);

            this.rbX.Text = "X";
            this.rbX.Checked = true;
            this.rbX.Location = new System.Drawing.Point(10, 40);
            this.Controls.Add(this.rbX);

            this.rbO.Text = "O";
            this.rbO.Location = new System.Drawing.Point(60, 40);
            this.Controls.Add(this.rbO);

            this.lblSimbolo.Text = "Escolha seu símbolo:";
            this.lblSimbolo.Location = new System.Drawing.Point(10, 70);
            this.Controls.Add(this.lblSimbolo);

            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.Location = new System.Drawing.Point(140, 40);
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            this.Controls.Add(this.btnIniciar);

            this.ClientSize = new System.Drawing.Size(220, 300);
            this.Text = "Jogo da Velha";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
