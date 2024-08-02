using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTest
{
    public static class Atividade1
    {
        public static List<string> Livros { get; set; } = new List<string>();

        public static void AdicionarLivro(string livro)
        {
            Livros.Add(livro);
        }
    }
}
