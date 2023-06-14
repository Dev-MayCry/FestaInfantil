namespace FestaInfantil.Dominio.ModuloTema {
    [Serializable]
    public class ItemTema:EntidadeBase<ItemTema>  {

        public string nome;
        public decimal valor;

        public ItemTema(string nome, decimal valor) {
            this.nome = nome;
            this.valor = valor;
        }

        public ItemTema() {

        }

        public override string ToString() {
            return nome + " - R$: " + valor;
        }

        public override void AtualizarInformacoes(ItemTema registroAtualizado) {
            
        }

        public override string[] Validar() {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'descrição' é obrigatório");

            if (valor == 0)
                erros.Add("O campo 'valor' deve ser um número maior que zero");

            return erros.ToArray();
        }
    }
}
