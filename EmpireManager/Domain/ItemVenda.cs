namespace EmpireManager.Domain
{
    public class ItemVenda
    {
        private int produtoId;
        private int vendaID;
        private int quantidadeProduto;
        private double precoUnitario;

        public ItemVenda()
        {
        }

        public int ProdutoId { get => produtoId; set => produtoId = value; }
        public int VendaID { get => vendaID; set => vendaID = value; }
        public int QuantidadeProduto { get => quantidadeProduto; set => quantidadeProduto = value; }
        public double PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }

        public void InsirirItem()
        {

        }
        public void ExcluirItem()
        {

        }
    }
}
