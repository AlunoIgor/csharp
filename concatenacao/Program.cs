// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// concatenacao

string nome = "joao";
string saudacao = "ola" + nome + "! Bem vindo.";
Console.WriteLine(saudacao);

// Interpolacao de strings ($)

string nome1 = "joao";
string saudacao1 = $"Ola, {nome}! Bem vindo.";
Console.WriteLine(saudacao);

//Gettype

int numero = 5;
Console.WriteLine(numero.GetType());

// palavra chave typeof

Console.WriteLine(typeof(int));
