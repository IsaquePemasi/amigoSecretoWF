using amigoSecretoWF;

namespace amigoSecretoWF
{
    public partial class Form1 : Form
    {
        private List<Amigo> listaDeAmigos = new List<Amigo>();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            FormCadastro fc = new FormCadastro(listaDeAmigos, this);
            fc.ShowDialog();
        }
        public void atualizarLista(List<Amigo> lista)
        {
            listViewNomes.Items.Clear();
            foreach (var amigo in lista)
            {
                string[] itens = { amigo.Nome, amigo.Email };
                listViewNomes.Items.Add(new ListViewItem(itens));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormCadastro fc = new FormCadastro(listaDeAmigos, this);
            fc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaDeAmigos.Count < 2)
            {
                MessageBox.Show("Você não tem amigos? cadastre ao menos 2 pessoas, para gerar o amigo secreto.", "Ai não né!");
                return;
            }

            if (File.Exists("secreto.csv") && new FileInfo("secreto.csv").Length > 0)
            {

                DialogResult result = MessageBox.Show("O arquivo '.csv' já contém dados. Deseja gerar mesmo assim?", "Arquivo '.csv'", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            List<Amigo> listaTmp = new List<Amigo>();
            listaTmp.AddRange(listaDeAmigos);

            bool deuCerto;
            do
            {
                deuCerto = true;
                listaTmp = listaTmp.OrderBy(x => Random.Shared.Next()).ToList();

                for (int i = 0; i < listaDeAmigos.Count; i++)
                {
                    if (listaDeAmigos[i] == listaTmp[i])
                    {
                        deuCerto = false;
                        listaTmp.Clear();
                        listaTmp.AddRange(listaDeAmigos);
                        break;
                    }
                }
            } while (!deuCerto);

            Persistencia.gerarArquivoAmigoSecreto(listaDeAmigos, listaTmp);

            MessageBox.Show("Gerado com sucesso! Guardado no Arquivo '.csv'", "Concluído");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listaDeAmigos.Clear();
            listViewNomes.Items.Clear();
            Persistencia.apagarDados("amigos.csv");
            Persistencia.apagarDados("secreto.csv");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParesSecretos ps = new ParesSecretos();
            ps.ShowDialog();
        }

        private void listViewNomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}