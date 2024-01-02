using ExemploFundamentos;

int quantidadeEmEstoque = 3; 
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar compra? {possivelVenda}");

if(possivelVenda){
    Console.WriteLine("Venda realizada");
}else{
    Console.WriteLine("Não temos a quantidade desejada em estoque");
}
