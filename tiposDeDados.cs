using System.Data;
using System.Reflection;
using ExemploFundamentos; 

string apresentacao = "Olá, meu nome é Anna"; 
int idade = 19; 
Console.WriteLine("Idade: " + idade);
idade = 20;
double altura = 1.56;
Boolean condicao = true;
decimal preco = 1.80M;
DateTime dataAtual = DateTime.Now.AddDays(5);

Console.WriteLine("Apresentação: " + apresentacao);
Console.WriteLine("Idade: " + idade); 
Console.WriteLine("Altura: " + altura); 
Console.WriteLine("Condição: " + condicao);
Console.WriteLine("Preço: " + preco);
Console.WriteLine("Data Atual: " + dataAtual);