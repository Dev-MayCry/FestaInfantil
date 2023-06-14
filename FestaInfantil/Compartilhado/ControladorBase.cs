namespace FestaInfantil.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public virtual string ToolTipFiltrar { get; }

        public virtual string ToolTipAdicionarItensTema { get; }

        public virtual string ToolTipExcluirItensTema { get; }
        public virtual string ToolTipFecharAluguel { get; }

        public abstract string LabelTipoCadastro { get; }


        public virtual bool InserirHabilitado { get { return true; } }
        public virtual bool EditarHabilitado { get { return true; } }
        public virtual bool ExcluirHabilitado { get { return true; } }

        public virtual bool FiltrarHabilitado { get { return false; } }
        public virtual bool AdicionarItensTemaHabilitado { get { return false; } }
        public virtual bool ExcluirItensTemaHabilitado { get { return false; } }
        public virtual bool FecharAluguelHabilitado{ get { return false; } }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public virtual void Filtrar()
        {
        }

        public virtual void AdicionarItensTema()
        {
        }

        public virtual void ExcluirItensTema()
        {
        }

        public virtual void FecharAluguel()
        {
        }

        public abstract UserControl ObterListagem();
    }
}
