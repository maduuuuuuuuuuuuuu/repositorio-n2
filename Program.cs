string senha;
Console.WriteLine("ola! digite a senha");
senha = Console.ReadLine()!;
if(senha == "1234abcd"){
    Console.WriteLine("acesso permitido");
}
else{
    Console.WriteLine("acesso negado");
}