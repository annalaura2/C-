using System.Linq.Expressions;
using ExemploFundamentos.Models;

// Conversao Segura - mesmo a conversão não dando certo o programa continua
string a = "15-"; 

int b = 0; 

int.TryParse(a, out b); 

Console.WriteLine(b); 
Console.WriteLine("Conversão realizada com sucesso");
