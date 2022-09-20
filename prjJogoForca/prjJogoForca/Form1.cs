using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjJogoForca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Forca jogo;
        List<string> lista = new List<string>();
        List<string> dicas = new List<string>();

        Label[] Letras;
        int Erro = 0;
        SoundPlayer musica;
        private void txtletra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(
                  Keys.Enter))
              
            {
                btnJogar_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarLista();
            jogo = new Forca(lista);
            jogo.Sortear();
            DesenharPalavra(jogo.DevolvePalavra());
            musica = new SoundPlayer();
            string file = Environment.CurrentDirectory +
                "\\fundo.wav";
            musica.SoundLocation = file;
            musica.PlayLooping();
            lbDica.Text = dicas[jogo.Pos];
        }

        private void CarregarLista()
        {
            string file = Environment.CurrentDirectory +
               "\\lista.txt";
            StreamReader st = new StreamReader(file);
            int qtd = File.ReadAllLines(file).Count();
            for (int i = 0; i < qtd; i++)
            {
                string[] campos = st.ReadLine().Split(',');
                lista.Add(campos[0]);
                dicas.Add(campos[1]);
            }

            st.Close();
        }
        private void DesenharPalavra(string p)
        {
            int qtd = p.Length;
            Letras = new Label[qtd];

            int px = 10;
            int py = 10;

            for (int i = 0; i < qtd; i++)
            {
                Letras[i] = new Label();
                Letras[i].Text = "💀";
                Letras[i].AutoSize = false;
                Letras[i].Width = 50;
                Letras[i].Height = 50;
                Letras[i].ForeColor = Color.Red;
                Letras[i].BackColor = Color.Black;
                Letras[i].TextAlign = ContentAlignment.MiddleCenter;
                Letras[i].BorderStyle = BorderStyle.FixedSingle;
                if (i % 10 == 0 && i != 0)
                {
                    py += 55;
                    px = 10;
                }
                Letras[i].Top = py;
                Letras[i].Left = px;
                px += 55;
                pnPalavra.Controls.Add(Letras[i]);
                Letras[i].Show();
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            DesenharLetra(txtletra.Text);
            txtletra.Focus();
            txtletra.SelectAll();

        }

        private void DesenharLetra(string letra)
        {
            bool achou = false;
            string p = jogo.DevolvePalavra();
 
            if (lbLetras.Text.Contains(letra)) {
                MessageBox.Show("letra ja digitada");
                return;
            }
            lbLetras.Text += letra + " ";
            for (int i = 0; i < p.Length; i++)
            {
                if (p.Substring(i, 1).Equals(letra))
                {
                    Letras[i].Text = letra;
                    achou = true;
                }
            }
            if (achou == false)
            {
                Erro++;
                DesenharBoneco();

            }
            if (Erro == 6)
            {
                timer1.Stop();
                Derrota();
                timer1.Start();
            }

            TestarVitoria();
        }

        private void TestarVitoria()
        {
            string p = jogo.DevolvePalavra();
            string tmp = "";
            foreach (Label letra in Letras)
            {
                tmp += letra.Text;
            }
            if (p.Equals(tmp))
            {
                timer1.Stop();
                MessageBox.Show("Voce venceu!");
                NovoJogo();
                timer1.Start();

            }
        }
        private void Derrota()
        {
            MessageBox.Show("Voce Perdeu!" +
                " a palavra era" +
                jogo.DevolvePalavra());
            NovoJogo();
        }

        private void NovoJogo()
        {
            pnPalavra.Controls.Clear();
            pbBoneco.Image = null;
            Erro = 0;
            lbLetras.Text = "";
            jogo.Sortear();
            DesenharPalavra(jogo.DevolvePalavra());
            txtletra.Focus();
            txtletra.SelectAll();
            lbCronometro.Text = "120";
            lbDica.Text = dicas[jogo.Pos];
        }

        private void DesenharBoneco()
        {
            string arquivo = Environment.CurrentDirectory +
                "\\imagens\\forca" + Erro + ".png";
            pbBoneco.Image = Image.FromFile(arquivo);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int seg = Int16.Parse(lbCronometro.Text);
            seg--;
            lbCronometro.Text = seg.ToString();
            if (seg < 30) 
            {
                lbCronometro.ForeColor = Color.Red;
            }
            if (seg < 0)
            {
                timer1.Stop();
                Derrota();
                lbCronometro.Text = "128";
                timer1.Start();
            }
        }

        private void lbDica_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            lbCronometro.Text = "120";
            NovoJogo();
        }

        private void btnNovoJogo_KeyPress(object sender, KeyPressEventArgs e)
        {
                       
        }
   
    }
}
