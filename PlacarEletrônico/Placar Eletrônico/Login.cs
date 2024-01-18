using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placar_Eletrônico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string database = "SERVER=localhost;DATABASE=Placar;UID=root;PASSWORD=bancoluana;";
        private void btnLogar_Click(object sender, EventArgs e)
        {
            ConexaoBanco();
        }

        public void ConexaoBanco()
        {
            MySqlConnection con = new MySqlConnection(database);
            con.Open();
            MySqlDataReader query;

            string s = "Select * from tbl_login where senha = '" + txbSenha.Text + "' and id_email = '" + txbEmail.Text + "'";

            MySqlCommand cmd = new MySqlCommand(s, con);
            query = cmd.ExecuteReader();

            if (query.Read())
            {
                Menu m = new Menu();
                m.Show();
                con.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro\nEmail ou senha incorreto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmail.Focus();
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
            this.Hide();
        }
        private void txbEmail_Enter(object sender, EventArgs e)
        {
            if (txbEmail.Text == "Email")
            {
                txbEmail.Text = "";
                txbEmail.ForeColor = Color.White;
            }
        }
        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text == "")
            {
                txbEmail.Text = "Email";
                txbEmail.ForeColor = Color.White;
            }
        }
        private void txbSenha_Leave(object sender, EventArgs e)
        {
            if (txbSenha.Text == "")
            {
                txbSenha.UseSystemPasswordChar = false;
                txbSenha.Text = "Senha";
                txbSenha.ForeColor = Color.White;
            }
        }
        private void txbSenha_Enter(object sender, EventArgs e)
        {
            if (txbSenha.Text == "Senha")
            {
                txbSenha.UseSystemPasswordChar = true;
                txbSenha.Text = "";
                txbSenha.ForeColor = Color.White;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}