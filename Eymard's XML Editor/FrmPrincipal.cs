using Eymard_s_XML_Editor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Eymard_s_XML_Editor
{
    public partial class FrmPrincipal : Form
    {
        //variáveis globais do arquivo xml 
        bool blnEditando = false;

        public FrmPrincipal()
        {
            InitializeComponent();
            ConfiguracoesIniciais();
        }

        private void ConfiguracoesIniciais()
        {
            scContainerTreeView.Visible = false;
            txtValorTreeView.Visible = false;
            tvXMLView.Visible = false;
            pcbLogo.Image = Resources.LogoXML;
            rbButtonFechar.Enabled = false;
            rbButtonSalvarXML.Enabled = false;
        }
        private void rbButtonAbrir_Click(object sender, EventArgs e)
        {
            if(blnEditando)
            {
                DialogResult drAbrirNovamente = MessageBox.Show("Já há um arquivo aberto no editor. Deseja abrir outro arquivo e finalizar a edição do aberto atualmente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(drAbrirNovamente == DialogResult.Yes)
                {
                    ConfiguracoesIniciais();

                    // instanciando o OpenFileDialog
                    OpenFileDialog abrirArquivo = new OpenFileDialog();

                    // configurando o OpenFileDialog pelo objeto AbrirArquivo
                    abrirArquivo.Filter = "Arquivo XML (*.xml)|*.xml";
                    abrirArquivo.FilterIndex = 0;
                    abrirArquivo.DefaultExt = "xml";
                    abrirArquivo.RestoreDirectory = true;

                    if (abrirArquivo.ShowDialog() == DialogResult.OK)
                    {
                        this.RenderizadorXML(abrirArquivo.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("Processo cancelado pelo usuário.", "Ação cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogEditorXML novoLog = new LogEditorXML();
                    novoLog.LogDeProcessodoUsuario("Tentativa de Abertura de Arquivo com Outro Aberto no Editor");
                }
            }
            else
            {
                // instanciando o OpenFileDialog
                OpenFileDialog abrirArquivo = new OpenFileDialog();

                // configurando o OpenFileDialog pelo objeto AbrirArquivo
                abrirArquivo.Filter = "Arquivo XML (*.xml)|*.xml";
                abrirArquivo.FilterIndex = 0;
                abrirArquivo.DefaultExt = "xml";
                abrirArquivo.RestoreDirectory = true;

                if (abrirArquivo.ShowDialog() == DialogResult.OK)
                {
                    this.RenderizadorXML(abrirArquivo.FileName);
                }
            }
        }

        private void RenderizadorXML(string fileName)
        {
            try
            {
                //boas práticas, mostrar ao usuário que tá abrindo o arquivo né, champs?
                this.Cursor = Cursors.WaitCursor;

                //lendo o arquivo, lindinho...
                string xmlString = File.ReadAllText(fileName, Encoding.UTF8);

                //instanciando o XML...
                XmlDocument ArquivoXML = new XmlDocument();

                //realmente lendo..
                ArquivoXML.LoadXml(xmlString);

                //limpando o TreeView, vai saber né?
                tvXMLView.Nodes.Clear();

                //adicioanando nós ao TreeView
                tvXMLView.Nodes.Add(new TreeNode(ArquivoXML.DocumentElement.Name));

                //Criando o TreeNode
                TreeNode tNode = new TreeNode();

                tNode = tvXMLView.Nodes[0];

                this.AdicionarNosXML(ArquivoXML.DocumentElement, tNode);
            }

            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // deu tudo certo? maravilha, agora volta o cursor pro usuário normal.
                this.Cursor = Cursors.Default;
                tvXMLView.Dock = DockStyle.Fill;
                tvXMLView.Visible = true;
                txtValorTreeView.Enabled = false;
                txtValorTreeView.Visible = true;
                btnCancelarAlteracao.Enabled = false;
                btnConfirmarEdicao.Enabled = false;
                scContainerTreeView.Dock = DockStyle.Fill;
                scContainerTreeView.Visible = true;
                rbButtonFechar.Enabled = true;

                //caso abra um arquivo no editor, não posso visualizar, por estar editando.
                rbButtonVisualizar.Enabled = false;

                //alimentando a variável global de edição
                blnEditando = true;
            }
        }

        private void AdicionarNosXML(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int contXmlAux;

            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;

                for (contXmlAux = 0; contXmlAux <= nodeList.Count - 1; contXmlAux++)
                {
                    xNode = inXmlNode.ChildNodes[contXmlAux];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[contXmlAux];
                    this.AdicionarNosXML(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        private void tvXMLView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tvXMLView_DoubleClick(object sender, EventArgs e)
        {
            DialogResult drResultadoEditarNoXMLDoubleClick = MessageBox.Show("Você deseja editar o conteúdo desse nó/cadeia de dados do XML?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (drResultadoEditarNoXMLDoubleClick == DialogResult.Yes)
            {
                string strNoXML = tvXMLView.SelectedNode.Text;

                if(!string.IsNullOrEmpty(strNoXML))
                {

                }
                else
                {
                    MessageBox.Show("Para poder editar o conteúdo do nó/cadeia de dado do XML, é preciso selecionar algum dos itens na árvore do XML.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(drResultadoEditarNoXMLDoubleClick == DialogResult.No || drResultadoEditarNoXMLDoubleClick == DialogResult.Cancel)
            {
                MessageBox.Show("Processo de edição cancelado pelo usuário.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConfirmarEdicao.Enabled = false;
                btnCancelarAlteracao.Enabled = false;
            }
        }

        private void btnEditarNo_Click(object sender, EventArgs e)
        {
            DialogResult drResultadoEditar = MessageBox.Show("Você deseja editar o conteúdo desse nó/cadeia de dados do XML?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            if(drResultadoEditar == DialogResult.Yes)
            {
                try
                {
                    string strEditarNoXML = tvXMLView.SelectedNode.Text;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Para poder editar o conteúdo do nó/cadeia de dado do XML, é preciso selecionar algum dos itens na árvore do XML.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (drResultadoEditar == DialogResult.No || drResultadoEditar == DialogResult.Cancel)
            {
                MessageBox.Show("Processo de edição cancelado pelo usuário.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConfirmarEdicao.Enabled = false;
                btnCancelarAlteracao.Enabled = false;
            }
        }
    }

 }
