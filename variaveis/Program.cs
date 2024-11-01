﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// tipos de dados primitivos
// Numeros inteiros
short ano = 2025;
int contador = 10;
long populacaoMundial = 7800000000;

// Numeros de ponto flutuante
float temperatura = 43.6f;
double precoProduto = 199.90;

// Caracter
char inicial = "W";

// Tipos logicos
bool estalogado = true;
bool ativo = false;

// Tipos de dados Nao Primitivos
string saudacao ="Ola Mundo!";

// Arrays
int[] numeros = {1, 2, 3, 4, 5};
string[] nomes = {"Igor", "Mae", "Irmao"};

// Classes
public class Pessoa
{
 public string Nome;
public int idade;
}

//structs
public class Ponto
{
 public int x;
 public int y;

}

// Enums
public enum diaDaSemana
{
    Segunda, terca, Quarta, Quinta, Sexta, Sabado, Domingo
}

// Interfaces
public interface IVeiculo
{
    void Mover ();
}

// Delegates
public void Delegates Processar (int numero);

// Nullable Types
int? idade = null;
