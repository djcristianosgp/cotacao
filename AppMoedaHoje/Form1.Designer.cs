namespace AppMoedaHoje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtRetorno = new RichTextBox();
            btnBuscar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            statusStrip1 = new StatusStrip();
            label1 = new ToolStripStatusLabel();
            pbProgresso = new ToolStripProgressBar();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRetorno
            // 
            txtRetorno.Dock = DockStyle.Fill;
            txtRetorno.Location = new Point(0, 56);
            txtRetorno.Name = "txtRetorno";
            txtRetorno.Size = new Size(679, 429);
            txtRetorno.TabIndex = 0;
            txtRetorno.Text = "";
            // 
            // btnBuscar
            // 
            btnBuscar.Dock = DockStyle.Top;
            btnBuscar.Location = new Point(0, 0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(679, 56);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar Informações";
            btnBuscar.UseVisualStyleBackColor = true;
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
            statusStrip1.Location = new Point(0, 485);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(679, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            label1.Name = "label1";
            label1.Size = new Size(16, 17);
            label1.Text = "...";
            // 
            // pbProgresso
            // 
            pbProgresso.Maximum = 600;
            pbProgresso.Name = "pbProgresso";
            pbProgresso.Size = new Size(100, 16);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 507);
            Controls.Add(txtRetorno);
            Controls.Add(statusStrip1);
            Controls.Add(btnBuscar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
    }
}
