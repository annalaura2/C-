using ExemploFundamentos.Models;

//CAST IMPLICÍTO -> a conversão é feita automaticamente
//sem precisar das ferramentas de conversão do C#


int a = 5; 
double b = a; // o double suporta os valores do int
// mas se tivesse que converter de long para int não daria certo, pois o int não suporta alguns valores
//do long

//long a = longMaxValue; 
// int b = Convert.ToInt32(a); => erro

Console.WriteLine("A: " + a);
Console.WriteLine("B: " + b);
