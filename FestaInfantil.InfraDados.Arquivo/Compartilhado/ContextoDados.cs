using System.Text.Json.Serialization;
using System.Text.Json;

using FestaInfantil.Dominio.ModuloTema;
using FestaInfantil.Dominio.ModuloFesta;
using FestaInfantil.Dominio.ModuloCliente;

namespace FestaInfantil.InfraDados.Arquivo.Compartilhado
{
    public class ContextoDados //container
    {
        private const string NOME_ARQUIVO = "Compartilhado\\FestaInfantil.json";

        public List<Tema> temas;

        public List<Festa> festas;
        public List<Cliente> clientes;

        public ContextoDados()
        {
            temas = new List<Tema>();
            festas = new List<Festa>();
            clientes = new List<Cliente>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            string registrosJson = JsonSerializer.Serialize(this, config);

            File.WriteAllText(NOME_ARQUIVO, registrosJson);
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(NOME_ARQUIVO);

                if (registrosJson.Length > 0)
                {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosJson, config);

                    temas = ctx.temas;
                    festas = ctx.festas;

                    clientes = ctx.clientes;
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
