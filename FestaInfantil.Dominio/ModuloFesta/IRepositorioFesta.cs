namespace FestaInfantil.Dominio.ModuloFesta
{
    public interface IRepositorioFesta
    {
        void Inserir(Festa novaFesta);
        void Editar(int id, Festa festa);
        void Excluir(Festa festaSelecionado);
        Festa SelecionarPorId(int id);
        List<Festa> SelecionarTodos();

        
    }
}
