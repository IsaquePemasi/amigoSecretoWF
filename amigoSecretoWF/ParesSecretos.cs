using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amigoSecretoWF
{
    public partial class ParesSecretos : Form
    {
        public ParesSecretos()
        {
            InitializeComponent();
            Persistencia.mostrarPares("secreto.csv", listViewSecreto);
        }

        private void InitializeComponent()
        {
            listViewSecreto = new ListView();
            nome1 = new ColumnHeader();
            nome2 = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewSecreto
            // 
            listViewSecreto.Columns.AddRange(new ColumnHeader[] { nome1, nome2 });
            listViewSecreto.Location = new Point(28, 34);
            listViewSecreto.Name = "listViewSecreto";
            listViewSecreto.Size = new Size(425, 279);
            listViewSecreto.TabIndex = 1;
            listViewSecreto.UseCompatibleStateImageBehavior = false;
            listViewSecreto.View = View.Details;
            listViewSecreto.SelectedIndexChanged += listViewSecreto_SelectedIndexChanged;
            // 
            // nome1
            // 
            nome1.Text = "Esse";
            nome1.Width = 200;
            // 
            // nome2
            // 
            nome2.Text = "Pegou esse";
            nome2.Width = 200;
            // 
            // ParesSecretos
            // 
            ClientSize = new Size(480, 346);
            Controls.Add(listViewSecreto);
            Name = "ParesSecretos";
            ResumeLayout(false);
        }

        private void ParesSecretos_Load(object sender, EventArgs e)
        {
        }

        private void listViewSecreto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private ListView listViewSecreto;
        private ColumnHeader nome1;
        private ColumnHeader nome2;
    }
}
