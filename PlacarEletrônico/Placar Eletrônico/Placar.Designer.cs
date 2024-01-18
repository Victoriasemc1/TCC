namespace Placar_Eletrônico
{
    partial class Placar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime1Ponto = new System.Windows.Forms.Label();
            this.lblPonto1 = new System.Windows.Forms.Label();
            this.lblTime2Ponto = new System.Windows.Forms.Label();
            this.lblPonto2 = new System.Windows.Forms.Label();
            this.lblTime1Falta = new System.Windows.Forms.Label();
            this.lblFalta1 = new System.Windows.Forms.Label();
            this.lblFalta2 = new System.Windows.Forms.Label();
            this.lblTime2Falta = new System.Windows.Forms.Label();
            this.gboxTempo = new System.Windows.Forms.GroupBox();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.picTime2 = new System.Windows.Forms.PictureBox();
            this.lblNomeArena = new System.Windows.Forms.Label();
            this.lblTempoJogo = new System.Windows.Forms.Label();
            this.timerPlacar = new System.Windows.Forms.Timer(this.components);
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picTime1 = new System.Windows.Forms.PictureBox();
            this.gboxTempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTime2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTime1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime1Ponto
            // 
            this.lblTime1Ponto.AccessibleDescription = "";
            this.lblTime1Ponto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime1Ponto.BackColor = System.Drawing.Color.Black;
            this.lblTime1Ponto.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime1Ponto.ForeColor = System.Drawing.Color.White;
            this.lblTime1Ponto.Location = new System.Drawing.Point(12, 56);
            this.lblTime1Ponto.Name = "lblTime1Ponto";
            this.lblTime1Ponto.Size = new System.Drawing.Size(550, 61);
            this.lblTime1Ponto.TabIndex = 0;
            this.lblTime1Ponto.Text = "TIME 1";
            this.lblTime1Ponto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPonto1
            // 
            this.lblPonto1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPonto1.AutoSize = true;
            this.lblPonto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPonto1.ForeColor = System.Drawing.Color.Red;
            this.lblPonto1.Location = new System.Drawing.Point(192, 158);
            this.lblPonto1.Name = "lblPonto1";
            this.lblPonto1.Size = new System.Drawing.Size(110, 120);
            this.lblPonto1.TabIndex = 1;
            this.lblPonto1.Text = "0";
            // 
            // lblTime2Ponto
            // 
            this.lblTime2Ponto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime2Ponto.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime2Ponto.ForeColor = System.Drawing.Color.White;
            this.lblTime2Ponto.Location = new System.Drawing.Point(828, 56);
            this.lblTime2Ponto.Name = "lblTime2Ponto";
            this.lblTime2Ponto.Size = new System.Drawing.Size(550, 61);
            this.lblTime2Ponto.TabIndex = 2;
            this.lblTime2Ponto.Text = "TIME 2";
            this.lblTime2Ponto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPonto2
            // 
            this.lblPonto2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPonto2.AutoSize = true;
            this.lblPonto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPonto2.ForeColor = System.Drawing.Color.Red;
            this.lblPonto2.Location = new System.Drawing.Point(1062, 158);
            this.lblPonto2.Name = "lblPonto2";
            this.lblPonto2.Size = new System.Drawing.Size(110, 120);
            this.lblPonto2.TabIndex = 3;
            this.lblPonto2.Text = "0";
            // 
            // lblTime1Falta
            // 
            this.lblTime1Falta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime1Falta.AutoSize = true;
            this.lblTime1Falta.Font = new System.Drawing.Font("Arial", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime1Falta.ForeColor = System.Drawing.Color.White;
            this.lblTime1Falta.Location = new System.Drawing.Point(122, 685);
            this.lblTime1Falta.Name = "lblTime1Falta";
            this.lblTime1Falta.Size = new System.Drawing.Size(225, 63);
            this.lblTime1Falta.TabIndex = 4;
            this.lblTime1Falta.Text = "FALTAS";
            this.lblTime1Falta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFalta1
            // 
            this.lblFalta1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFalta1.AutoSize = true;
            this.lblFalta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFalta1.ForeColor = System.Drawing.Color.Red;
            this.lblFalta1.Location = new System.Drawing.Point(192, 850);
            this.lblFalta1.Name = "lblFalta1";
            this.lblFalta1.Size = new System.Drawing.Size(110, 120);
            this.lblFalta1.TabIndex = 5;
            this.lblFalta1.Text = "0";
            this.lblFalta1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFalta2
            // 
            this.lblFalta2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFalta2.AutoSize = true;
            this.lblFalta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFalta2.ForeColor = System.Drawing.Color.Red;
            this.lblFalta2.Location = new System.Drawing.Point(1062, 850);
            this.lblFalta2.Name = "lblFalta2";
            this.lblFalta2.Size = new System.Drawing.Size(110, 120);
            this.lblFalta2.TabIndex = 6;
            this.lblFalta2.Text = "0";
            this.lblFalta2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime2Falta
            // 
            this.lblTime2Falta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime2Falta.AutoSize = true;
            this.lblTime2Falta.Font = new System.Drawing.Font("Arial", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime2Falta.ForeColor = System.Drawing.Color.White;
            this.lblTime2Falta.Location = new System.Drawing.Point(1020, 684);
            this.lblTime2Falta.Name = "lblTime2Falta";
            this.lblTime2Falta.Size = new System.Drawing.Size(225, 63);
            this.lblTime2Falta.TabIndex = 7;
            this.lblTime2Falta.Text = "FALTAS";
            this.lblTime2Falta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboxTempo
            // 
            this.gboxTempo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboxTempo.Controls.Add(this.lblCronometro);
            this.gboxTempo.ForeColor = System.Drawing.Color.White;
            this.gboxTempo.Location = new System.Drawing.Point(460, 407);
            this.gboxTempo.Name = "gboxTempo";
            this.gboxTempo.Size = new System.Drawing.Size(441, 169);
            this.gboxTempo.TabIndex = 8;
            this.gboxTempo.TabStop = false;
            this.gboxTempo.Text = "Cronometro";
            // 
            // lblCronometro
            // 
            this.lblCronometro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCronometro.Location = new System.Drawing.Point(99, 43);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(236, 89);
            this.lblCronometro.TabIndex = 0;
            this.lblCronometro.Text = "00:00";
            this.lblCronometro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picTime2
            // 
            this.picTime2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTime2.Location = new System.Drawing.Point(980, 366);
            this.picTime2.Name = "picTime2";
            this.picTime2.Size = new System.Drawing.Size(300, 300);
            this.picTime2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTime2.TabIndex = 10;
            this.picTime2.TabStop = false;
            // 
            // lblNomeArena
            // 
            this.lblNomeArena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeArena.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeArena.ForeColor = System.Drawing.Color.White;
            this.lblNomeArena.Location = new System.Drawing.Point(378, 251);
            this.lblNomeArena.Name = "lblNomeArena";
            this.lblNomeArena.Size = new System.Drawing.Size(600, 61);
            this.lblNomeArena.TabIndex = 11;
            this.lblNomeArena.Text = "ARENA";
            this.lblNomeArena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempoJogo
            // 
            this.lblTempoJogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTempoJogo.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTempoJogo.ForeColor = System.Drawing.Color.White;
            this.lblTempoJogo.Location = new System.Drawing.Point(559, 757);
            this.lblTempoJogo.Name = "lblTempoJogo";
            this.lblTempoJogo.Size = new System.Drawing.Size(300, 61);
            this.lblTempoJogo.TabIndex = 12;
            this.lblTempoJogo.Text = "TEMPO";
            // 
            // timerPlacar
            // 
            this.timerPlacar.Interval = 1000;
            this.timerPlacar.Tick += new System.EventHandler(this.timerPlacar_Tick_1);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.AllowDrop = true;
            this.btnRestaurar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Image = global::Placar_Eletrônico.Properties.Resources.restaurar24px;
            this.btnRestaurar.Location = new System.Drawing.Point(1312, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(30, 29);
            this.btnRestaurar.TabIndex = 16;
            this.btnRestaurar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.AllowDrop = true;
            this.btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = global::Placar_Eletrônico.Properties.Resources.minimizar24px;
            this.btnMinimizar.Location = new System.Drawing.Point(1276, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 29);
            this.btnMinimizar.TabIndex = 15;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.AllowDrop = true;
            this.btn_Fechar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Image = global::Placar_Eletrônico.Properties.Resources.fechar24px;
            this.btn_Fechar.Location = new System.Drawing.Point(1348, 12);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(30, 29);
            this.btn_Fechar.TabIndex = 14;
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 758);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 60);
            this.label1.TabIndex = 17;
            this.label1.Text = " COMETIDAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(953, 757);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 60);
            this.label2.TabIndex = 18;
            this.label2.Text = " COMETIDAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnRestaurar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 46);
            this.panel1.TabIndex = 19;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // picTime1
            // 
            this.picTime1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTime1.Location = new System.Drawing.Point(85, 366);
            this.picTime1.Name = "picTime1";
            this.picTime1.Size = new System.Drawing.Size(300, 300);
            this.picTime1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTime1.TabIndex = 9;
            this.picTime1.TabStop = false;
            // 
            // Placar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1390, 1000);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTempoJogo);
            this.Controls.Add(this.lblNomeArena);
            this.Controls.Add(this.picTime2);
            this.Controls.Add(this.picTime1);
            this.Controls.Add(this.gboxTempo);
            this.Controls.Add(this.lblTime2Falta);
            this.Controls.Add(this.lblFalta2);
            this.Controls.Add(this.lblFalta1);
            this.Controls.Add(this.lblTime1Falta);
            this.Controls.Add(this.lblPonto2);
            this.Controls.Add(this.lblTime2Ponto);
            this.Controls.Add(this.lblPonto1);
            this.Controls.Add(this.lblTime1Ponto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(442, 219);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Placar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Placar";
            this.Activated += new System.EventHandler(this.Placar_Activated);
            this.gboxTempo.ResumeLayout(false);
            this.gboxTempo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTime2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTime1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTime1Falta;
        private Label lblTime2Falta;
        private GroupBox gboxTempo;
        public System.Windows.Forms.Timer timerPlacar;
        public Label lblTime1Ponto;
        public Label lblTime2Ponto;
        public Label lblNomeArena;
        private Button btnRestaurar;
        private Button btnMinimizar;
        private Button btn_Fechar;
        public Label lblPonto1;
        public Label lblPonto2;
        public Label lblFalta1;
        public Label lblFalta2;
        public PictureBox picTime2;
        public Label lblTempoJogo;
        public Label lblCronometro;
        private Label label1;
        private Label label2;
        private Panel panel1;
        public PictureBox picTime1;
    }
}