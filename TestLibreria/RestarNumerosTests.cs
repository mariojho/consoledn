using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace TestLibreria
{
    public class RestarNumerosTests
    {
        [Fact]
        public void Restar_DosNumerosPositivos_RetornaRestaCorrecta()
        {
            // Arrange
            var restarDosNumeros = new RestarNumeros();
            int numero1 = 10;
            int numero2 = 2;

            // Act
            int resultado = restarDosNumeros.Restar(numero1, numero2);

            // Assert
            Assert.Equal(8, resultado);
        }
        [Fact]
        public void Restar_DosNumerosNegativos()
        {
            // Arrange
            var restarDosNumeros = new RestarNumeros();
            int numero1 = -20;
            int numero2 = -2;

            // Act
            int resultado = restarDosNumeros.Restar(numero1, numero2);

            // Assert 
            Assert.Equal(-18, resultado);
        }

        [Fact]
        public void Restar_DosNumerosPositivoNegativo()
        {
            // Arrange
            var restarDosNumeros = new RestarNumeros();
            int numero1 = 15;
            int numero2 = -2;

            // Act 
            int resultado = restarDosNumeros.Restar(numero1, numero2);

            // Assert 
            Assert.Equal(17, resultado); 
        }

        [Fact]
        public void RestarNumeroyCero()
        {
            // Arrange
            var restarDosNumeros = new RestarNumeros(); 
            int numero1 = 8;
            int numero2 = 0;

            // Act
            int resultado = restarDosNumeros.Restar(numero1, numero2);

            // Assert
            Assert.Equal(8, resultado);
        }
    }
}
