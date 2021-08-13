namespace WebApp_Validade.Models
{
    public class Produto
    {
        public string descrição;
        public string dataValidade;
        public int quantidade;

        public Produto()
        {
            descrição = "";
            dataValidade = "";
            quantidade = 0;
        }
    }
}