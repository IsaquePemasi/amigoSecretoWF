using amigoSecretoWF;

namespace amigoSecretoWF
{
    public partial class Form1 : Form
    {
        //lista � criada aqui
        private List<Amigo> listaDeAmigos = new List<Amigo>();
        public Form1()
        {
            InitializeComponent();
        }

        //chama o FormCadastro para o cadastro de um amigo
        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("secreto.csv") && new FileInfo("secreto.csv").Length > 0)
            {
                MessageBox.Show("J� existem pares secretos definidos. Caso voc� inclua outra pessoa, lembre-se de gerar novos pares!", "Aviso");
            }
            //passa a lista e o Form2 por parametro
            FormCadastro fc = new FormCadastro(listaDeAmigos, this);
            fc.ShowDialog();
        }
        //popular o listViewNomes com os elementos da List<Amigo>
        //public porque o FormCadastro utiliza, depois de cadastrar alguem
        public void atualizarLista(List<Amigo> lista)
        {
            //aqui � dado um Clear() pois os elementos s�o  ordenados pelo nome
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
            if (File.Exists("secreto.csv") && new FileInfo("secreto.csv").Length > 0)
            {
                MessageBox.Show("J� existem pares secretos definidos. Caso voc� inclua outra pessoa, lembre-se de gerar novos pares!", "Aviso");
            }
            //passa a lista e o Form2 por parametro
            FormCadastro fc = new FormCadastro(listaDeAmigos, this);
            fc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaDeAmigos.Count < 2)
            {
                MessageBox.Show("� necess�rio ter pelo menos dois amigos cadastrados para gerar os pares secretos.", "Aviso");
                return;
            }

            if (File.Exists("secreto.csv") && new FileInfo("secreto.csv").Length > 0)
            {

                DialogResult result = MessageBox.Show("O arquivo 'secreto.csv' j� cont�m dados. Ou seja, j� existem pares secretos definidos. Deseja gerar mesmo assim?", "Aviso", MessageBoxButtons.YesNo);

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

            MessageBox.Show("Os pares secretos foram gerados! Est�o guardados em um arquivo secreto!", "Aviso");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Se voc� apagar a lista, ir� apagar todos os dados dos cadastrados, inclusive os pares secretos. Tem certeza que deseja apagar?", "Aviso", MessageBoxButtons.YesNo);

            if (result1 == DialogResult.No)
            {
                return;
            }
            listaDeAmigos.Clear();
            listViewNomes.Items.Clear();
            Persistencia.apagarDados("amigos.csv");
            Persistencia.apagarDados("secreto.csv");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESSA �REA � CONFID�NCIAL, TEM CERTEZA QUE DESEJA CONTINUAR?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }
            DialogResult result1 = MessageBox.Show("VOC� ESTRAGAR� TODA A BRINCADEIRA SE ESPIAR QUEM PEGOU QUEM! QUER CONTINUAR MESMO ASSIM?", "Aviso", MessageBoxButtons.YesNo);

            if (result1 == DialogResult.No)
            {
                return;
            }
            ParesSecretos ps = new ParesSecretos();
            ps.ShowDialog();
        }

        private void listViewNomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}