using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Placar_Eletrônico
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
        }

        Placar plac = new Placar();
        string database = "server=127.0.0.1; port=3306; database=Placar; UID=root; pwd=bancoluana;";
        MySqlCommand cmd = new MySqlCommand();

        //pontuação
        private void btn1Menos_Click(object sender, EventArgs e)
        {
            DiminuirPontuacaoTime1();
        }

        private void btn1Mais_Click(object sender, EventArgs e)
        {
            AumentarPontuacaoTime1();
        }

        private void btn2Menos_Click(object sender, EventArgs e)
        {
            DiminuirPontuacaoTime2();
        }

        private void btn2Mais_Click(object sender, EventArgs e)
        {
            AumentarPontuacaoTime2();
        }

        public void DiminuirPontuacaoTime1()
        {
            int score = int.Parse(lblPontoTime1.Text) - 1;
            if (score >= 0)
            {
                lblPontoTime1.Text = score.ToString();
            }
        }

        public void AumentarPontuacaoTime1()
        {
            int score = int.Parse(lblPontoTime1.Text) + 1;
            if (score >= 0)
            {
                lblPontoTime1.Text = score.ToString();
            }
        }
        
        public void DiminuirPontuacaoTime2()
        {
            int score = int.Parse(lblPontoTime2.Text) - 1;
            if (score >= 0)
            {
                lblPontoTime2.Text = score.ToString();
            }
        }

        public void AumentarPontuacaoTime2()
        {
            int score = int.Parse(lblPontoTime2.Text) + 1;
            if (score >= 0)
            {
                lblPontoTime2.Text = score.ToString();
            }
        }


        //cronometro
        Stopwatch cron = new Stopwatch();
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            plac.inicia = true;
        }
        private void btnParar_Click(object sender, EventArgs e)
        {
            plac.inicia = false;
        }
        private void btnZerar_Click(object sender, EventArgs e)
        {
            ZerarCronometro();
        }

        public void ZerarCronometro()
        {
            var resposta = DialogResult;
            resposta = MessageBox.Show("Deseja zerar o  cronometro?", "Cronometro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                plac.zera = true;
            }
        }

        //falta

        public void DiminuirFaltaTime1()
        {
            int score = int.Parse(lblFaltaTime1.Text) - 1;
            if (score >= 0)
            {
                lblFaltaTime1.Text = score.ToString();
            }
        }
        public void AumentarFaltaTime1()
        {
            int score = int.Parse(lblFaltaTime1.Text) + 1;
            if (score >= 0)
            {
                lblFaltaTime1.Text = score.ToString();
            }
        }
        public void DiminuirFaltaTime2()
        {
            int score = int.Parse(lblFaltaTime2.Text) - 1;
            if (score >= 0)
            {
                lblFaltaTime2.Text = score.ToString();
            }
        }
        public void AumentarFaltaTime2()
        {
            int score = int.Parse(lblFaltaTime2.Text) + 1;
            if (score >= 0)
            {
                lblFaltaTime2.Text = score.ToString();
            }
        }
        private void btnF1Menos_Click(object sender, EventArgs e)
        {
            DiminuirFaltaTime1();
        }
        private void btnF1Mais_Click(object sender, EventArgs e)
        {
            AumentarFaltaTime1();
        }
        private void btnF2Menos_Click(object sender, EventArgs e)
        {
            DiminuirFaltaTime2();
        }
        private void btnF2Mais_Click(object sender, EventArgs e)
        {
            AumentarFaltaTime2();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarDados();
        }

        public void GravarDados()
        {
            MySqlConnection con = new MySqlConnection(database);
            try
            {
                string pontotime1 = lblPontoTime1.Text;
                string pontotime2 = lblPontoTime2.Text;
                string faltastime1 = lblFaltaTime1.Text;
                string faltastime2 = lblFaltaTime2.Text;

                string str = "insert into tbl_configuracoes(pontos_time1,pontos_time2,faltas_time1,faltas_time2)values(@ponto1,@ponto2,@falta1,@falta2);";

                cmd.CommandText = str;
                cmd.Connection = con;

                cmd.Parameters.Add("@ponto1", MySqlDbType.Int16).Value = pontotime1;
                cmd.Parameters.Add("@ponto2", MySqlDbType.Int16).Value = pontotime2;
                cmd.Parameters.Add("@falta1", MySqlDbType.Int16).Value = faltastime1;
                cmd.Parameters.Add("@falta2", MySqlDbType.Int16).Value = faltastime2;

                con.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                MessageBox.Show("Dados Gravados com Sucesso", "Inserção de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn1Confirmar_Click(object sender, EventArgs e)
        {
            plac.lblPonto1.Text = lblPontoTime1.Text;
        }
        private void btn2Confirmar_Click(object sender, EventArgs e)
        {
            plac.lblPonto2.Text = lblPontoTime2.Text;
        }
        private void btnF1Confirmar_Click(object sender, EventArgs e)
        {
            plac.lblFalta1.Text = lblFaltaTime1.Text;
        }
        private void btnF2Confirmar_Click(object sender, EventArgs e)
        {
            plac.lblFalta2.Text = lblFaltaTime2.Text;
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            plac.lblTempoJogo.Text = txbTempoJogo.Text.ToUpper();
        }
        private void Configuracoes_Load(object sender, EventArgs e)
        {
            plac.lblNomeArena.Text = VariavelGlobal.arena;
            plac.lblTime1Ponto.Text = VariavelGlobal.time1;
            plac.lblTime2Ponto.Text = VariavelGlobal.time2;
            plac.picTime1.ImageLocation = VariavelGlobal.imagem1;
            plac.picTime2.ImageLocation = VariavelGlobal.imagem2;

            plac.Show();

            maskedTextBox1.Focus();
        }

        public void btnEnviarCrono_Click(object sender, EventArgs e)
        {
            VerificacaoCronometro();
        }

        public void VerificacaoCronometro()
        {
            Regex horaValida = new Regex("^((?!0+:00)\\d{1,}:[0-5][0-9])$");
            if (horaValida.IsMatch(maskedTextBox1.Text))
            {
                string tempo = maskedTextBox1.Text;
                string minutos = tempo.Substring(0, 2);
                int min = int.Parse(minutos);
                VariavelGlobal.minutos = min;
                plac.m = VariavelGlobal.minutos;

                string segundos = tempo.Substring(3);
                int seg = int.Parse(segundos);
                VariavelGlobal.segundos = seg;
                plac.s = VariavelGlobal.segundos;
                MessageBox.Show("Clique no iniciar", "Tempo enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro\nDigite um tempo válido", "Tempo de jogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox1.Text = "";
                maskedTextBox1.Focus();
            }
        }
    }
}
