namespace WFA
{
    partial class ListaFada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLista = new System.Windows.Forms.TabPage();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tabPageCadastroRapido = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttamanhoAsa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbMulher = new System.Windows.Forms.CheckBox();
            this.ckbFazBarulho = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastroRapido = new System.Windows.Forms.Button();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFamilia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCorAsa = new System.Windows.Forms.ComboBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.cbFamilia = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPageLista.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageCadastroRapido.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLista);
            this.tabControl1.Controls.Add(this.tabPageCadastro);
            this.tabControl1.Controls.Add(this.tabPageCadastroRapido);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(130, 25);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 501);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageLista
            // 
            this.tabPageLista.Controls.Add(this.btnEditar);
            this.tabPageLista.Controls.Add(this.btnApagar);
            this.tabPageLista.Controls.Add(this.btnAdicionar);
            this.tabPageLista.Controls.Add(this.dataGridView1);
            this.tabPageLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageLista.Location = new System.Drawing.Point(4, 29);
            this.tabPageLista.Name = "tabPageLista";
            this.tabPageLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLista.Size = new System.Drawing.Size(898, 468);
            this.tabPageLista.TabIndex = 0;
            this.tabPageLista.Text = "Lista Fada";
            this.tabPageLista.UseVisualStyleBackColor = true;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.cbFamilia);
            this.tabPageCadastro.Controls.Add(this.cbCor);
            this.tabPageCadastro.Controls.Add(this.cbCorAsa);
            this.tabPageCadastro.Controls.Add(this.btnCancelar);
            this.tabPageCadastro.Controls.Add(this.btnSalvar);
            this.tabPageCadastro.Controls.Add(this.ckbFazBarulho);
            this.tabPageCadastro.Controls.Add(this.ckbMulher);
            this.tabPageCadastro.Controls.Add(this.txtElemento);
            this.tabPageCadastro.Controls.Add(this.label6);
            this.tabPageCadastro.Controls.Add(this.txttamanhoAsa);
            this.tabPageCadastro.Controls.Add(this.label5);
            this.tabPageCadastro.Controls.Add(this.label4);
            this.tabPageCadastro.Controls.Add(this.label3);
            this.tabPageCadastro.Controls.Add(this.label2);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Controls.Add(this.label1);
            this.tabPageCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 29);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(898, 468);
            this.tabPageCadastro.TabIndex = 1;
            this.tabPageCadastro.Text = "Cadastar Fada";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnFamilia,
            this.ColumnCor});
            this.dataGridView1.Location = new System.Drawing.Point(6, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(885, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(7, 84);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(139, 40);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(297, 84);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(139, 40);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(152, 84);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 40);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // tabPageCadastroRapido
            // 
            this.tabPageCadastroRapido.Controls.Add(this.btnCadastroRapido);
            this.tabPageCadastroRapido.Controls.Add(this.checkBox1);
            this.tabPageCadastroRapido.Controls.Add(this.textBox1);
            this.tabPageCadastroRapido.Controls.Add(this.label7);
            this.tabPageCadastroRapido.Controls.Add(this.textBox2);
            this.tabPageCadastroRapido.Controls.Add(this.label8);
            this.tabPageCadastroRapido.Controls.Add(this.textBox3);
            this.tabPageCadastroRapido.Controls.Add(this.label9);
            this.tabPageCadastroRapido.Location = new System.Drawing.Point(4, 29);
            this.tabPageCadastroRapido.Name = "tabPageCadastroRapido";
            this.tabPageCadastroRapido.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastroRapido.Size = new System.Drawing.Size(898, 468);
            this.tabPageCadastroRapido.TabIndex = 2;
            this.tabPageCadastroRapido.Text = "Cadastro Rápido";
            this.tabPageCadastroRapido.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(19, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(249, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Familia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cor da Asa";
            // 
            // txttamanhoAsa
            // 
            this.txttamanhoAsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttamanhoAsa.Location = new System.Drawing.Point(328, 50);
            this.txttamanhoAsa.Name = "txttamanhoAsa";
            this.txttamanhoAsa.Size = new System.Drawing.Size(249, 22);
            this.txttamanhoAsa.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tamanho da Asa";
            // 
            // txtElemento
            // 
            this.txtElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElemento.Location = new System.Drawing.Point(19, 166);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(249, 22);
            this.txtElemento.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Elemento";
            // 
            // ckbMulher
            // 
            this.ckbMulher.AutoSize = true;
            this.ckbMulher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMulher.Location = new System.Drawing.Point(648, 48);
            this.ckbMulher.Name = "ckbMulher";
            this.ckbMulher.Size = new System.Drawing.Size(82, 24);
            this.ckbMulher.TabIndex = 12;
            this.ckbMulher.Text = "Mulher";
            this.ckbMulher.UseVisualStyleBackColor = true;
            // 
            // ckbFazBarulho
            // 
            this.ckbFazBarulho.AutoSize = true;
            this.ckbFazBarulho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFazBarulho.Location = new System.Drawing.Point(648, 85);
            this.ckbFazBarulho.Name = "ckbFazBarulho";
            this.ckbFazBarulho.Size = new System.Drawing.Size(125, 24);
            this.ckbFazBarulho.TabIndex = 13;
            this.ckbFazBarulho.Text = "Faz Barulho";
            this.ckbFazBarulho.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(580, 357);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(192, 52);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(382, 357);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(192, 52);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(342, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 24);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Mulher";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(37, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 22);
            this.textBox1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cor";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(37, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 22);
            this.textBox2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Familia";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(37, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 22);
            this.textBox3.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nome";
            // 
            // btnCadastroRapido
            // 
            this.btnCadastroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroRapido.Location = new System.Drawing.Point(37, 358);
            this.btnCadastroRapido.Name = "btnCadastroRapido";
            this.btnCadastroRapido.Size = new System.Drawing.Size(274, 52);
            this.btnCadastroRapido.TabIndex = 20;
            this.btnCadastroRapido.Text = "Cadastro Rápido";
            this.btnCadastroRapido.UseVisualStyleBackColor = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 300;
            // 
            // ColumnFamilia
            // 
            this.ColumnFamilia.HeaderText = "Familia";
            this.ColumnFamilia.Name = "ColumnFamilia";
            this.ColumnFamilia.ReadOnly = true;
            this.ColumnFamilia.Width = 300;
            // 
            // ColumnCor
            // 
            this.ColumnCor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCor.HeaderText = "Cor";
            this.ColumnCor.Name = "ColumnCor";
            this.ColumnCor.ReadOnly = true;
            // 
            // cbCorAsa
            // 
            this.cbCorAsa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCorAsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCorAsa.FormattingEnabled = true;
            this.cbCorAsa.Items.AddRange(new object[] {
            "Abóbora",
            "Açafrão",
            "Amarelo",
            "Amarelo-avermelhado",
            "Amarelo-canário",
            "Amarelo-cinzento",
            "Amarelo-claro",
            "Amarelo-enxofre",
            "Amarelo-escuro",
            "Amarelo-esverdeado",
            "Amarelo-fosco",
            "Amarelo-gualdo",
            "Amarelo-limão",
            "Amarelo-ocre",
            "Amarelo-ouro",
            "Amarelo-palha",
            "Amarelo-torrado",
            "Âmbar",
            "Ameixa",
            "Amêndoa",
            "Ametista",
            "Anil",
            "Azul",
            "Azul-ardósia",
            "Azul-celeste",
            "Azul-claro",
            "Azul-cobalto",
            "Azul-escuro",
            "Azul-ferrete",
            "Azul-marinho",
            "Azul-pavão",
            "Azul-petróleo",
            "Azul-piscina",
            "Azul-turquesa",
            "Azul-violeta",
            "Bege",
            "Bordô",
            "Branco",
            "Branco-sujo",
            "Bronze",
            "Cáqui",
            "Caramelo",
            "Carmesim",
            "Carmim",
            "Castanho",
            "Castanho-avermelhado",
            "Castanho-claro",
            "Castanho-escuro",
            "Cereja",
            "Chocolate",
            "Ciano ",
            "Cinza",
            "Cinza-ardósia",
            "Cinza-claro",
            "Cinza-escuro",
            "Cinzento",
            "Cinzento-azulado",
            "Cinzento-pérola",
            "Cobre",
            "Coral",
            "Creme",
            "Damasco",
            "Dourado",
            "Escarlate",
            "Esmeralda",
            "Ferrugem",
            "Fúcsia",
            "Gelo",
            "Grená",
            "Gris",
            "Índigo",
            "Jade",
            "Jambo",
            "Laranja",
            "Laranja-claro",
            "Laranja-escuro",
            "Lavanda",
            "Lilás ",
            "Limão",
            "Loiro",
            "Magenta",
            "Malva",
            "Marfim",
            "Marrom",
            "Marrom-claro",
            "Marrom-escuro",
            "Mostarda",
            "Negro",
            "Ocre",
            "Oliva",
            "Ouro",
            "Pêssego",
            "Prata",
            "Preto",
            "Púrpura",
            "Rosa",
            "Rosa-bebê",
            "Rosa-choque",
            "Rosa-claro",
            "Rosa-escuro",
            "Roxo",
            "Rubro",
            "Salmão",
            "Sépia",
            "Terracota",
            "Tijolo",
            "Turquesa",
            "Uva",
            "Verde",
            "Verde-abacate",
            "Verde-água",
            "Verde-alface",
            "Verde-amarelo",
            "Verde-azul",
            "Verde-bandeira",
            "Verde-bronze",
            "Verde-cinza",
            "Verde-claro",
            "Verde-escuro",
            "Verde-esmeralda",
            "Verde-garrafa",
            "Verde-mar",
            "Verde-militar",
            "Verde-musgo",
            "Verde-oliva",
            "Vermelho",
            "Vermelho-alaranjado",
            "Vermelho-cereja",
            "Vermelho-púrpura",
            "Vermelho-tostado",
            "Vinho",
            "Violeta"});
            this.cbCorAsa.Location = new System.Drawing.Point(328, 166);
            this.cbCorAsa.Margin = new System.Windows.Forms.Padding(4);
            this.cbCorAsa.Name = "cbCorAsa";
            this.cbCorAsa.Size = new System.Drawing.Size(249, 24);
            this.cbCorAsa.TabIndex = 18;
            // 
            // cbCor
            // 
            this.cbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "Abóbora",
            "Açafrão",
            "Amarelo",
            "Amarelo-avermelhado",
            "Amarelo-canário",
            "Amarelo-cinzento",
            "Amarelo-claro",
            "Amarelo-enxofre",
            "Amarelo-escuro",
            "Amarelo-esverdeado",
            "Amarelo-fosco",
            "Amarelo-gualdo",
            "Amarelo-limão",
            "Amarelo-ocre",
            "Amarelo-ouro",
            "Amarelo-palha",
            "Amarelo-torrado",
            "Âmbar",
            "Ameixa",
            "Amêndoa",
            "Ametista",
            "Anil",
            "Azul",
            "Azul-ardósia",
            "Azul-celeste",
            "Azul-claro",
            "Azul-cobalto",
            "Azul-escuro",
            "Azul-ferrete",
            "Azul-marinho",
            "Azul-pavão",
            "Azul-petróleo",
            "Azul-piscina",
            "Azul-turquesa",
            "Azul-violeta",
            "Bege",
            "Bordô",
            "Branco",
            "Branco-sujo",
            "Bronze",
            "Cáqui",
            "Caramelo",
            "Carmesim",
            "Carmim",
            "Castanho",
            "Castanho-avermelhado",
            "Castanho-claro",
            "Castanho-escuro",
            "Cereja",
            "Chocolate",
            "Ciano ",
            "Cinza",
            "Cinza-ardósia",
            "Cinza-claro",
            "Cinza-escuro",
            "Cinzento",
            "Cinzento-azulado",
            "Cinzento-pérola",
            "Cobre",
            "Coral",
            "Creme",
            "Damasco",
            "Dourado",
            "Escarlate",
            "Esmeralda",
            "Ferrugem",
            "Fúcsia",
            "Gelo",
            "Grená",
            "Gris",
            "Índigo",
            "Jade",
            "Jambo",
            "Laranja",
            "Laranja-claro",
            "Laranja-escuro",
            "Lavanda",
            "Lilás ",
            "Limão",
            "Loiro",
            "Magenta",
            "Malva",
            "Marfim",
            "Marrom",
            "Marrom-claro",
            "Marrom-escuro",
            "Mostarda",
            "Negro",
            "Ocre",
            "Oliva",
            "Ouro",
            "Pêssego",
            "Prata",
            "Preto",
            "Púrpura",
            "Rosa",
            "Rosa-bebê",
            "Rosa-choque",
            "Rosa-claro",
            "Rosa-escuro",
            "Roxo",
            "Rubro",
            "Salmão",
            "Sépia",
            "Terracota",
            "Tijolo",
            "Turquesa",
            "Uva",
            "Verde",
            "Verde-abacate",
            "Verde-água",
            "Verde-alface",
            "Verde-amarelo",
            "Verde-azul",
            "Verde-bandeira",
            "Verde-bronze",
            "Verde-cinza",
            "Verde-claro",
            "Verde-escuro",
            "Verde-esmeralda",
            "Verde-garrafa",
            "Verde-mar",
            "Verde-militar",
            "Verde-musgo",
            "Verde-oliva",
            "Vermelho",
            "Vermelho-alaranjado",
            "Vermelho-cereja",
            "Vermelho-púrpura",
            "Vermelho-tostado",
            "Vinho",
            "Violeta"});
            this.cbCor.Location = new System.Drawing.Point(328, 106);
            this.cbCor.Margin = new System.Windows.Forms.Padding(4);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(249, 24);
            this.cbCor.TabIndex = 19;
            // 
            // cbFamilia
            // 
            this.cbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFamilia.FormattingEnabled = true;
            this.cbFamilia.Items.AddRange(new object[] {
            "Elfos",
            "Pixies",
            "Gnomos",
            "Goblins",
            "Ninfas",
            "Duendes",
            "Brownies"});
            this.cbFamilia.Location = new System.Drawing.Point(19, 109);
            this.cbFamilia.Margin = new System.Windows.Forms.Padding(4);
            this.cbFamilia.Name = "cbFamilia";
            this.cbFamilia.Size = new System.Drawing.Size(249, 24);
            this.cbFamilia.TabIndex = 20;
            // 
            // ListaFada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 516);
            this.Controls.Add(this.tabControl1);
            this.Name = "ListaFada";
            this.Text = "Fada";
            this.tabControl1.ResumeLayout(false);
            this.tabPageLista.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageCadastroRapido.ResumeLayout(false);
            this.tabPageCadastroRapido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLista;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageCadastroRapido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttamanhoAsa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbFazBarulho;
        private System.Windows.Forms.CheckBox ckbMulher;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFamilia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCor;
        private System.Windows.Forms.Button btnCadastroRapido;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.ComboBox cbCorAsa;
        private System.Windows.Forms.ComboBox cbFamilia;
    }
}