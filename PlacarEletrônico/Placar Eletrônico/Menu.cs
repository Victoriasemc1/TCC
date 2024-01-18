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
    
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelDesktopPanel.Controls.Add(childForm);
                panelDesktopPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Configuracoes());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CadastrarJogos());
        }

        private void btnJogosAgendados_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new JogosAgendados());
        }

        private void btnConsultarJogos_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ConsultarJogos());
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
