namespace EmpireManager.Domain
{
    public class Pedido
    {
        private int id;
        private DateTime dataPedido;
        private string funcionario;
        private double cliente;
        private string valorTotal;

        public Pedido()
        {
        }

        public int Id { get => id; set => id = value; }
        public DateTime DataPedido { get => dataPedido; set => dataPedido = value; }
        public string Funcionario { get => funcionario; set => funcionario = value; }
        public double Cliente { get => cliente; set => cliente = value; }
        public string ValorTotal { get => valorTotal; set => valorTotal = value; }

        public string ResgistrarVendas()
        {
            return "";
        }
        public string ListarVendas()
        {
            return "";
        }

    }
}
