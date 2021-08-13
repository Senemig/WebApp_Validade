using System;

namespace WebApp_Validade.Models
{
    public class Produto
    {
        public string descricao { get; set; }
        public DateTime data { get; set; }
        public string dataValidade { get; set; }
        public int quantidade { get; set; }
        public string codigo { get; set; }

        public Produto()
        {
            descricao = "";
            data = DateTime.Today;
            dataValidade = data.ToShortDateString();
            quantidade = 0;
            codigo = "";
        }
    }
}