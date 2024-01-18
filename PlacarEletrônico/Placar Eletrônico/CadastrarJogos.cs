using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Placar_Eletrônico
{
    public partial class CadastrarJogos : Form
    {
        public CadastrarJogos()
        {
            InitializeComponent();
        }

        string database = "server=127.0.0.1; port=3306; database=Placar; UID=root; pwd=bancoluana;";
        MySqlCommand cmd = new MySqlCommand();

        string img1;
        string img2;
        private void txbTime2_Enter_1(object sender, EventArgs e)
        {
            if (txbTime2.Text == "Time 2")
            {
                txbTime2.Text = "";
                txbTime2.ForeColor = Color.Black;
            }
        }

        private void txbTime2_Leave_1(object sender, EventArgs e)
        {
            if (txbTime2.Text == "")
            {
                txbTime2.Text = "Time 2";
                txbTime2.ForeColor = Color.Black;
            }
        }

        private void txbArena_Enter_1(object sender, EventArgs e)
        {
            if (txbArena.Text == "Arena")
            {
                txbArena.Text = "";
                txbArena.ForeColor = Color.Black;
            }
        }

        private void txbArena_Leave_1(object sender, EventArgs e)
        {
            if (txbArena.Text == "")
            {
                txbArena.Text = "Arena";
                txbArena.ForeColor = Color.Black;
            }
        }

        private void txbHorario_Enter_1(object sender, EventArgs e)
        {
            if (txbHorario.Text == "Horário")
            {
                txbHorario.Text = "";
                txbHorario.ForeColor = Color.Black;
            }
        }

        private void txbHorario_Leave_1(object sender, EventArgs e)
        {
            if (txbHorario.Text == "")
            {
                txbHorario.Text = "Horário";
                txbHorario.ForeColor = Color.Black;
            }
        }

        private void txbTime1_Enter_1(object sender, EventArgs e)
        {
            if (txbTime1.Text == "Time 1")
            {
                txbTime1.Text = "";
                txbTime1.ForeColor = Color.Black;
            }
        }

        private void txbTime1_Leave_1(object sender, EventArgs e)
        {
            if (txbTime1.Text == "")
            {
                txbTime1.Text = "Time 1";
                txbTime1.ForeColor = Color.Black;
            }
        }
        private void PicBoxTime1_Click_1(object sender, EventArgs e)
        {
            AnexarLogoTime1();
        }

        public void AnexarLogoTime1()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PicBoxTime1.ImageLocation = openFileDialog1.FileName;
                PicBoxTime1.Load();
            }
            img1 = openFileDialog1.FileName;
        }

        private void PicBoxTime2_Click_1(object sender, EventArgs e)
        {
            AnexarLogoTime2();
        }

        public void AnexarLogoTime2()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PicBoxTime2.ImageLocation = openFileDialog1.FileName;
                PicBoxTime2.Load();
            }
            img2 = openFileDialog1.FileName;
        }

        private void btnEnviarCad_Click_1(object sender, EventArgs e)
        {
            EnvioDeDados();
        }

        public void EnvioDeDados()
        {
            MySqlConnection con = new MySqlConnection(database);
            try
            {
                DateTime dataAtual = DateTime.Now;
                DateTime data = dtpData.Value;
                string dia = data.Day.ToString();
                string mes = data.Month.ToString();
                string ano = data.Year.ToString();
                string datadia = ano + "-" + mes + "-" + dia;

                string time1 = txbTime1.Text.ToUpper();
                string time2 = txbTime2.Text.ToUpper();
                string arena = txbArena.Text.ToUpper();
                string hora = txbHorario.Text;

                Regex horaValida = new Regex("^((?!0+:00)\\d{1,}:[0-5][0-9])$");
                if (horaValida.IsMatch(txbHorario.Text))
                {

                    if (dtpData.Value > dataAtual)
                    {
                        string str = "insert into tbl_cadastrar_jogos(nome_time1,nome_time2,arena,horario,data_jogo, imagem1, imagem2)values(@time1,@time2,@arena,@horario,@data,@imagem1,@imagem2);";

                        cmd.CommandText = str;
                        cmd.Connection = con;

                        cmd.Parameters.Add("@time1", MySqlDbType.VarChar).Value = time1;
                        cmd.Parameters.Add("@time2", MySqlDbType.VarChar).Value = time2;
                        cmd.Parameters.Add("@arena", MySqlDbType.VarChar).Value = arena;
                        cmd.Parameters.Add("@horario", MySqlDbType.VarChar).Value = hora;
                        cmd.Parameters.Add("@data", MySqlDbType.Date).Value = datadia;
                        cmd.Parameters.Add("@imagem1", MySqlDbType.VarChar).Value = img1;
                        cmd.Parameters.Add("@imagem2", MySqlDbType.VarChar).Value = img2;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        MessageBox.Show("Dados Gravados com Sucesso!", "Inserção de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txbArena.Text = "Arena";
                        txbHorario.Text = "Horário";
                        txbTime1.Text = "Time 1";
                        txbTime2.Text = "Time 2";
                        PicBoxTime1.ImageLocation = null;
                        PicBoxTime2.ImageLocation = null;

                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro, não é possível cadastrar uma data que já tenha passado", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Erro\nInsira um hórario válido", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbHorario.Text = "";
                    txbHorario.Focus();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                con.Close();
            }
        }
    }
}
