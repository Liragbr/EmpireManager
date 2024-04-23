namespace EmpireManager.Domain
{
    public class Produtos
    {
        private int id;
        private string name;
        private string descricao;
        private int quantidadeEstoque;
        private int unidadeMedida;
        private double precoUnitario;
        private string imgProduto; // Propriedade para armazenar o caminho/URL da imagem

        public Produtos()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int QuantidadeEstoque { get => quantidadeEstoque; set => quantidadeEstoque = value; }
        public int UnidadeMedida { get => unidadeMedida; set => unidadeMedida = value; }
        public double PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }
        public string ImgProduto { get => imgProduto; set => imgProduto = value; }

        public void Adicionar()
        {

        }
        public void Excluir(int idProduto)
        {

        }
        public void Alterar(int idProduto)
        {

        }
        public string PesquisarProdutoPorID(int idProduto)
        {
            return "";
        }
        public string ListarTodos()
        {
            return "";
        }
    }
}