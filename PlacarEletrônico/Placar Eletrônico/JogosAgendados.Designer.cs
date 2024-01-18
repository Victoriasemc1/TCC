namespace Placar_Eletrônico
{
    partial class JogosAgendados
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
            this.btnEnviarCad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbJogos = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviarCad
            // 
            this.btnEnviarCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviarCad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEnviarCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviarCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEnviarCad.Location = new System.Drawing.Point(404, 529);
            this.btnEnviarCad.Name = "btnEnviarCad";
            this.btnEnviarCad.Size = new System.Drawing.Size(200, 33);
            this.btnEnviarCad.TabIndex = 25;
            this.btnEnviarCad.Text = "Enviar";
            this.btnEnviarCad.UseVisualStyleBackColor = false;
            this.btnEnviarCad.UseWaitCursor = true;
            this.btnEnviarCad.Click += new System.EventHandler(this.btnEnviarCad_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(387, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "Agenda de Jogos";
            // 
            // lbJogos
            // 
            this.lbJogos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbJogos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lbJogos.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbJogos.ForeColor = System.Drawing.Color.White;
            this.lbJogos.FormattingEnabled = true;
            this.lbJogos.ItemHeight = 26;
            this.lbJogos.Location = new System.Drawing.Point(59, 193);
            this.lbJogos.Name = "lbJogos";
            this.lbJogos.Size = new System.Drawing.Size(882, 316);
            this.lbJogos.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Placar_Eletrônico.Properties.Resources.agenda_jogos;
            this.pictureBox1.Location = new System.Drawing.Point(463, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // JogosAgendados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(999, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbJogos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviarCad);
            this.Name = "JogosAgendados";
            this.Text = "Jogos Agendados";
            this.Load += new System.EventHandler(this.Listar_jogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnEnviarCad;
        private Label label1;
        private ListBox lbJogos;
        private PictureBox pictureBox1;
    }
}