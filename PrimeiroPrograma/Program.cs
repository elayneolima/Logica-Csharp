﻿// See https://aka.ms/new-console-template for more information

#region escrevendo dados no console com e sem quebre de linha
using System.Globalization;

Console.WriteLine("Isso é ua string");
Console.Write("Isso é uma string sem quebra de linha");
Console.Write("Isso é uma demo de do texto anterior");
Console.WriteLine();

#endregion

#region escrevendo valor de variaveis no console

double numeroDecimal = 10.9013;
int numeroInteiro = 10;
string nomePessoa = "Lana";
char caractereUnico = 'F';

// ToString converte o valor da variável em sting, quando o metodo WriteLine precisa lidar com formatação

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