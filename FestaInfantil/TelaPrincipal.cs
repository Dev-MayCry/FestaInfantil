using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloFesta;
using FestaInfantil.Dominio.ModuloTema;
using FestaInfantil.InfraDados.Arquivo.Compartilhado;
using FestaInfantil.InfraDados.Arquivo.ModuloCliente;
using FestaInfantil.InfraDados.Arquivo.ModuloFesta;
using FestaInfantil.InfraDados.Arquivo.ModuloTema;
using FestaInfantil.ModuloCliente;
using FestaInfantil.ModuloFesta;
using FestaInfantil.ModuloTema;

namespace FestaInfantil
{
    public partial class TelaPrincipal : Form
    {

        private ControladorBase controlador;

        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);
        private IRepositorioCliente repositorioCliente = new RepositorioClienteEmArquivo(contextoDados);
        private IRepositorioTema repositorioTema = new RepositorioArquivoTema(contextoDados);
        private IRepositorioFesta repositorioFesta = new RepositorioFestaEmArquivo(contextoDados);
        private static TelaPrincipal telaPrincipal;
        public TelaPrincipal()
        {
            InitializeComponent();

            telaPrincipal = this;
        }
        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            controlador.Inserir();
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnAdicionarItensTema_Click(object sender, EventArgs e)
        {
            controlador.AdicionarItensTema();
        }
        private void btnExcluirItensTema_Click(object sender, EventArgs e)
        {
            controlador.ExcluirItensTema();
        }

        private void btnFecharAluguel_Click(object sender, EventArgs e)
        {
            controlador.EncerrarAluguel();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);
            ConfigurarTelaPrincipal(controlador);
            AtualizarRodape("Visualizando Clientes");
        }

        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema);
            ConfigurarTelaPrincipal(controlador);
            AtualizarRodape("Visualizando Temas");
        }

        private void festaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorFesta(repositorioFesta, repositorioTema, repositorioCliente);
            ConfigurarTelaPrincipal(controlador);
            AtualizarRodape("Visualizando Festas");
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            labelTipoCadastro.Text = controlador.LabelTipoCadastro;
            toolStrip1.Enabled = true;
            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controlador)
        {
            UserControl listagem = controlador.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnAdicionarItensTema.ToolTipText = controlador.ToolTipAdicionarItensTema;
            btnExcluirItensTema.ToolTipText = controlador.ToolTipExcluirItensTema;
            btnFecharAluguel.ToolTipText = controlador.ToolTipFecharAluguel;

            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnAdicionarItensTema.Enabled = controlador.AdicionarItensTemaHabilitado;
            btnExcluirItensTema.Enabled = controlador.ExcluirItensTemaHabilitado;
            btnFecharAluguel.Enabled = controlador.FecharAluguelHabilitado;
        }

        public void AtualizarRodape(string mensagem)
        {
            lbRodape.Text = mensagem;
        }

        public static TelaPrincipal Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipal();

                return telaPrincipal;
            }
        }
    }
}