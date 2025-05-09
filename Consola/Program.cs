// See https://aka.ms/new-console-template for more information
using Libreria;

Console.WriteLine("Hello, World!");

SumarNumeros sumarNumeros = new SumarNumeros();

Console.WriteLine("Introduce el primer número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduce el segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

int resultado = sumarNumeros.Sumar(numero1, numero2);

Console.WriteLine($"El resultado es {resultado}");