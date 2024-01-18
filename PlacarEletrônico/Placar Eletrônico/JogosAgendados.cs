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
    public partial class JogosAgendados : Form
    {
        public JogosAgendados()
        {
            InitializeComponent();
        }
        string database = "server=127.0.0.1; port=3306; database=Placar; UID=root; pwd=bancoluana;";
        private void Listar_jogos_Load(object sender, EventArgs e)
        {
            ListaJogo();
        }

        public void ListaJogo()
        {
            MySqlConnection con = new MySqlConnection(database);
            try
            {
                con.Open();
                MySqlDataReader Query;
                string sql = "Select * from tbl_cadastrar_jogos";
                MySqlCommand command = new MySqlCommand(sql, con);
                Query = command.ExecuteReader();
                while (Query.Read())
                {
                    string idjogo = Query.GetString("id_jogo");
                    string time1 = Query.GetString("nome_time1");
                    string time2 = Query.GetString("nome_time2");
                    string arena = Query.GetString("arena");
                    string horario = Query.GetString("horario");
                    string data_hora = Query.GetString("data_jogo");
                    var data = data_hora.Split(' ').FirstOrDefault();

                    lbJogos.Items.Add(idjogo + "  |  " + time1 + "  X  " + time2 + "  |  " + arena + "  |  " + horario + "  |  " + data);
                }
                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                con.Close();
            }
        }

        Placar plac = new Placar();
        public void btnEnviarCad_Click(object sender, EventArgs e)
        {
            DadosJogo();
        }
        public void DadosJogo()
        {
            for (int i = 0; i <= lbJogos.Items.Count - 1; i++)
            {
                if (lbJogos.GetSelected(i))
                {
                    string teste = lbJogos.Items[i].ToString();
                    string dado = teste.Substring(0, 1);
                    MySqlConnection connection = new MySqlConnection(database);
                    connection.Open();
                    MySqlDataReader Query;
                    string sql = "Select * from tbl_cadastrar_jogos where id_jogo='" + dado + "';";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    Query = command.ExecuteReader();
                    while (Query.Read())
                    {
                        string time1 = Query.GetString("nome_time1");
                        VariavelGlobal.time1 = time1;

                        string time2 = Query.GetString("nome_time2");
                        VariavelGlobal.time2 = time2;

                        string arena = Query.GetString("arena");
                        VariavelGlobal.arena = arena;

                        string img1 = Query.GetString("imagem1");
                        VariavelGlobal.imagem1 = img1;

                        string img2 = Query.GetString("imagem2");
                        VariavelGlobal.imagem2 = img2;

                        MessageBox.Show("Enviado com sucesso\nClique na opção CONFIGURAÇÕES", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection.Close();
                }
            }
        }
    }
}
