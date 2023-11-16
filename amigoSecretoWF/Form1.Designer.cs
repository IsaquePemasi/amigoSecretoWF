namespace amigoSecretoWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button3 = new Button();
            listViewNomes = new ListView();
            nome = new ColumnHeader();
            email = new ColumnHeader();
            button4 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.Purple;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(113, 19);
            button1.Name = "button1";
            button1.Size = new Size(86, 92);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = Color.Gray;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(282, 19);
            button3.Name = "button3";
            button3.Size = new Size(86, 92);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listViewNomes
            // 
            listViewNomes.Anchor = AnchorStyles.None;
            listViewNomes.BackColor = Color.Silver;
            listViewNomes.BackgroundImageTiled = true;
            listViewNomes.BorderStyle = BorderStyle.FixedSingle;
            listViewNomes.Columns.AddRange(new ColumnHeader[] { nome, email });
            listViewNomes.Font = new Font("Old English Text MT", 9F, FontStyle.Italic, GraphicsUnit.Point);
            listViewNomes.ForeColor = Color.Black;
            listViewNomes.Location = new Point(113, 111);
            listViewNomes.Name = "listViewNomes";
            listViewNomes.Size = new Size(594, 367);
            listViewNomes.TabIndex = 9;
            listViewNomes.TileSize = new Size(1000, 1000);
            listViewNomes.UseCompatibleStateImageBehavior = false;
            listViewNomes.View = View.Details;
            listViewNomes.SelectedIndexChanged += listViewNomes_SelectedIndexChanged;
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 280;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 280;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.BackColor = Color.Red;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(431, 19);
            button4.Name = "button4";
            button4.Size = new Size(88, 92);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.Lime;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(612, 19);
            button2.Name = "button2";
            button2.Size = new Size(95, 92);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Old English Text MT", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(113, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 16);
            label1.TabIndex = 13;
            label1.Text = "Cadastrar";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Old English Text MT", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(612, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 14;
            label2.Text = "Visualizar";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Old English Text MT", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(282, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 16);
            label3.TabIndex = 15;
            label3.Text = "Gerar";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Old English Text MT", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(431, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 16);
            label4.TabIndex = 16;
            label4.Text = "Limpar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 480);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(listViewNomes);
            Controls.Add(button3);
            Controls.Add(button1);
            Font = new Font("Old English Text MT", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Amigo Oculto";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private ListView listViewNomes;
        private ColumnHeader nome;
        private ColumnHeader email;
        private Button button4;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}