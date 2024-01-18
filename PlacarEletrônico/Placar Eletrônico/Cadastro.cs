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
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace Placar_Eletrônico
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        string database = "SERVER=localhost;DATABASE=Placar;UID=root;PASSWORD=bancoluana;";

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            VerificacaoCadastroLogin();
        }

        public void VerificacaoCadastroLogin()
        {
            string email = txbEmail_cad.Text;

            Regex email_valido = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");

            if (email_valido.IsMatch(email))
            {
                if (txbSenha_cad.TextLength >= 8 && txbSenha_cad.TextLength < 18)
                {
                    if (txbSenha_cad.Text == txbConfSenha_cad.Text)
                    {
                        MySqlConnection connection = new MySqlConnection(database);
                        connection.Open();
                        string sql = "insert into tbl_Login(id_email,senha) values ('" + txbEmail_cad.Text + "','" + txbSenha_cad.Text + "')";

                        MySqlCommand cmd = new MySqlCommand(sql, connection);
                        cmd.ExecuteReader();

                        MessageBox.Show("Cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro\nConfirme a senha corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Erro\nA senha deve conter no minimo 8 caracteres e no maximo 16", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Email inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txbEmail_cad_Leave(object sender, EventArgs e)
        {
            if (txbEmail_cad.Text == "")
            {
                txbEmail_cad.Text = "Email";
                txbEmail_cad.ForeColor = Color.White;
            }
        }
        private void txbEmail_cad_Enter(object sender, EventArgs e)
        {
            if (txbEmail_cad.Text == "Email")
            {
                txbEmail_cad.Text = "";
                txbEmail_cad.ForeColor = Color.White;
            }
        }
        private void txbSenha_cad_Leave(object sender, EventArgs e)
        {
            if (txbSenha_cad.Text == "")
            {
                txbSenha_cad.UseSystemPasswordChar = false;
                txbSenha_cad.Text = "Senha";
                txbSenha_cad.ForeColor = Color.White;
            }
        }
        private void txbSenha_cad_Enter(object sender, EventArgs e)
        {
            if (txbSenha_cad.Text == "Senha")
            {
                txbSenha_cad.UseSystemPasswordChar = true;
                txbSenha_cad.Text = "";
                txbSenha_cad.ForeColor = Color.White;
            }
        }
        private void txbConfSenha_cad_Leave(object sender, EventArgs e)
        {
            if (txbConfSenha_cad.Text == "")
            {
                txbConfSenha_cad.UseSystemPasswordChar = false;
                txbConfSenha_cad.Text = "Confirmar Senha";
                txbConfSenha_cad.ForeColor = Color.White;
            }
        }
        private void txbConfSenha_cad_Enter(object sender, EventArgs e)
        {
            if (txbConfSenha_cad.Text == "Confirmar Senha")
            {
                txbConfSenha_cad.UseSystemPasswordChar = true;
                txbConfSenha_cad.Text = "";
                txbConfSenha_cad.ForeColor = Color.White;
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
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            Login obj = new Login();
            obj.Show();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}