namespace FestaInfantil.Dominio.ModuloCliente
{
    public interface IRepositorioCliente
    {
        void Inserir(Cliente novoCliente);
        void Editar(int id, Cliente cliente);
        void Excluir(Cliente clienteSelecionado);
        Cliente SelecionarPorId(int id);
        List<Cliente> SelecionarTodos();
    }
}
