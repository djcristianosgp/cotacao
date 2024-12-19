using System.Globalization;


namespace AppMoedaHoje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configura o Timer principal (10 minutos de intervalo).
            timer1.Interval = 10 * 60 * 1000; // 10 minutos em milissegundos.
            timer1.Tick += async (sender, e) => await Timer1_Tick();

            // Configura o Timer para o contador regressivo (atualização a cada segundo).
            countdownTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // 1 segundo.
            };
            countdownTimer.Tick += CountdownTimer_Tick;

            // Inicia os timers.
            timer1.Start();
            countdownTimer.Start();
            pbProgresso.Maximum = countdownTime;
            pbProgresso.Value = countdownTime;
            higt = new List<HigtPReco>();
        }


        private List<HigtPReco> higt;
        private int countdownTime = 600; // Tempo em segundos (10 minutos).
        private System.Windows.Forms.Timer countdownTimer;    // Timer para atualizar a label.

        string TextMensagem = "Moeda: {0} | Maior preço de hoje: {1} | Menor preço de hoje: {2} | Preço Atual: {3}";

        private async void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            await BuscaDados();
        }

        public async Task BuscaDados()
        {
            txtRetorno.ReadOnly = true;
            var apiConnector = new ApiConnector();
            var retorno = await apiConnector.FetchAndMonitorCurrencyDataAsync();
            var dataAtual = DateTime.Now;
            if (!String.IsNullOrEmpty(retorno.Item1))
            {
                MessageBox.Show(retorno.Item1);
                return;
            }

            txtRetorno.Text += $"---------------------------- Data: {dataAtual}----------------------------{Environment.NewLine}";

            foreach (var item in retorno.Item2)
            {
                var moeda = item.Code;
                var maiorprecohoje = Math.Round(decimal.Parse(item.High, CultureInfo.InvariantCulture), 2);
                var menosprecohoje = Math.Round(decimal.Parse(item.Low, CultureInfo.InvariantCulture), 2);
                var precohoje = Math.Round(decimal.Parse(item.Ask, CultureInfo.InvariantCulture), 2);
                var dataPEsquisa = Convert.ToDateTime(item.Create_Date).ToString("dd/MM/yyyy");
                txtRetorno.AppendText($"{String.Format(TextMensagem, moeda, maiorprecohoje.ToString("C", new CultureInfo("pt-BR")),
                    menosprecohoje.ToString("C", new CultureInfo("pt-BR")), precohoje.ToString("C", new CultureInfo("pt-BR")))} {Environment.NewLine}");
                var itemLista = higt.FirstOrDefault(xax => xax.Code == moeda && xax.CreateDate == dataAtual.ToString("dd/MM/yyyy"));

                if (itemLista != null)
                {
                    itemLista.CreateDate = dataPEsquisa;
                    if (item.HighValue > itemLista.High && itemLista.High > 0)
                    {
                        var mensagem = $"🫶🏼> Moeda: {moeda} superou maior preço de hoje que era: {itemLista.High.ToString("C", new CultureInfo("pt-BR"))}" +
                            $" | O preço é {item.HighValue.ToString("C", new CultureInfo("pt-BR"))}{Environment.NewLine} ";
                        // MessageBox.Show(mensagem);
                         ExibeMensagem(mensagem, moeda);
                        txtRetorno.AppendText(mensagem);
                    }

                    if (item.LowValue < itemLista.Low && itemLista.Low > 0)
                    {
                        var mensagem = $"🕺🏼> Moeda: {moeda} superou menor preço de hoje que era: {itemLista.Low.ToString("C", new CultureInfo("pt-BR"))}" +
                            $" | O preço é {item.LowValue.ToString("C", new CultureInfo("pt-BR"))}{Environment.NewLine} ";
                        // MessageBox.Show(mensagem);
                         ExibeMensagem(mensagem, moeda);
                        txtRetorno.AppendText(mensagem);
                    }

                    itemLista.High = maiorprecohoje;
                    itemLista.Low = menosprecohoje;
                    itemLista.Ask = precohoje;
                }
                else
                {
                    var novoItem = new HigtPReco
                    {
                        Code = moeda,
                        High = maiorprecohoje,
                        Low = menosprecohoje,
                        Ask = precohoje,
                        CreateDate = dataPEsquisa == "01/01/0001" ? dataAtual.ToString("dd/MM/yyyy") : dataPEsquisa,
                        Name = item.Name
                    };
                    higt.Add(novoItem);

                }
                //if (higt.Any(xax => xax.Code == moeda))
                //{

                //}
            }
            await ColorirTextAsync(txtRetorno);

        }

        public void ExibeMensagem(string mensagem, string moeda)
        {
            // Garante que o texto não exceda o limite permitido.
            notifyIcon1.Text = mensagem.Length > 63 ? mensagem.Substring(0, 63) : mensagem;

            notifyIcon1.BalloonTipTitle = moeda;
            notifyIcon1.BalloonTipText = mensagem;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(5000); // Mostra a notificação por 5 segundos.
        }

        public async Task ColorirTextAsync(RichTextBox richTextBox)
        {
            richTextBox.SuspendLayout(); // Suspende a atualização do controle para melhor performance.

            foreach (var line in richTextBox.Lines)
            {
                if (line.Contains("🫶🏼"))
                {
                    int startIndex = richTextBox.Text.IndexOf(line); // Encontra a posição inicial da linha.
                    if (startIndex != -1)
                    {
                        richTextBox.Select(startIndex, line.Length); // Seleciona a linha inteira.
                        richTextBox.SelectionColor = Color.Red; // Define a cor.
                    }
                }
                else if (line.Contains("🕺🏼"))
                {
                    int startIndex = richTextBox.Text.IndexOf(line); // Encontra a posição inicial da linha.
                    if (startIndex != -1)
                    {
                        richTextBox.Select(startIndex, line.Length); // Seleciona a linha inteira.
                        richTextBox.SelectionColor = Color.DarkGreen; // Define a cor.
                    }
                }
            }

            richTextBox.SelectionStart = richTextBox.Text.Length; // Move o cursor para o final.
            richTextBox.SelectionColor = Color.Black; // Restaura a cor padrão.
            richTextBox.ResumeLayout(); // Retoma a atualização do controle.
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await BuscaDados();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (countdownTime > 0)
            {
                countdownTime--;
                TimeSpan timeSpan = TimeSpan.FromSeconds(countdownTime);
                label1.Text = $"Próxima execução em: {timeSpan:mm\\:ss}";
                pbProgresso.Value = countdownTime;
            }
            else
            {
                countdownTime = 600; // Reinicia o tempo.
                pbProgresso.Maximum = countdownTime;
                pbProgresso.Value = countdownTime;
            }
        }
        private async Task Timer1_Tick()
        {
            countdownTime = 600; // Reinicia o contador regressivo.
            await BuscaDados();
        }
    }
}
