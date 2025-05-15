namespace WinFormsArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntAbrirArquivo_Click(object sender, EventArgs e)
        {
            // se o retorno do método ShowDialog() for ok 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //instancia StreanReader para ler o arquivo
                StreamReader arq = new StreamReader(openFileDialog1.FileName);
                //grava o nome do arquivo na propriedade text do formulário 
                this.Text = openFileDialog1.FileName;
                //armazena o conteúdo do arquivo em um array de string 
                string[] str = { arq.ReadToEnd() };
                //atribui a variável str à propriedade lines do arquivo
                textBox1.Lines = str;
                //fecha o arquivo
                arq.Close();

            }
        }

        private void btnSalvarComo_Click(object sender, EventArgs e)
        {
            //se o retorno do método ShowDialog() for ok
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //declaração da variaável que vai salvar o arquivo
                StreamWriter Arq = new StreamWriter(saveFileDialog1.FileName);
                //Para cada linha no TextBox
                foreach (string s in textBox1.Lines)
                {
                    //escreve uma linha no arquivo
                    Arq.WriteLine(s);
                }
                //fecha o arquivo 
                Arq.Close();
            }
        }
    }
}
