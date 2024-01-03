using ExemploFundamentos;

//Operadores Lógicos 
// OR => "ou" ||
// AND => "e" &&
// NOT => "não lógico" !

bool choveu = false; 
bool estaTarde = false; 

if(!choveu && !estaTarde){ //o não lógico tornou choveu e o estaTarde verdadeiros
    Console.WriteLine("Vou pedalar");
}else{
    Console.WriteLine("Não vou pedalar");
}
