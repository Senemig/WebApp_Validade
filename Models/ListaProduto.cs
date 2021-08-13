using System;
using System.Collections.Generic;

namespace WebApp_Validade.Models
{
    public static class ListaProduto
    {
        private static List<Produto> listaProduto = new List<Produto>();

        public static void AdicionarValidade(Produto produto)
        {
            listaProduto.Add(produto);
        }

        public static List<Produto> ListarValidades()
        {
            listaProduto.Sort((x, y) => DateTime.Compare(x.data, y.data));
            return listaProduto;
        }
    }
}