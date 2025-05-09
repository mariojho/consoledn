using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace TestLibreria
{
    public class MultiplicarNumerosTests
    {
        [Fact]
        public void Multiplicar_DosNumerosPositivos()
        {
            // Arrange 
            var multiplicarNumeros = new MultiplicarNumeros();
            int numero1 = 5;
            int numero2 = 5;

            // Act
            int resultado = multiplicarNumeros.Multiplicar(numero1, numero2);

            // Assert
            Assert.Equal(25, resultado);
        }

        [Fact]
        public void Multiplicar_DosNumerosNegativos()
        {
            // Arrange
            var multiplicarNumeros = new MultiplicarNumeros();
            int numero1 = -10;
            int numero2 = -4;

            // Act
            int resultado = multiplicarNumeros.Multiplicar(numero1, numero2);

            // Assert
            Assert.Equal(40, resultado);
        }

        [Fact]
        public void Multiplicar_DosNumerosPositivoNegativo()
        {
            // Arrange
            var multiplicarNumeros = new MultiplicarNumeros();
            int numero1 = 13;
            int numero2 = -2;

            // Act
            int resultado = multiplicarNumeros.Multiplicar(numero1, numero2);

            // Assert
            Assert.Equal(-26, resultado);
        }

        [Fact]
        public void MultiplicarNumeroPorCero()
        {
            // Arrange 
            var multiplicarNumeros = new MultiplicarNumeros();
            int numero1 = 8;
            int numero2 = 0;

            // Act
            int resultado = multiplicarNumeros.Multiplicar(numero1, numero2);

            // Assert
            Assert.Equal(0, resultado);
        }
    }
}
