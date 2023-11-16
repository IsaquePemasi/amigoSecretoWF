using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace amigoSecretoWF
{
    public partial class FormCadastro : Form
    {
        private List<Amigo> lista;
        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private Button buttonCadastrarAmigo;
        private Label label2;
        private Label label1;
        private Form1 form1;

        public FormCadastro(List<Amigo> lista, Form1 form1)
        {
            InitializeComponent();
            this.lista = lista;
            this.form1 = form1;
        }

        private void buttonCadastrarAmigo_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            CadastrarAmigo();
        }

        private void keyPressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                CadastrarAmigo();
            }
        }

        private void CadastrarAmigo()
        {
            Amigo amigo = new Amigo(textBoxNome.Text, textBoxEmail.Text);
            lista.Add(amigo);
            lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));
            Persistencia.gravarSimples(amigo, "amigos.csv");
            textBoxEmail.Text = "";
            textBoxNome.Text = "";
            this.Close();
            form1.atualizarLista(lista);
        }

        private void keyPressEnterNome(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                textBoxEmail.Focus();
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormCadastro));
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            buttonCadastrarAmigo = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Old English Text MT", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxNome.Location = new Point(12, 37);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(265, 22);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Old English Text MT", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(14, 102);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(263, 22);
            textBoxEmail.TabIndex = 5;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged_1;
            // 
            // buttonCadastrarAmigo
            // 
            buttonCadastrarAmigo.Font = new Font("Old English Text MT", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonCadastrarAmigo.Location = new Point(177, 187);
            buttonCadastrarAmigo.Name = "buttonCadastrarAmigo";
            buttonCadastrarAmigo.Size = new Size(95, 31);
            buttonCadastrarAmigo.TabIndex = 6;
            buttonCadastrarAmigo.Text = "Cadastrar";
            buttonCadastrarAmigo.UseVisualStyleBackColor = true;
            buttonCadastrarAmigo.Click += buttonCadastrarAmigo_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Old English Text MT", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(37, 16);
            label2.TabIndex = 7;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Old English Text MT", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(39, 16);
            label1.TabIndex = 8;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // FormCadastro
            // 
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(284, 261);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(buttonCadastrarAmigo);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            Name = "FormCadastro";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
        }

        private void buttonCadastrarAmigo_Click_1(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if (!Util.EmailIsValid(email))
            {
                textBoxEmail.Text = "";
                textBoxEmail.Focus();
                return;
            }
            CadastrarAmigo();
        }

        private void textBoxEmail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}