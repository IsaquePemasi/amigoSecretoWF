﻿using System;
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
            if (!Util.EmailIsValid(email))
            {
                //labelStatus.Text = "Email inválido";
                //labelStatus.ForeColor = System.Drawing.Color.Red;
                textBoxEmail.Text = "";
                textBoxEmail.Focus();
                return;
            }
            CadastrarAmigo();
        }

        private void keyPressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                string email = textBoxEmail.Text;
                if (!Util.EmailIsValid(email))
                {
                    //labelStatus.Text = "Email inválido";
                    //labelStatus.ForeColor = System.Drawing.Color.Red;
                    textBoxEmail.Text = "";
                    textBoxEmail.Focus();
                    return;
                }
                CadastrarAmigo();
            }
        }

        private void CadastrarAmigo()
        {
            if (textBoxNome.Text.Length == 0 || textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Os campos não podem ser vazios!");
            }
            else
            {
                Amigo amigo = new Amigo(textBoxNome.Text, textBoxEmail.Text);

                if (lista.Contains(amigo))
                {
                    MessageBox.Show("O E-mail digitado já está em uso", "Aviso");
                }
                else
                {
                    // Se não existir, então adiciona o objeto na lista
                    lista.Add(amigo);
                    // Ordena pelo nome
                    lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));

                    // E grava no arquivo (no arquivo não tem ordenação)
                    Persistencia.gravarSimples(amigo, "amigos.csv");

                    textBoxEmail.Text = "";
                    textBoxNome.Text = "";

                    DialogResult result = MessageBox.Show("Deseja cadastrar outro amigo?", "Aviso", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                    {
                        this.Close();
                        form1.atualizarLista(lista);
                    }
                    else
                    {
                        form1.atualizarLista(lista);
                        //labelStatus.Text = "";
                        textBoxNome.Focus();
                    }
                }
            }
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

            if (Util.EmailIsValid(email))
            {
                //labelStatus.Text = "Email válido";
                //labelStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                //labelStatus.Text = "Email inválido";
                //labelStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void InitializeComponent()
        {
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            buttonCadastrarAmigo = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 37);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(265, 23);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(14, 102);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(263, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // buttonCadastrarAmigo
            // 
            buttonCadastrarAmigo.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
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
            label2.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 7;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 8;
            label1.Text = "Nome:";
            // 
            // FormCadastro
            // 
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
                //labelStatus.Text = "Email inválido";
                //labelStatus.ForeColor = System.Drawing.Color.Red;
                textBoxEmail.Text = "";
                textBoxEmail.Focus();
                return;
            }
            CadastrarAmigo();
        }
    }
}