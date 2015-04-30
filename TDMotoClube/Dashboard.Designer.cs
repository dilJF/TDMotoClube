namespace TDMotoClube
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewDashboard = new System.Windows.Forms.DataGridView();
            this.tBMOTOCLUBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MOTOCLUBESet = new TDMotoClube.MOTOCLUBESet();
            this.groupBoxDashboard = new System.Windows.Forms.GroupBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.labelListaIntegrantes = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.textBoxEnedereco = new System.Windows.Forms.TextBox();
            this.labelEnedereco = new System.Windows.Forms.Label();
            this.checkBoxTrofeu = new System.Windows.Forms.CheckBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxPresidente = new System.Windows.Forms.TextBox();
            this.labelPresidente = new System.Windows.Forms.Label();
            this.textBoxNomeMotoClube = new System.Windows.Forms.TextBox();
            this.labelNomeMotoClube = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tB_MOTO_CLUBETableAdapter = new TDMotoClube.MOTOCLUBESetTableAdapters.TB_MOTO_CLUBETableAdapter();
            this.tBMOTOCLUBEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMOTOCLUBEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MOTOCLUBESet)).BeginInit();
            this.groupBoxDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMOTOCLUBEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelDashboard
            // 
            this.tableLayoutPanelDashboard.ColumnCount = 2;
            this.tableLayoutPanelDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDashboard.Controls.Add(this.dataGridViewDashboard, 0, 1);
            this.tableLayoutPanelDashboard.Controls.Add(this.groupBoxDashboard, 0, 0);
            this.tableLayoutPanelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDashboard.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDashboard.Name = "tableLayoutPanelDashboard";
            this.tableLayoutPanelDashboard.RowCount = 2;
            this.tableLayoutPanelDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDashboard.Size = new System.Drawing.Size(1068, 585);
            this.tableLayoutPanelDashboard.TabIndex = 0;
            // 
            // dataGridViewDashboard
            // 
            this.dataGridViewDashboard.AllowUserToAddRows = false;
            this.dataGridViewDashboard.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDashboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelDashboard.SetColumnSpan(this.dataGridViewDashboard, 2);
            this.dataGridViewDashboard.Location = new System.Drawing.Point(3, 295);
            this.dataGridViewDashboard.Name = "dataGridViewDashboard";
            this.dataGridViewDashboard.ReadOnly = true;
            this.dataGridViewDashboard.Size = new System.Drawing.Size(1062, 287);
            this.dataGridViewDashboard.TabIndex = 0;
            // 
            // tBMOTOCLUBEBindingSource
            // 
            this.tBMOTOCLUBEBindingSource.DataMember = "TB_MOTO_CLUBE";
            this.tBMOTOCLUBEBindingSource.DataSource = this.MOTOCLUBESet;
            // 
            // MOTOCLUBESet
            // 
            this.MOTOCLUBESet.DataSetName = "MOTOCLUBESet";
            this.MOTOCLUBESet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxDashboard
            // 
            this.tableLayoutPanelDashboard.SetColumnSpan(this.groupBoxDashboard, 2);
            this.groupBoxDashboard.Controls.Add(this.buttonLimpar);
            this.groupBoxDashboard.Controls.Add(this.buttonFechar);
            this.groupBoxDashboard.Controls.Add(this.buttonCadastrar);
            this.groupBoxDashboard.Controls.Add(this.buttonPesquisar);
            this.groupBoxDashboard.Controls.Add(this.labelListaIntegrantes);
            this.groupBoxDashboard.Controls.Add(this.dataGridView2);
            this.groupBoxDashboard.Controls.Add(this.labelEstado);
            this.groupBoxDashboard.Controls.Add(this.comboBoxEstado);
            this.groupBoxDashboard.Controls.Add(this.textBoxCidade);
            this.groupBoxDashboard.Controls.Add(this.labelCidade);
            this.groupBoxDashboard.Controls.Add(this.textBoxBairro);
            this.groupBoxDashboard.Controls.Add(this.labelBairro);
            this.groupBoxDashboard.Controls.Add(this.textBoxComplemento);
            this.groupBoxDashboard.Controls.Add(this.labelComplemento);
            this.groupBoxDashboard.Controls.Add(this.textBoxEnedereco);
            this.groupBoxDashboard.Controls.Add(this.labelEnedereco);
            this.groupBoxDashboard.Controls.Add(this.checkBoxTrofeu);
            this.groupBoxDashboard.Controls.Add(this.textBoxEmail);
            this.groupBoxDashboard.Controls.Add(this.labelEmail);
            this.groupBoxDashboard.Controls.Add(this.textBoxTelefone);
            this.groupBoxDashboard.Controls.Add(this.labelTelefone);
            this.groupBoxDashboard.Controls.Add(this.textBoxPresidente);
            this.groupBoxDashboard.Controls.Add(this.labelPresidente);
            this.groupBoxDashboard.Controls.Add(this.textBoxNomeMotoClube);
            this.groupBoxDashboard.Controls.Add(this.labelNomeMotoClube);
            this.groupBoxDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDashboard.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDashboard.Name = "groupBoxDashboard";
            this.groupBoxDashboard.Size = new System.Drawing.Size(1062, 286);
            this.groupBoxDashboard.TabIndex = 1;
            this.groupBoxDashboard.TabStop = false;
            this.groupBoxDashboard.Text = "Pesquisa";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(6, 238);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(125, 42);
            this.buttonLimpar.TabIndex = 13;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Location = new System.Drawing.Point(981, 24);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 26);
            this.buttonFechar.TabIndex = 23;
            this.buttonFechar.Text = "Sair";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonCadastrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCadastrar.Location = new System.Drawing.Point(402, 238);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(125, 42);
            this.buttonCadastrar.TabIndex = 12;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonPesquisar.Location = new System.Drawing.Point(271, 238);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(125, 42);
            this.buttonPesquisar.TabIndex = 11;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            // 
            // labelListaIntegrantes
            // 
            this.labelListaIntegrantes.AutoSize = true;
            this.labelListaIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaIntegrantes.Location = new System.Drawing.Point(532, 26);
            this.labelListaIntegrantes.Name = "labelListaIntegrantes";
            this.labelListaIntegrantes.Size = new System.Drawing.Size(171, 20);
            this.labelListaIntegrantes.TabIndex = 20;
            this.labelListaIntegrantes.Text = "Lista de Integrantes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(533, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(523, 227);
            this.dataGridView2.TabIndex = 0;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(306, 178);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(66, 20);
            this.labelEstado.TabIndex = 0;
            this.labelEstado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA) ",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.comboBoxEstado.Location = new System.Drawing.Point(378, 175);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(148, 28);
            this.comboBoxEstado.TabIndex = 9;
            this.comboBoxEstado.Text = "Selecione";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidade.Location = new System.Drawing.Point(80, 175);
            this.textBoxCidade.MaxLength = 50;
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(220, 26);
            this.textBoxCidade.TabIndex = 8;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(9, 178);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(65, 20);
            this.labelCidade.TabIndex = 0;
            this.labelCidade.Text = "Cidade";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBairro.Location = new System.Drawing.Point(320, 143);
            this.textBoxBairro.MaxLength = 50;
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(206, 26);
            this.textBoxBairro.TabIndex = 7;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.Location = new System.Drawing.Point(261, 146);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(57, 20);
            this.labelBairro.TabIndex = 0;
            this.labelBairro.Text = "Bairro";
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComplemento.Location = new System.Drawing.Point(134, 143);
            this.textBoxComplemento.MaxLength = 20;
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(121, 26);
            this.textBoxComplemento.TabIndex = 6;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplemento.Location = new System.Drawing.Point(9, 146);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(119, 20);
            this.labelComplemento.TabIndex = 0;
            this.labelComplemento.Text = "Complemento";
            // 
            // textBoxEnedereco
            // 
            this.textBoxEnedereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxEnedereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnedereco.Location = new System.Drawing.Point(94, 114);
            this.textBoxEnedereco.MaxLength = 50;
            this.textBoxEnedereco.Name = "textBoxEnedereco";
            this.textBoxEnedereco.Size = new System.Drawing.Size(432, 26);
            this.textBoxEnedereco.TabIndex = 5;
            // 
            // labelEnedereco
            // 
            this.labelEnedereco.AutoSize = true;
            this.labelEnedereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnedereco.Location = new System.Drawing.Point(9, 117);
            this.labelEnedereco.Name = "labelEnedereco";
            this.labelEnedereco.Size = new System.Drawing.Size(86, 20);
            this.labelEnedereco.TabIndex = 0;
            this.labelEnedereco.Text = "Endereço";
            // 
            // checkBoxTrofeu
            // 
            this.checkBoxTrofeu.AutoSize = true;
            this.checkBoxTrofeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTrofeu.Location = new System.Drawing.Point(13, 207);
            this.checkBoxTrofeu.Name = "checkBoxTrofeu";
            this.checkBoxTrofeu.Size = new System.Drawing.Size(157, 24);
            this.checkBoxTrofeu.TabIndex = 10;
            this.checkBoxTrofeu.Text = "Recebeu Troféu";
            this.checkBoxTrofeu.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(320, 83);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(206, 26);
            this.textBoxEmail.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(261, 86);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 20);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefone.Location = new System.Drawing.Point(94, 83);
            this.textBoxTelefone.MaxLength = 11;
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(161, 26);
            this.textBoxTelefone.TabIndex = 3;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(9, 86);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(79, 20);
            this.labelTelefone.TabIndex = 0;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxPresidente
            // 
            this.textBoxPresidente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPresidente.Location = new System.Drawing.Point(166, 53);
            this.textBoxPresidente.MaxLength = 50;
            this.textBoxPresidente.Name = "textBoxPresidente";
            this.textBoxPresidente.Size = new System.Drawing.Size(360, 26);
            this.textBoxPresidente.TabIndex = 2;
            // 
            // labelPresidente
            // 
            this.labelPresidente.AutoSize = true;
            this.labelPresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresidente.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPresidente.Location = new System.Drawing.Point(9, 56);
            this.labelPresidente.Name = "labelPresidente";
            this.labelPresidente.Size = new System.Drawing.Size(146, 20);
            this.labelPresidente.TabIndex = 0;
            this.labelPresidente.Text = "Nome Presidente";
            // 
            // textBoxNomeMotoClube
            // 
            this.textBoxNomeMotoClube.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeMotoClube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeMotoClube.Location = new System.Drawing.Point(166, 23);
            this.textBoxNomeMotoClube.MaxLength = 50;
            this.textBoxNomeMotoClube.Name = "textBoxNomeMotoClube";
            this.textBoxNomeMotoClube.Size = new System.Drawing.Size(360, 26);
            this.textBoxNomeMotoClube.TabIndex = 1;
            // 
            // labelNomeMotoClube
            // 
            this.labelNomeMotoClube.AutoSize = true;
            this.labelNomeMotoClube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeMotoClube.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNomeMotoClube.Location = new System.Drawing.Point(9, 26);
            this.labelNomeMotoClube.Name = "labelNomeMotoClube";
            this.labelNomeMotoClube.Size = new System.Drawing.Size(151, 20);
            this.labelNomeMotoClube.TabIndex = 0;
            this.labelNomeMotoClube.Text = "Nome Moto Clube";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tB_MOTO_CLUBETableAdapter
            // 
            this.tB_MOTO_CLUBETableAdapter.ClearBeforeFill = true;
            // 
            // tBMOTOCLUBEBindingSource1
            // 
            this.tBMOTOCLUBEBindingSource1.DataMember = "TB_MOTO_CLUBE";
            this.tBMOTOCLUBEBindingSource1.DataSource = this.MOTOCLUBESet;
            // 
            // Dashboard
            // 
            this.AcceptButton = this.buttonPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 585);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanelDashboard);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TD Moto Clube System";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tableLayoutPanelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMOTOCLUBEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MOTOCLUBESet)).EndInit();
            this.groupBoxDashboard.ResumeLayout(false);
            this.groupBoxDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMOTOCLUBEBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDashboard;
        private System.Windows.Forms.DataGridView dataGridViewDashboard;
        private System.Windows.Forms.GroupBox groupBoxDashboard;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.TextBox textBoxEnedereco;
        private System.Windows.Forms.Label labelEnedereco;
        private System.Windows.Forms.CheckBox checkBoxTrofeu;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxPresidente;
        private System.Windows.Forms.Label labelPresidente;
        private System.Windows.Forms.TextBox textBoxNomeMotoClube;
        private System.Windows.Forms.Label labelNomeMotoClube;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Label labelListaIntegrantes;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Button buttonFechar;
        private MOTOCLUBESet MOTOCLUBESet;
        private System.Windows.Forms.BindingSource tBMOTOCLUBEBindingSource;
        private MOTOCLUBESetTableAdapters.TB_MOTO_CLUBETableAdapter tB_MOTO_CLUBETableAdapter;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.BindingSource tBMOTOCLUBEBindingSource1;
    }
}