namespace AppMoedaHoje
{
    partial class Cotacao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotacao));
            txtRetorno = new RichTextBox();
            btnBuscar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            statusStrip1 = new StatusStrip();
            label1 = new ToolStripStatusLabel();
            pbProgresso = new ToolStripProgressBar();
            pnMoedas = new Panel();
            gbBTC = new GroupBox();
            lblBTCMenorPreco = new Label();
            label12 = new Label();
            lblBTCMaiorPreco = new Label();
            label14 = new Label();
            lblBTCPrecoAtual = new Label();
            label16 = new Label();
            gbEUR = new GroupBox();
            lblEURMenorPreco = new Label();
            label5 = new Label();
            lblEURMaiorPreco = new Label();
            label8 = new Label();
            lblEURPrecoAtual = new Label();
            label10 = new Label();
            gbUSD = new GroupBox();
            lblUSDMenorPreco = new Label();
            label6 = new Label();
            lblUSDMaiorPreco = new Label();
            label4 = new Label();
            lblUBDPrecoAtual = new Label();
            label2 = new Label();
            statusStrip1.SuspendLayout();
            pnMoedas.SuspendLayout();
            gbBTC.SuspendLayout();
            gbEUR.SuspendLayout();
            gbUSD.SuspendLayout();
            SuspendLayout();
            // 
            // txtRetorno
            // 
            txtRetorno.BackColor = SystemColors.ControlDark;
            txtRetorno.Dock = DockStyle.Fill;
            txtRetorno.Location = new Point(0, 60);
            txtRetorno.Name = "txtRetorno";
            txtRetorno.Size = new Size(761, 532);
            txtRetorno.TabIndex = 0;
            txtRetorno.Text = "";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ControlDark;
            btnBuscar.Dock = DockStyle.Top;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(0, 0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(934, 60);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar Informações";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 600000;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Info";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { label1, pbProgresso });
            statusStrip1.Location = new Point(0, 592);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(934, 23);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            label1.Name = "label1";
            label1.Size = new Size(16, 18);
            label1.Text = "...";
            // 
            // pbProgresso
            // 
            pbProgresso.Maximum = 600;
            pbProgresso.Name = "pbProgresso";
            pbProgresso.Size = new Size(100, 17);
            // 
            // pnMoedas
            // 
            pnMoedas.Controls.Add(gbBTC);
            pnMoedas.Controls.Add(gbEUR);
            pnMoedas.Controls.Add(gbUSD);
            pnMoedas.Dock = DockStyle.Right;
            pnMoedas.Location = new Point(761, 60);
            pnMoedas.Name = "pnMoedas";
            pnMoedas.Size = new Size(173, 532);
            pnMoedas.TabIndex = 3;
            // 
            // gbBTC
            // 
            gbBTC.Controls.Add(lblBTCMenorPreco);
            gbBTC.Controls.Add(label12);
            gbBTC.Controls.Add(lblBTCMaiorPreco);
            gbBTC.Controls.Add(label14);
            gbBTC.Controls.Add(lblBTCPrecoAtual);
            gbBTC.Controls.Add(label16);
            gbBTC.Dock = DockStyle.Top;
            gbBTC.ForeColor = SystemColors.ButtonHighlight;
            gbBTC.Location = new Point(0, 242);
            gbBTC.Name = "gbBTC";
            gbBTC.Size = new Size(173, 121);
            gbBTC.TabIndex = 2;
            gbBTC.TabStop = false;
            gbBTC.Tag = "BTC";
            gbBTC.Text = "BTC";
            // 
            // lblBTCMenorPreco
            // 
            lblBTCMenorPreco.BackColor = SystemColors.ControlLight;
            lblBTCMenorPreco.Dock = DockStyle.Top;
            lblBTCMenorPreco.Location = new Point(3, 97);
            lblBTCMenorPreco.Name = "lblBTCMenorPreco";
            lblBTCMenorPreco.Size = new Size(167, 16);
            lblBTCMenorPreco.TabIndex = 5;
            lblBTCMenorPreco.Text = "Menor Preço";
            lblBTCMenorPreco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Top;
            label12.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold);
            label12.Location = new Point(3, 81);
            label12.Name = "label12";
            label12.Size = new Size(167, 16);
            label12.TabIndex = 4;
            label12.Text = "Menor Preço";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBTCMaiorPreco
            // 
            lblBTCMaiorPreco.Dock = DockStyle.Top;
            lblBTCMaiorPreco.Location = new Point(3, 65);
            lblBTCMaiorPreco.Name = "lblBTCMaiorPreco";
            lblBTCMaiorPreco.Size = new Size(167, 16);
            lblBTCMaiorPreco.TabIndex = 3;
            lblBTCMaiorPreco.Text = "Maior Preço";
            lblBTCMaiorPreco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold);
            label14.Location = new Point(3, 49);
            label14.Name = "label14";
            label14.Size = new Size(167, 16);
            label14.TabIndex = 2;
            label14.Text = "Maior Preço";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBTCPrecoAtual
            // 
            lblBTCPrecoAtual.Dock = DockStyle.Top;
            lblBTCPrecoAtual.Location = new Point(3, 33);
            lblBTCPrecoAtual.Name = "lblBTCPrecoAtual";
            lblBTCPrecoAtual.Size = new Size(167, 16);
            lblBTCPrecoAtual.TabIndex = 1;
            lblBTCPrecoAtual.Text = "Preço Atual";
            lblBTCPrecoAtual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.ControlLight;
            label16.Dock = DockStyle.Top;
            label16.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold);
            label16.Location = new Point(3, 17);
            label16.Name = "label16";
            label16.Size = new Size(167, 16);
            label16.TabIndex = 0;
            label16.Text = "Preço Atual";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbEUR
            // 
            gbEUR.Controls.Add(lblEURMenorPreco);
            gbEUR.Controls.Add(label5);
            gbEUR.Controls.Add(lblEURMaiorPreco);
            gbEUR.Controls.Add(label8);
            gbEUR.Controls.Add(lblEURPrecoAtual);
            gbEUR.Controls.Add(label10);
            gbEUR.Dock = DockStyle.Top;
            gbEUR.ForeColor = SystemColors.ButtonHighlight;
            gbEUR.Location = new Point(0, 121);
            gbEUR.Name = "gbEUR";
            gbEUR.Size = new Size(173, 121);
            gbEUR.TabIndex = 1;
            gbEUR.TabStop = false;
            gbEUR.Tag = "EUR";
            gbEUR.Text = "EUR";
            // 
            // lblEURMenorPreco
            // 
            lblEURMenorPreco.BackColor = SystemColors.ControlLight;
            lblEURMenorPreco.Dock = DockStyle.Top;
            lblEURMenorPreco.Location = new Point(3, 97);
            lblEURMenorPreco.Name = "lblEURMenorPreco";
            lblEURMenorPreco.Size = new Size(167, 16);
            lblEURMenorPreco.TabIndex = 5;
            lblEURMenorPreco.Text = "Menor Preço";
            lblEURMenorPreco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold);
            label5.Location = new Point(3, 81);
            label5.Name = "label5";
            label5.Size = new Size(167, 16);
            label5.TabIndex = 4;
            label5.Text = "Menor Preço";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEURMaiorPreco
            // 
            lblEURMaiorPreco.Dock = DockStyle.Top;
            lblEURMaiorPreco.Location = new Point(3, 65);
            lblEURMaiorPreco.Name = "lblEURMaiorPreco";
            lblEURMaiorPreco.Size = new Size(167, 16);
            lblEURMaiorPreco.TabIndex = 3;
            lblEURMaiorPreco.Text = "Maior Preço";
            lblEURMaiorPreco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold);
            label8.Location = new Point(3, 49);
            label8.Name = "label8";
            label8.Size = new Size(167, 16);
            label8.TabIndex = 2;
            label8.Text = "Maior Preço";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEURPrecoAtual
            // 
            lblEURPrecoAtual.Dock = DockStyle.Top;
            lblEURPrecoAtual.Location = new Point(3, 33);
            lblEURPrecoAtual.Name = "lblEURPrecoAtual";
            lblEURPrecoAtual.Size = new Size(167, 16);
            lblEURPrecoAtual.TabIndex = 1;
            lblEURPrecoAtual.Text = "Preço Atual";
            lblEURPrecoAtual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ControlLight;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold);
            label10.Location = new Point(3, 17);
            label10.Name = "label10";
            label10.Size = new Size(167, 16);
            label10.TabIndex = 0;
            label10.Text = "Preço Atual";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbUSD
            // 
            gbUSD.Controls.Add(lblUSDMenorPreco);
            gbUSD.Controls.Add(label6);
            gbUSD.Controls.Add(lblUSDMaiorPreco);
            gbUSD.Controls.Add(label4);
            gbUSD.Controls.Add(lblUBDPrecoAtual);
            gbUSD.Controls.Add(label2);
            gbUSD.Dock = DockStyle.Top;
            gbUSD.ForeColor = SystemColors.ButtonHighlight;
            gbUSD.Location = new Point(0, 0);
            gbUSD.Name = "gbUSD";
            gbUSD.Size = new Size(173, 121);
            gbUSD.TabIndex = 0;
            gbUSD.TabStop = false;
            gbUSD.Tag = "USD";
            gbUSD.Text = "USD";
            // 
            // lblUSDMenorPreco
            // 
            lblUSDMenorPreco.BackColor = SystemColors.ControlLight;
            lblUSDMenorPreco.Dock = DockStyle.Top;
            lblUSDMenorPreco.Location = new Point(3, 97);
            lblUSDMenorPreco.Name = "lblUSDMenorPreco";
            lblUSDMenorPreco.Size = new Size(167, 16);
            lblUSDMenorPreco.TabIndex = 5;
            lblUSDMenorPreco.Text = "Menor Preço";
            lblUSDMenorPreco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold);
            label6.Location = new Point(3, 81);
            label6.Name = "label6";
            label6.Size = new Size(167, 16);
            label6.TabIndex = 4;
            label6.Text = "Menor Preço";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUSDMaiorPreco
            // 
            lblUSDMaiorPreco.Dock = DockStyle.Top;
            lblUSDMaiorPreco.Location = new Point(3, 65);
            lblUSDMaiorPreco.Name = "lblUSDMaiorPreco";
            lblUSDMaiorPreco.Size = new Size(167, 16);
            lblUSDMaiorPreco.TabIndex = 3;
            lblUSDMaiorPreco.Text = "Maior Preço";
            lblUSDMaiorPreco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold);
            label4.Location = new Point(3, 49);
            label4.Name = "label4";
            label4.Size = new Size(167, 16);
            label4.TabIndex = 2;
            label4.Text = "Maior Preço";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUBDPrecoAtual
            // 
            lblUBDPrecoAtual.Dock = DockStyle.Top;
            lblUBDPrecoAtual.Location = new Point(3, 33);
            lblUBDPrecoAtual.Name = "lblUBDPrecoAtual";
            lblUBDPrecoAtual.Size = new Size(167, 16);
            lblUBDPrecoAtual.TabIndex = 1;
            lblUBDPrecoAtual.Text = "Preço Atual";
            lblUBDPrecoAtual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLight;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold);
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(167, 16);
            label2.TabIndex = 0;
            label2.Text = "Preço Atual";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cotacao
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(934, 615);
            Controls.Add(txtRetorno);
            Controls.Add(pnMoedas);
            Controls.Add(statusStrip1);
            Controls.Add(btnBuscar);
            Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cotacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotação";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnMoedas.ResumeLayout(false);
            gbBTC.ResumeLayout(false);
            gbEUR.ResumeLayout(false);
            gbUSD.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtRetorno;
        private Button btnBuscar;
        private System.Windows.Forms.Timer timer1;
        private NotifyIcon notifyIcon1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel label1;
        private ToolStripProgressBar pbProgresso;
        private Panel pnMoedas;
        private GroupBox gbUSD;
        private Label label2;
        private Label lblUSDMenorPreco;
        private Label label6;
        private Label lblUSDMaiorPreco;
        private Label label4;
        private Label lblUBDPrecoAtual;
        private GroupBox gbBTC;
        private Label lblBTCMenorPreco;
        private Label label12;
        private Label lblBTCMaiorPreco;
        private Label label14;
        private Label lblBTCPrecoAtual;
        private Label label16;
        private GroupBox gbEUR;
        private Label lblEURMenorPreco;
        private Label label5;
        private Label lblEURMaiorPreco;
        private Label label8;
        private Label lblEURPrecoAtual;
        private Label label10;
    }
}
