namespace EmpireManager.Domain
{
    public class Funcionario
    {
        private int id;
        private string name;
        private int cpf;
        private string email;
        private string cargo;
        private double salario;
        private DateTime dataAdimissao;

        public Funcionario()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }
        public DateTime DataAdimissao { get => dataAdimissao; set => dataAdimissao = value; }

        public void Adicionar()
        {

        }
        public void Excluir(int idFuncionario)
        {

        }
        public void Alterar(int idFuncionario)
        {

        }
        public string PesquisarPorID(int idFuncionario)
        {
            return "";
        }
        public string ListarTodos()
        {
            return "";
        }
        public string PesquisarPorNome(string nomeFuncionario)
        {
            return "";
        }

    }
}