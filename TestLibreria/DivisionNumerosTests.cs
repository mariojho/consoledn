using Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibreria
{
    public class DivisionNumerosTests
    {
        [Fact]
        public void Dividir_DosNumerosPositivos()
        {
            // Arrange 
            var dividirNumeros = new DividirNumeros();
            int numero1 = 10;
            int numero2 = 5;

            // Act
            int resultado = dividirNumeros.Dividir(numero1, numero2);

            // Assert
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Dividir_DenominadorEsCero()
        {
            //Arrange
            var divisor = new DividirNumeros();
            int numerador = 10;
            int denominador = 0;

            //Act & Assert
            Assert.Throws<DivideByZeroException>(() => divisor.Dividir(numerador, denominador));
        }
    }
}
