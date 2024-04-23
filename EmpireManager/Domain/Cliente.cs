namespace EmpireManager.Domain
{
    public class Cliente
    {
        private int id;
        private string name;
        private int cpf_cnpj;
        private string email;
        private int telefone;
        private string endereco;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public string Email { get => email; set => email = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }

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

