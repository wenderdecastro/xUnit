using Xunit;
using XUnitTest;

namespace AtividadesTesteBackEnd
{
    public class UnitTest1
    {
        [Fact]
        public void TestarMetodoAdicionarLivro()
        {
            // Arrange
            var livro = "Harry Potter";

            // Act
            Atividade1.AdicionarLivro(livro);

            // Assert
            Assert.Contains(livro, Atividade1.Livros);
        }

        [Theory] //utilizado para fazer mais de um teste com diferentes dados sem precisasr duplicar o codigo
        [InlineData("julia@senaisp.com", true)] //dados que serao inseridos no teste
        [InlineData("julia.com", false)]
        [InlineData("julia@com", false)]
        [InlineData("julia@senaisp.com.br", true)]
        public void TestarMetodoValidarEmail(string email, bool resultadoEsperado)
        {

            // Act
            var resultado = Atividade2.ValidarEmail(email);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestarMetodoConverterCelsiusParaFahrenheit()
        {
            // Arrange
            var celsius = 28;
            var resultadoEsperado = 82.4;

            // Act
            var resultado = Atividade3.ConverterCelsiusParaFahrenheit(celsius);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData("Monitor Dell", 10, 10)]
        [InlineData("Mouse Dell", 5, 5)]
        [InlineData("Notebook Dell G15", 5, 15)]
        [InlineData("Headset Fallen EcoRBG", 3, 3)]
        public void TestarAdicionarProduto(string nome, int quantidadeAdicionar, int quantidadeEsperada)
        {
            // Arrange
            var controle = new Atividade4.ControleDeInventario();

            if (nome == "Notebook Dell G15" && quantidadeEsperada == 15)
            {
                controle.AdicionarProduto(nome, 10);
            }

            // Act
            controle.AdicionarProduto(nome, quantidadeAdicionar);

            // Assert
            Assert.Equal(quantidadeEsperada, controle.ObterQuantidade(nome));
        }
    }
}