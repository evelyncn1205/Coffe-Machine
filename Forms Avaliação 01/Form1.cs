namespace Forms_Avaliação_01
{
    public partial class FrmMaquinaDeCafe : Form
    {
        double saldo;
        string moeda ="";
        public FrmMaquinaDeCafe()
        {
            InitializeComponent();
        }
        

        private void rbMoedas_CheckedValue(object sender, EventArgs e)
        {
            //Inicializa a maquina colocando enable os botões para inserir moedas e os botões das moedas disponiveis. 
            
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                moeda = rb.Text;
                btn_InserirMoeda.Enabled = true;
                btn_Devolver.Enabled = true;
                progressBar1.Visible = true;
                lbl_Preparando.Visible = true;
            }
            else
                MessageBox.Show("Obrigatório inserir moedas!");
        }
        
       

        private void btn_Cafe_Click(object sender, EventArgs e)
        {
            VerificaMoedas(btn_Cafe.Text, "Café");      // inicia o prepado do café e diminui o valor do café no saldo inserido 
        }

        private void btn_Cappuccino_Click(object sender, EventArgs e)
        {
            VerificaMoedas(btn_Cappuccino.Text, "Cappuccino");    // inicia o prepado do cappuccino e diminui o valor do café no saldo inserido 
        }

        private void btn_Cha_Click(object sender, EventArgs e)
        {
            VerificaMoedas(btn_Cha.Text, "Chá");     // inicia o prepado do cha e diminui o valor do café no saldo inserido 
        }

        private void btn_Chocolate_Click(object sender, EventArgs e)
        {
            VerificaMoedas(btn_Chocolate.Text, "Chocolate");     // inicia o prepado do chocolate e diminui o valor do café no saldo inserido 
        }

        private void btn_InserirMoeda_Click(object sender, EventArgs e)
        {
            if (saldo <= 5)
            {
                saldo += Convert.ToDouble(moeda);
                saldo = Math.Round(saldo, 2);
                lbl_Saldo.Text = saldo.ToString();
                if (saldo > 0.20)
                {
                    gpBox_Produtos.Enabled = true;
                }
            }
            else MessageBox.Show("Insira seu pedido!");
        }

        private void VerificaMoedas(string valor, string txt)
        {
            //Verifica os valores das moedas inseridas, caso o saldo seja suficiente a bebida é liberada
            //e passa a estar pronta para consumo
            //caso o saldo seja insuficiente solicita ´que o usuário insira mais moeda e complete o seu pedido 
            //fazer a soma total do valor da compra e mostrar ao usuário
            if (saldo >= Convert.ToDouble (valor))
            {
                saldo -= Convert.ToDouble(valor);
                saldo = Math.Round(saldo, 2);
                lbl_Saldo.Text = saldo.ToString();
                ProgressBar();
                
                MessageBox.Show($"O {txt} está pronto!");
                progressBar1.Value = 0;               // zera a progress bar ao final de cada compra
            }
            
            else
            {
               progressBar1.Visible = false;
               lbl_Preparando.Visible=false;
                MessageBox.Show("Saldo insuficiente, necessário inserir mais moedas.");
            }
        }

        private void ProgressBar()
        {
            //Preenche a progress bar que acompanha o preparo sempre que for feito o pedido 
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Visible = true;   
                lbl_Preparando.Visible = true;
                progressBar1.Value = i;

            }
        }

        private void btn_Devolver_Click(object sender, EventArgs e)
        {
            // Mostra saldo ja inserido pelo usuário e o saldo restante após a compra 
            // Calcula o saldo restante depois do usuário efetuar a compra dos produtos
            // devolve o valor inserido caso o usuário desista da compra 
            // devolve o valor restante do saldo após a compra dos produtos 
            double[,] troco = new double[2, 6] { { 2, 1, 0.50, 0.20, 0.10, 0.05 }, { 0, 0, 0, 0, 0, 0 } };

            for (int i = 0; i < troco.GetLength(1); i++)
            {
                while ((saldo / troco[0, i] >= 1) && saldo > 0)
                {
                    troco[1, i] += 1;
                    saldo -= troco[0, i];
                    saldo = Math.Round(saldo, 2);
                }
            }
            for (int j = 0; j < troco.GetLength(1); j++)
            {
                if (troco[1, j] != 0)
                {
                    Console.WriteLine($"\n\t  {troco[1, j]} {Math.Round(troco[0, j], 2)} € \r");
                }
            }
            MessageBox.Show("Dinheiro devolvido!");
            lbl_Saldo.ResetText();          //limpa a label saldo depois do valor devolvido
            progressBar1.Value = 0;           // zera a progress bar

        }

        

       
    }
}