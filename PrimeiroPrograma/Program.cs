﻿// See https://aka.ms/new-console-template for more information

#region escrevendo dados no console com e sem quebra de linha
using System.ComponentModel.Design;
using System.Globalization;
using System.Numerics;

Console.WriteLine("Isso é uma string");
Console.Write("Isso é uma string sem quebra de linha");
Console.Write("Isso é uma demo de do texto anterior");
Console.WriteLine();

#endregion

#region escrevendo valor de variaveis no console

double numeroDecimal = 10.9013;
int numeroInteiro = 10;
string nomePessoa = "Lana";
char caractereUnico = 'F';

// ToString converte o valor da variável em string, quando o metodo WriteLine precisa lidar com formatação

// O metodo cultureInfo é passado no ToString justamente por se tratar de formatação
Console.WriteLine(numeroDecimal);
Console.WriteLine(numeroDecimal.ToString("F2"));
Console.WriteLine(numeroDecimal.ToString("F2", CultureInfo.InvariantCulture));

#endregion

#region concatenando elementos

Console.WriteLine("O peso do bebê é: " + numeroDecimal.ToString(CultureInfo.InvariantCulture) + " ou " + numeroDecimal.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Julia tem " + numeroInteiro + " Anos");
Console.WriteLine(nomePessoa + " é do sexo" + caractereUnico + " (Feminino)");


#endregion

#region casting
double a;
int b;

a = 5.0;
b = (int) a; 
Console.WriteLine(b);
#endregion

#region entrada de dados

string frase = Console.ReadLine();
Console.WriteLine(frase);

string x = Console.ReadLine();
Console.WriteLine(x);

string y = Console.ReadLine();
Console.WriteLine(y);

string z = Console.ReadLine();
Console .WriteLine(z);

//armazena entrada em uma variável vetor, podendo guardar o valor da mesma em outras variáveis usando o split. 
string[] vet = Console.ReadLine().Split(' '); 
Console.WriteLine("você digitou: " + vet);

string v1 = vet[0];
string v2 = vet[1];
string v3 = vet[2];

Console.WriteLine(v1);
Console.WriteLine(v2);
Console.WriteLine(v3);
#endregion

#region entrada de dados pt. 2


int n1 = int.Parse(Console.ReadLine());
Console.WriteLine(n1);

char sexo = char.Parse (Console.ReadLine());
Console.WriteLine(sexo);

//caso deseje que exiba o valor com ponto no lugar de virgula, passar o CultreInfo no Console.WriteLine(variavel.ToString(Culture...)); 
double flutuante = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine(flutuante);

string[] vet1 = Console.ReadLine().Split(' ');

string p1 = (vet1[0]);
Console.WriteLine(p1);

char p2 = char.Parse(vet1[1]);
Console.WriteLine(p2);

int p3 = int.Parse(vet1[2]);
Console.WriteLine(p3);

double p4 = double.Parse(vet1[3], CultureInfo.InvariantCulture);
Console.WriteLine(p4.ToString(CultureInfo.InvariantCulture));

#endregion

#region funcoes matematicas basicas

//Raiz quadrada de w, x e y. 
double x1 = 3.0;
double y2 = 4.0;
double z3 = -5.0;


double num1, num2, num3, num4; 

num1 = Math.Sqrt(x1);
num2 = Math.Sqrt(y2);
num3 = Math.Sqrt(25.5);
num4 = -5.0; 

Console.WriteLine("A raiz quadrada de " + x1 + "é igual a: " + num1.ToString("f3"));
Console.WriteLine("A raiz quadada de " + y2  + "é igual a: " + num2.ToString("f3"));
Console.WriteLine("A raiz quadrada de 25.0 é igual a: " + num3.ToString("f3"));

// Potencia de w, x e y


num1 = Math.Pow(x1, x1);
num2 = Math.Pow(y2, x1);
num3 = Math.Pow(num3, x1);

Console.WriteLine("O numero " + x1 + "elevado a" + x1 + "é igual a: " + num1.ToString("f2"));
Console.WriteLine("O numero " + y2 + "elevado a" + x1 + "é igual a: " + num2.ToString("f2"));

// Valor absoluto de um numero

num1 = Math.Abs(x1);
num4 = Math.Abs(num4);

Console.WriteLine("O valor absoluto de" + x1 + "é igual a: " + num1);
Console.WriteLine("O valor absoluto de" + num4 + "é igual a:" + num4);


#endregion

#region estruturas condicionais


//Estrutura condicional simples

int number = 5;

Console.WriteLine("Bom dia!");

if (number < 0)
{
    Console.WriteLine("Boa noite!"); 
}

Console.WriteLine("Boa tarde!");

// Estrutura condicional composta

int horas;

Console.WriteLine("Digite as horas!");
horas = int.Parse(Console.ReadLine());

if (horas < 12)
{
    Console.WriteLine("Bom dia!");
}
else
{
    Console.WriteLine("Boa tarde!");
}


// Encadeamento de estrutura condicional

int horasEntrada;

Console.WriteLine("Digite a hora");
horasEntrada = int.Parse(Console.ReadLine());

if (horasEntrada <= 12)
{
    Console.WriteLine("Bom dia!");
}

else if (horasEntrada <= 18)
{
    Console.WriteLine("Boa tarde!"); 
}
else
{
    Console.WriteLine("Boa noite!");   
}




#endregion