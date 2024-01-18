namespace Placar_Eletrônico
{
    partial class ConsultarJogos
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
            this.dgvConsultaJogo = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblGols1 = new System.Windows.Forms.Label();
            this.lblGols2 = new System.Windows.Forms.Label();
            this.lblFaltas1 = new System.Windows.Forms.Label();
            this.lblFaltas2 = new System.Windows.Forms.Label();
            this.lblFaltasCom1 = new System.Windows.Forms.Label();
            this.lblFaltasCom2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHorario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaJogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaJogo
            // 
            this.dgvConsultaJogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvConsultaJogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaJogo.Location = new System.Drawing.Point(13, 211);
            this.dgvConsultaJogo.MultiSelect = false;
            this.dgvConsultaJogo.Name = "dgvConsultaJogo";
            this.dgvConsultaJogo.RowHeadersWidth = 51;
            this.dgvConsultaJogo.RowTemplate.Height = 29;
            this.dgvConsultaJogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaJogo.Size = new System.Drawing.Size(1027, 147);
            this.dgvConsultaJogo.TabIndex = 0;
            this.dgvConsultaJogo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvConsultaJogo_MouseDoubleClick);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusca.Location = new System.Drawing.Point(15, 26);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(486, 30);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 35);
            this.label1.TabIndex = 27;
            this.label1.Text = "Jogos Encerrados";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtBusca);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(13, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 76);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime1.ForeColor = System.Drawing.Color.White;
            this.lblTime1.Location = new System.Drawing.Point(15, 56);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(97, 37);
            this.lblTime1.TabIndex = 29;
            this.lblTime1.Text = "Time 1";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime2.ForeColor = System.Drawing.Color.White;
            this.lblTime2.Location = new System.Drawing.Point(724, 56);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(97, 37);
            this.lblTime2.TabIndex = 30;
            this.lblTime2.Text = "Time 2";
            // 
            // lblLocal
            // 
            this.lblLocal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocal.ForeColor = System.Drawing.Color.White;
            this.lblLocal.Location = new System.Drawing.Point(311, 39);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(400, 61);
            this.lblLocal.TabIndex = 31;
            this.lblLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGols1
            // 
            this.lblGols1.AutoSize = true;
            this.lblGols1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGols1.ForeColor = System.Drawing.Color.White;
            this.lblGols1.Location = new System.Drawing.Point(266, 53);
            this.lblGols1.Name = "lblGols1";
            this.lblGols1.Size = new System.Drawing.Size(39, 41);
            this.lblGols1.TabIndex = 32;
            this.lblGols1.Text = "...";
            // 
            // lblGols2
            // 
            this.lblGols2.AutoSize = true;
            this.lblGols2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGols2.ForeColor = System.Drawing.Color.White;
            this.lblGols2.Location = new System.Drawing.Point(979, 53);
            this.lblGols2.Name = "lblGols2";
            this.lblGols2.Size = new System.Drawing.Size(39, 41);
            this.lblGols2.TabIndex = 33;
            this.lblGols2.Text = "...";
            // 
            // lblFaltas1
            // 
            this.lblFaltas1.AutoSize = true;
            this.lblFaltas1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFaltas1.ForeColor = System.Drawing.Color.White;
            this.lblFaltas1.Location = new System.Drawing.Point(15, 112);
            this.lblFaltas1.Name = "lblFaltas1";
            this.lblFaltas1.Size = new System.Drawing.Size(242, 41);
            this.lblFaltas1.TabIndex = 34;
            this.lblFaltas1.Text = "Faltas Cometidas";
            // 
            // lblFaltas2
            // 
            this.lblFaltas2.AutoSize = true;
            this.lblFaltas2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFaltas2.ForeColor = System.Drawing.Color.White;
            this.lblFaltas2.Location = new System.Drawing.Point(724, 112);
            this.lblFaltas2.Name = "lblFaltas2";
            this.lblFaltas2.Size = new System.Drawing.Size(242, 41);
            this.lblFaltas2.TabIndex = 35;
            this.lblFaltas2.Text = "Faltas Cometidas";
            // 
            // lblFaltasCom1
            // 
            this.lblFaltasCom1.AutoSize = true;
            this.lblFaltasCom1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFaltasCom1.ForeColor = System.Drawing.Color.White;
            this.lblFaltasCom1.Location = new System.Drawing.Point(266, 112);
            this.lblFaltasCom1.Name = "lblFaltasCom1";
            this.lblFaltasCom1.Size = new System.Drawing.Size(39, 41);
            this.lblFaltasCom1.TabIndex = 36;
            this.lblFaltasCom1.Text = "...";
            // 
            // lblFaltasCom2
            // 
            this.lblFaltasCom2.AutoSize = true;
            this.lblFaltasCom2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFaltasCom2.ForeColor = System.Drawing.Color.White;
            this.lblFaltasCom2.Location = new System.Drawing.Point(979, 112);
            this.lblFaltasCom2.Name = "lblFaltasCom2";
            this.lblFaltasCom2.Size = new System.Drawing.Size(39, 41);
            this.lblFaltasCom2.TabIndex = 37;
            this.lblFaltasCom2.Text = "...";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(258, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 100);
            this.label2.TabIndex = 38;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(971, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 100);
            this.label3.TabIndex = 39;
            this.label3.Text = "|";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.lblHorario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTime2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTime1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblLocal);
            this.panel1.Controls.Add(this.lblFaltasCom2);
            this.panel1.Controls.Add(this.lblGols1);
            this.panel1.Controls.Add(this.lblFaltasCom1);
            this.panel1.Controls.Add(this.lblGols2);
            this.panel1.Controls.Add(this.lblFaltas2);
            this.panel1.Controls.Add(this.lblFaltas1);
            this.panel1.Location = new System.Drawing.Point(13, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 196);
            this.panel1.TabIndex = 40;
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(466, 115);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(117, 41);
            this.lblHorario.TabIndex = 43;
            this.lblHorario.Text = "Horário";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(719, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 2);
            this.label5.TabIndex = 41;
            this.label5.Text = "|";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 2);
            this.label4.TabIndex = 40;
            this.label4.Text = "|";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Placar_Eletrônico.Properties.Resources.ConsultarJogos;
            this.pictureBox1.Location = new System.Drawing.Point(488, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultarJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1053, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultaJogo);
            this.MaximizeBox = false;
            this.Name = "ConsultarJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultar Jogos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaJogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvConsultaJogo;
        private TextBox txtBusca;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblTime2;
        private Label lblLocal;
        private Label lblGols1;
        private Label lblGols2;
        private Label lblFaltas1;
        private Label lblFaltas2;
        private Label lblFaltasCom1;
        private Label lblFaltasCom2;
        private Label label2;
        private Label label3;
        private Panel panel1;
        public Label lblTime1;
        private Label label5;
        private Label label4;
        private Label lblHorario;
        private PictureBox pictureBox1;
    }
}