namespace Eymard_s_XML_Editor
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.rbPrincipal = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem3 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.rbTabInicio = new System.Windows.Forms.RibbonTab();
            this.RibPanAbrirXML = new System.Windows.Forms.RibbonPanel();
            this.rbButtonAbrir = new System.Windows.Forms.RibbonButton();
            this.ribPanSalvarXML = new System.Windows.Forms.RibbonPanel();
            this.rbButtonSalvarXML = new System.Windows.Forms.RibbonButton();
            this.ribPanFecharXML = new System.Windows.Forms.RibbonPanel();
            this.rbButtonFechar = new System.Windows.Forms.RibbonButton();
            this.ribPanVisualizarXML = new System.Windows.Forms.RibbonPanel();
            this.rbButtonVisualizar = new System.Windows.Forms.RibbonButton();
            this.rbTabCompararXML = new System.Windows.Forms.RibbonTab();
            this.ribPanCompararXML = new System.Windows.Forms.RibbonPanel();
            this.rbButtonCompararXML = new System.Windows.Forms.RibbonButton();
            this.rbTabSobre = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.pnlGeral = new System.Windows.Forms.Panel();
            this.scContainerTreeView = new System.Windows.Forms.SplitContainer();
            this.tvXMLView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarAlteracao = new System.Windows.Forms.Button();
            this.btnConfirmarEdicao = new System.Windows.Forms.Button();
            this.btnEditarNo = new System.Windows.Forms.Button();
            this.txtValorTreeView = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pnlGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContainerTreeView)).BeginInit();
            this.scContainerTreeView.Panel1.SuspendLayout();
            this.scContainerTreeView.Panel2.SuspendLayout();
            this.scContainerTreeView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rbPrincipal
            // 
            this.rbPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrincipal.Location = new System.Drawing.Point(0, 0);
            this.rbPrincipal.Minimized = false;
            this.rbPrincipal.Name = "rbPrincipal";
            // 
            // 
            // 
            this.rbPrincipal.OrbDropDown.BorderRoundness = 8;
            this.rbPrincipal.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.rbPrincipal.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.rbPrincipal.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem2);
            this.rbPrincipal.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem3);
            this.rbPrincipal.OrbDropDown.MenuItems.Add(this.ribbonSeparator1);
            this.rbPrincipal.OrbDropDown.Name = "";
            this.rbPrincipal.OrbDropDown.Size = new System.Drawing.Size(527, 207);
            this.rbPrincipal.OrbDropDown.TabIndex = 0;
            this.rbPrincipal.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.rbPrincipal.OrbVisible = false;
            // 
            // 
            // 
            this.rbPrincipal.QuickAccessToolbar.Enabled = false;
            this.rbPrincipal.QuickAccessToolbar.Image = global::Eymard_s_XML_Editor.Properties.Resources.LogoXML;
            this.rbPrincipal.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.rbPrincipal.Size = new System.Drawing.Size(1202, 137);
            this.rbPrincipal.TabIndex = 0;
            this.rbPrincipal.Tabs.Add(this.rbTabInicio);
            this.rbPrincipal.Tabs.Add(this.rbTabCompararXML);
            this.rbPrincipal.Tabs.Add(this.rbTabSobre);
            this.rbPrincipal.TabSpacing = 4;
            this.rbPrincipal.Text = "Menu Principal";
            this.rbPrincipal.ThemeColor = System.Windows.Forms.RibbonTheme.Black;
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.LargeImage")));
            this.ribbonOrbMenuItem1.Name = "ribbonOrbMenuItem1";
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "ribbonOrbMenuItem1";
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.LargeImage")));
            this.ribbonOrbMenuItem2.Name = "ribbonOrbMenuItem2";
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Text = "ribbonOrbMenuItem2";
            // 
            // ribbonOrbMenuItem3
            // 
            this.ribbonOrbMenuItem3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.Image")));
            this.ribbonOrbMenuItem3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.LargeImage")));
            this.ribbonOrbMenuItem3.Name = "ribbonOrbMenuItem3";
            this.ribbonOrbMenuItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.SmallImage")));
            this.ribbonOrbMenuItem3.Text = "About The Software...";
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // rbTabInicio
            // 
            this.rbTabInicio.Name = "rbTabInicio";
            this.rbTabInicio.Panels.Add(this.RibPanAbrirXML);
            this.rbTabInicio.Panels.Add(this.ribPanSalvarXML);
            this.rbTabInicio.Panels.Add(this.ribPanFecharXML);
            this.rbTabInicio.Panels.Add(this.ribPanVisualizarXML);
            this.rbTabInicio.Text = "Editor XML";
            this.rbTabInicio.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.rbTabInicio.ToolTipTitle = "Início";
            // 
            // RibPanAbrirXML
            // 
            this.RibPanAbrirXML.Image = global::Eymard_s_XML_Editor.Properties.Resources.abrir_32x32;
            this.RibPanAbrirXML.Items.Add(this.rbButtonAbrir);
            this.RibPanAbrirXML.Name = "RibPanAbrirXML";
            this.RibPanAbrirXML.Text = "Editar/Abrir arquivo XML...";
            this.RibPanAbrirXML.Click += new System.EventHandler(this.rbButtonAbrir_Click);
            // 
            // rbButtonAbrir
            // 
            this.rbButtonAbrir.AltKey = "";
            this.rbButtonAbrir.Image = global::Eymard_s_XML_Editor.Properties.Resources.abrir_32x32;
            this.rbButtonAbrir.LargeImage = global::Eymard_s_XML_Editor.Properties.Resources.abrir_32x32;
            this.rbButtonAbrir.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.rbButtonAbrir.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Overflow;
            this.rbButtonAbrir.Name = "rbButtonAbrir";
            this.rbButtonAbrir.SmallImage = global::Eymard_s_XML_Editor.Properties.Resources.abrir_32x32;
            this.rbButtonAbrir.Text = "";
            this.rbButtonAbrir.ToolTip = "Clique aqui para abrir e editar um arquivo XML diretamente no editor.";
            this.rbButtonAbrir.ToolTipImage = global::Eymard_s_XML_Editor.Properties.Resources.abrir_32x32;
            this.rbButtonAbrir.ToolTipTitle = "Abrir XML";
            this.rbButtonAbrir.DoubleClick += new System.EventHandler(this.rbButtonAbrir_Click);
            // 
            // ribPanSalvarXML
            // 
            this.ribPanSalvarXML.Image = ((System.Drawing.Image)(resources.GetObject("ribPanSalvarXML.Image")));
            this.ribPanSalvarXML.Items.Add(this.rbButtonSalvarXML);
            this.ribPanSalvarXML.Name = "ribPanSalvarXML";
            this.ribPanSalvarXML.Text = "Salvar Arquivo XML...";
            // 
            // rbButtonSalvarXML
            // 
            this.rbButtonSalvarXML.FlashImage = global::Eymard_s_XML_Editor.Properties.Resources.salvar_32x32;
            this.rbButtonSalvarXML.Image = ((System.Drawing.Image)(resources.GetObject("rbButtonSalvarXML.Image")));
            this.rbButtonSalvarXML.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbButtonSalvarXML.LargeImage")));
            this.rbButtonSalvarXML.Name = "rbButtonSalvarXML";
            this.rbButtonSalvarXML.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbButtonSalvarXML.SmallImage")));
            this.rbButtonSalvarXML.ToolTip = "Clique aqui para salvar o seu arquivo XML editado anteriormente.";
            this.rbButtonSalvarXML.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("rbButtonSalvarXML.ToolTipImage")));
            this.rbButtonSalvarXML.ToolTipTitle = "Salvar XML";
            // 
            // ribPanFecharXML
            // 
            this.ribPanFecharXML.Items.Add(this.rbButtonFechar);
            this.ribPanFecharXML.Name = "ribPanFecharXML";
            this.ribPanFecharXML.Text = "Fechar Arquivo XML...";
            // 
            // rbButtonFechar
            // 
            this.rbButtonFechar.Image = ((System.Drawing.Image)(resources.GetObject("rbButtonFechar.Image")));
            this.rbButtonFechar.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbButtonFechar.LargeImage")));
            this.rbButtonFechar.Name = "rbButtonFechar";
            this.rbButtonFechar.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbButtonFechar.SmallImage")));
            this.rbButtonFechar.Text = "";
            this.rbButtonFechar.ToolTip = "Clique aqui para poder fechar o arquivo XML aberto anteriormente no editor.";
            this.rbButtonFechar.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("rbButtonFechar.ToolTipImage")));
            this.rbButtonFechar.ToolTipTitle = "Fechar XML";
            // 
            // ribPanVisualizarXML
            // 
            this.ribPanVisualizarXML.Items.Add(this.rbButtonVisualizar);
            this.ribPanVisualizarXML.Name = "ribPanVisualizarXML";
            this.ribPanVisualizarXML.Text = "Somente Visualizar XML";
            // 
            // rbButtonVisualizar
            // 
            this.rbButtonVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("rbButtonVisualizar.Image")));
            this.rbButtonVisualizar.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbButtonVisualizar.LargeImage")));
            this.rbButtonVisualizar.Name = "rbButtonVisualizar";
            this.rbButtonVisualizar.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbButtonVisualizar.SmallImage")));
            this.rbButtonVisualizar.Text = "";
            this.rbButtonVisualizar.ToolTip = "Clique aqui para somente visualizar o arquivo XML no editor.";
            this.rbButtonVisualizar.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("rbButtonVisualizar.ToolTipImage")));
            this.rbButtonVisualizar.ToolTipTitle = "Somente Visualizar XML";
            // 
            // rbTabCompararXML
            // 
            this.rbTabCompararXML.Name = "rbTabCompararXML";
            this.rbTabCompararXML.Panels.Add(this.ribPanCompararXML);
            this.rbTabCompararXML.Text = "Comparar XML\'s";
            // 
            // ribPanCompararXML
            // 
            this.ribPanCompararXML.Items.Add(this.rbButtonCompararXML);
            this.ribPanCompararXML.Name = "ribPanCompararXML";
            this.ribPanCompararXML.Text = "Comparar XML com WinMerge";
            // 
            // rbButtonCompararXML
            // 
            this.rbButtonCompararXML.Image = ((System.Drawing.Image)(resources.GetObject("rbButtonCompararXML.Image")));
            this.rbButtonCompararXML.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbButtonCompararXML.LargeImage")));
            this.rbButtonCompararXML.Name = "rbButtonCompararXML";
            this.rbButtonCompararXML.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbButtonCompararXML.SmallImage")));
            this.rbButtonCompararXML.Text = "";
            this.rbButtonCompararXML.ToolTip = "Clique aqui para poder comparar arquivos XMLs com o WinMerge.";
            this.rbButtonCompararXML.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("rbButtonCompararXML.ToolTipImage")));
            // 
            // rbTabSobre
            // 
            this.rbTabSobre.Name = "rbTabSobre";
            this.rbTabSobre.Panels.Add(this.ribbonPanel4);
            this.rbTabSobre.Text = "Informações";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "ribbonPanel4";
            // 
            // pnlGeral
            // 
            this.pnlGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGeral.Controls.Add(this.scContainerTreeView);
            this.pnlGeral.Controls.Add(this.pcbLogo);
            this.pnlGeral.Location = new System.Drawing.Point(0, 137);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Size = new System.Drawing.Size(1202, 587);
            this.pnlGeral.TabIndex = 1;
            // 
            // scContainerTreeView
            // 
            this.scContainerTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scContainerTreeView.Location = new System.Drawing.Point(3, 3);
            this.scContainerTreeView.Name = "scContainerTreeView";
            // 
            // scContainerTreeView.Panel1
            // 
            this.scContainerTreeView.Panel1.Controls.Add(this.tvXMLView);
            // 
            // scContainerTreeView.Panel2
            // 
            this.scContainerTreeView.Panel2.Controls.Add(this.panel1);
            this.scContainerTreeView.Size = new System.Drawing.Size(1112, 581);
            this.scContainerTreeView.SplitterDistance = 880;
            this.scContainerTreeView.TabIndex = 4;
            this.scContainerTreeView.TabStop = false;
            // 
            // tvXMLView
            // 
            this.tvXMLView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvXMLView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvXMLView.Location = new System.Drawing.Point(3, 0);
            this.tvXMLView.Name = "tvXMLView";
            this.tvXMLView.Size = new System.Drawing.Size(945, 584);
            this.tvXMLView.TabIndex = 2;
            this.tvXMLView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvXMLView_AfterSelect);
            this.tvXMLView.DoubleClick += new System.EventHandler(this.tvXMLView_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 581);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCancelarAlteracao);
            this.groupBox1.Controls.Add(this.btnConfirmarEdicao);
            this.groupBox1.Controls.Add(this.btnEditarNo);
            this.groupBox1.Controls.Add(this.txtValorTreeView);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 199);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edição de Nó ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nó Selecionado:";
            // 
            // btnCancelarAlteracao
            // 
            this.btnCancelarAlteracao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAlteracao.Location = new System.Drawing.Point(32, 155);
            this.btnCancelarAlteracao.Name = "btnCancelarAlteracao";
            this.btnCancelarAlteracao.Size = new System.Drawing.Size(146, 26);
            this.btnCancelarAlteracao.TabIndex = 4;
            this.btnCancelarAlteracao.TabStop = false;
            this.btnCancelarAlteracao.Text = "Cancelar";
            this.btnCancelarAlteracao.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarEdicao
            // 
            this.btnConfirmarEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarEdicao.Location = new System.Drawing.Point(32, 123);
            this.btnConfirmarEdicao.Name = "btnConfirmarEdicao";
            this.btnConfirmarEdicao.Size = new System.Drawing.Size(146, 26);
            this.btnConfirmarEdicao.TabIndex = 4;
            this.btnConfirmarEdicao.TabStop = false;
            this.btnConfirmarEdicao.Text = "Confirmar alteração";
            this.btnConfirmarEdicao.UseVisualStyleBackColor = true;
            // 
            // btnEditarNo
            // 
            this.btnEditarNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarNo.Location = new System.Drawing.Point(32, 91);
            this.btnEditarNo.Name = "btnEditarNo";
            this.btnEditarNo.Size = new System.Drawing.Size(146, 26);
            this.btnEditarNo.TabIndex = 4;
            this.btnEditarNo.TabStop = false;
            this.btnEditarNo.Text = "Editar Nó";
            this.btnEditarNo.UseVisualStyleBackColor = true;
            this.btnEditarNo.Click += new System.EventHandler(this.btnEditarNo_Click);
            // 
            // txtValorTreeView
            // 
            this.txtValorTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTreeView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTreeView.Location = new System.Drawing.Point(32, 47);
            this.txtValorTreeView.Name = "txtValorTreeView";
            this.txtValorTreeView.Size = new System.Drawing.Size(146, 25);
            this.txtValorTreeView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 289);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Painel de Edição";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbLogo.Image = global::Eymard_s_XML_Editor.Properties.Resources.LogoXML;
            this.pcbLogo.Location = new System.Drawing.Point(1121, 506);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(73, 75);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1202, 724);
            this.Controls.Add(this.pnlGeral);
            this.Controls.Add(this.rbPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1156, 648);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eymard\'s XML Editor | Simple and Free Editor";
            this.pnlGeral.ResumeLayout(false);
            this.scContainerTreeView.Panel1.ResumeLayout(false);
            this.scContainerTreeView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContainerTreeView)).EndInit();
            this.scContainerTreeView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon rbPrincipal;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem2;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem3;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonTab rbTabInicio;
        private System.Windows.Forms.RibbonTab rbTabCompararXML;
        private System.Windows.Forms.RibbonPanel RibPanAbrirXML;
        private System.Windows.Forms.RibbonButton rbButtonAbrir;
        private System.Windows.Forms.Panel pnlGeral;
        private System.Windows.Forms.RibbonTab rbTabSobre;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.TreeView tvXMLView;
        private System.Windows.Forms.TextBox txtValorTreeView;
        private System.Windows.Forms.RibbonPanel ribPanFecharXML;
        private System.Windows.Forms.RibbonPanel ribPanVisualizarXML;
        private System.Windows.Forms.RibbonPanel ribPanCompararXML;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.SplitContainer scContainerTreeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelarAlteracao;
        private System.Windows.Forms.Button btnConfirmarEdicao;
        private System.Windows.Forms.Button btnEditarNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RibbonButton rbButtonFechar;
        private System.Windows.Forms.RibbonButton rbButtonVisualizar;
        private System.Windows.Forms.RibbonButton rbButtonCompararXML;
        private System.Windows.Forms.RibbonPanel ribPanSalvarXML;
        private System.Windows.Forms.RibbonButton rbButtonSalvarXML;
    }
}

