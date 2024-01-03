using ExemploFundamentos;

//SWITCH CASE 

Console.WriteLine("Informe uma letra"); 
string letra = Console.ReadLine(); // leitura de dados 

switch(letra){
    case "a":
    case "e":
    case "i": 
    case "o": 
    case "u":
        Console.WriteLine("Vogal");
        break; 
    default:
        Console.WriteLine("Não é vogal");
        break;
}
