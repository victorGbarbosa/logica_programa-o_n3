// ATRIBUICAO DE VALOR A UMA VARIAVEL
nome = "Rubens Correa";
Console.WriteLine(nome);

nome = "Rubão";
Console.WriteLine(nome);

// DECLARAÇÃO + ATRIBUICAO
const string constante = "minha constante";

Console.WriteLine(constante);

int idade = 25;
long inteiroGrande = 0;
float alturafloat = 1.8f;
double altura = 1.8;
char letra = 'A';

int x = 1;
int y = 1;
int z = 2;

double resultado = ((x + y) * z) / 3;
Console.WriteLine(resultado);
Console.WriteLine("Hello, World!");
Console.Write(resultado < 100);

Console.WriteLine("\n-----\n");

string stringnome = "Rubens";
string sobrenome = "Souza";

char LetraA = 'A';
char LetraB = 'B';
Console.WriteLine(resultado);

// ----------------------
// NOVA PARTE DO CÓDIGO
// ----------------------

// Entrada de dados do usuário
Console.WriteLine("\n===== CADASTRO SIMPLES =====");
Console.Write("Digite seu nome: ");
string nomeUsuario = Console.ReadLine(); // Lê o nome digitado

Console.Write("Digite sua idade: ");
int idadeUsuario = int.Parse(Console.ReadLine()); // Lê e converte para inteiro

// Exibe as informações digitadas
Console.WriteLine("\n===== RESULTADO =====");
Console.WriteLine($"Seu nome é {nomeUsuario} e você tem {idadeUsuario} anos.");
Console.WriteLine("Cadastro concluído com sucesso!");
 
 
using System;
 
class Program
{
    static void Main()
    {
        Console.Write("Informe o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Informe o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nResultados:");
        Console.WriteLine("Soma: " + (n1 + n2));
        Console.WriteLine("Subtração: " + (n1 - n2));
        Console.WriteLine("Multiplicação: " + (n1 * n2));
        Console.WriteLine("Divisão: " + ((double)n1 / n2));
    }
}