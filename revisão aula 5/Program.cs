// See https://aka.ms/new-console-template for more information

int n1;
int n2;

//escrevi uma mensagem no console
Console.WriteLine("insira um numero inteiro :");
//li o conteudo de uma linha, quando o usuario apertou a tecla ENTER 
//o console só aceita texto (string)
//logo é preciso converter a string para (int)
n1 = int.Parse(Console.ReadLine());

//escrevi uma mensagem no console
Console.WriteLine("insira mais um numero inteiro: ");
//novamente li o conteudo da linha, quando o usuario apertou a tecla ENTER 
n2 = int.Parse(Console.ReadLine());

//Mostrar os dois numeros no console 

Console.WriteLine("voce digitou " + n1 + " e " + n2);

int soma = n1 + n2;
int sub = n1 - n2;

Console.WriteLine("a soma eh: " + soma);
Console.WriteLine("a subtração eh" + sub);


