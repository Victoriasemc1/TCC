using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placar_Eletrônico
{
    
    public partial class Placar : Form
    {
        public Placar()
        {
            InitializeComponent();
        }

        public int m = 0, s = 0;
        public bool inicia, para, zera;
        
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void Placar_Activated(object sender, EventArgs e)
        {
            timerPlacar.Enabled = inicia;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timerPlacar_Tick_1(object sender, EventArgs e)
        {
            Cronometro();
        }

        public void Cronometro()
        {
            if (inicia == true)
            {
                timerPlacar.Enabled = true;
                s++;
                if (s == 60)
                {
                    m++;
                    s = 0;
                }
            }

            if (para == true)
            {
                timerPlacar.Enabled = false;
                para = false;
            }

            if (zera == true)
            {
                m = 0;
                s = 0;
                zera = false;
            }

            lblCronometro.Text = String.Format("{0:00}", m) + ":" + String.Format("{0:00}", s);
        }
    }  
}
