using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTest
{
    public static class Atividade4
    {

        public class Produto
        {
            public string Nome { get; set; }
            public int Quantidade { get; set; }
        }

        public class ControleDeInventario
        {
            public Dictionary<string, Produto> _produtos = new Dictionary<string, Produto>();

            public void AdicionarProduto(string nome, int quantidade)
            {
                if (_produtos.ContainsKey(nome))
                {
                    _produtos[nome].Quantidade += quantidade;
                }
                else
                {
                    _produtos[nome] = new Produto { Nome = nome, Quantidade = quantidade };
                }
            }

            public int ObterQuantidade(string nome)
            {
                if (_produtos.ContainsKey(nome))
                {
                    return _produtos[nome].Quantidade;
                }
                return 0;
            }
        }
    }
}
