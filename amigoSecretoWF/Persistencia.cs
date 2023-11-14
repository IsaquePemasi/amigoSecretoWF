using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amigoSecretoWF
{
    public class Persistencia
    {
        public static void popularArquivoLista(string nomeArquivo, List<Amigo> lista)
        {
            try
            {
                using (StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8))
                {
                    while (!leitor.EndOfStream)
                    {
                        string linha = leitor.ReadLine();

                        // Verifica se a linha não é nula ou vazia
                        if (!string.IsNullOrEmpty(linha))
                        {
                            string[] vetorLinha = linha.Split(";");

                            // Verifica se o vetorLinha contém pelo menos dois elementos
                            if (vetorLinha.Length >= 2)
                            {
                                Amigo tmp = new Amigo(vetorLinha[0], vetorLinha[1]);

                                if (!lista.Contains(tmp))
                                {
                                    lista.Add(tmp);
                                }
                            }
                            else
                            {
                                // Lidar com linhas que não têm o formato esperado
                                MessageBox.Show("Linha com formato inválido: " + linha);
                            }
                        }
                    }
                }
                lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));
            }
            catch (Exception)
            {
               MessageBox.Show("Problemas com arquivo");
            }
        }

        //recebe um objeto e o nome do arquivo e grava nesse arquivo
        public static void gravarSimples(Amigo a, string nomeArquivo)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(nomeArquivo, append: true))
                {
                    escritor.WriteLine(a.Nome + ";" + a.Email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas com arquivo: " + ex.Message);
            }

        }

        public static void gerarArquivoAmigoSecreto(List<Amigo> lista, List<Amigo> listaTmp)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter("secreto.csv"))
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        escritor.WriteLine(lista[i].Nome + ";" + lista[i].Email + ";" + listaTmp[i].Nome + ";" + listaTmp[i].Email);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas com arquivo: " + ex.Message);
            }
        }


        public static void apagarDados(string nomeArquivo)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(nomeArquivo, append: false))
                {
                    escritor.Write("");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com arquivo");
            }
        }

        //metodo para mostrar os pares secretos
        public static void mostrarPares(string nomeArquivo, ListView listView)
        {
            try
            {
                listView.Items.Clear();

                using (StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8))
                {
                    while (!leitor.EndOfStream)
                    {
                        string linha = leitor.ReadLine();

                        if (!string.IsNullOrEmpty(linha))
                        {
                            string[] vetorLinha = linha.Split(";");

                            if (vetorLinha.Length >= 3)
                            {

                                ListViewItem item = new ListViewItem(new[] { vetorLinha[0], vetorLinha[2] });
                                listView.Items.Add(item);
                            }
                            else
                            {
                                MessageBox.Show("Linha com formato inválido: " + linha);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com arquivo");
            }
        }


    }
}
