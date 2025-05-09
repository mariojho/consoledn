using Libreria;

namespace TestLibreria
{
    public class SumarNumerosTests
    {
        [Fact]
        public void Sumar_DosNumerosPositivos_RetornaSumaCorrecta()
        {
            // Arrange
            var sumarNumeros = new SumarNumeros();
            int numero1 = 5;
            int numero2 = 7;

            // Act
            int resultado = sumarNumeros.Sumar(numero1, numero2);

            // Assert
            Assert.Equal(12, resultado);
        }

        [Fact]
        public void Sumar_NumeroPositivoNegativo_RetornaSumaCorrecta()
        {
            // Arrange
            var sumarNumeros = new SumarNumeros();
            int numero1 = 10;
            int numero2 = -3;

            // Act
            int resultado = sumarNumeros.Sumar(numero1, numero2);

            // Assert
            Assert.Equal(7, resultado);
        }
        [Fact]
        public void SumarDosNumerosNegativos_RetornaSumaCorrect()
        {
            // Arrange
            var sumarNumeros = new SumarNumeros();
            int numero1 = -10;
            int numero2 = -3;

            // Act
            int resultado = sumarNumeros.Sumar(numero1, numero2);

            // Assert
            Assert.Equal(-13, resultado);
        }

        [Fact]
        public void SumarNumeroyCero_RetornaElMismoNumero()
        {
            // Arrange
            var sumarNumeros = new SumarNumeros();
            int numero1 = 8;
            int numero2 = 0;

            // Act
            int resultado = sumarNumeros.Sumar(numero1, numero2);

            // Assert
            Assert.Equal(8, resultado);
        }
    }
}
