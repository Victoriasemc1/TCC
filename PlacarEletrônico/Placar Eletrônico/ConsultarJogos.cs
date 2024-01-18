using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placar_Eletrônico
{
    public partial class ConsultarJogos : Form
    {
        public ConsultarJogos()
        {
            InitializeComponent();
        }

        string database = "server=127.0.0.1; port=3306; database=Placar; UID=root; pwd=bancoluana;";
        MySqlCommand cmd = new MySqlCommand();

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisa();
        }

        public void Pesquisa()
        {
            MySqlConnection con = new MySqlConnection(database);
            if (txtBusca.Text == "")
            {
                try
                {
                    con.Open();
                    var sql = "select * from VwConsultaJogos;";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(sql, con))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvConsultaJogo.DataSource = dt;
                            con.Close();
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    con.Close();
                }
            }
            else if (txtBusca.Text != "")
            {
                try
                {
                    con.Open();

                    //adicionar linha pra substituir barra por traço
                    //cmd.CommandText = "select * from VwConsultaJogos where nome_time1 like('%" + txtBusca.Text + "%')";
                    cmd.CommandText = "select * from VwConsultaJogos where data_jogo like('%" + txtBusca.Text + "%')";

                    cmd.Connection = con;

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    dgvConsultaJogo.DataSource = dt;

                    con.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                dgvConsultaJogo.DataSource = null;
            }
        }

        private void CarregaJogo()
        {
            lblHorario.Text = dgvConsultaJogo.SelectedRows[0].Cells[1].Value.ToString();
            lblLocal.Text = dgvConsultaJogo.SelectedRows[0].Cells[2].Value.ToString();
            lblTime1.Text = dgvConsultaJogo.SelectedRows[0].Cells[3].Value.ToString();
            lblGols1.Text = dgvConsultaJogo.SelectedRows[0].Cells[4].Value.ToString();
            lblFaltasCom1.Text = dgvConsultaJogo.SelectedRows[0].Cells[5].Value.ToString();
            lblTime2.Text = dgvConsultaJogo.SelectedRows[0].Cells[6].Value.ToString();
            lblGols2.Text = dgvConsultaJogo.SelectedRows[0].Cells[7].Value.ToString();
            lblFaltasCom2.Text = dgvConsultaJogo.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void dgvConsultaJogo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregaJogo();
        }
    }
}
