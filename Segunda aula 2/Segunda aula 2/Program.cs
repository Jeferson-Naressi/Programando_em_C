using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
//Console.WriteLine("Exercicio 1. Contagem de 1 a 10");

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("Exercicio 2. Contagem de 1 a 10");
//for (int y = 2; y <= 20; y += 2)
//{
//    Console.WriteLine(y);
//}

//Console.WriteLine("Exercicio 3. Contagem de Números Positivos");
//for (int z = 1; z <= 5; z++)
//{
//    Console.WriteLine("Digite um número");
//    int resultado = Convert.ToInt32(Console.ReadLine());
//    if (resultado >= 1)
//    {
//        Console.WriteLine($"O número {resultado} número é possitivo");

//    }
//    else
//    {
//        Console.WriteLine($"Este número {resultado} não é possitivo ");
//    }

//}

//Console.WriteLine("Exercicio 4. Soma de 1 a N");

//Console.WriteLine("Digite um número");
//int usuario = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i <= usuario; i++)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("Exercicio 5. Média de Notas");
//int valorSamado = 0;
//for (int a = 0; a < 5; a++)
//{
//    Console.WriteLine("Digite um número");
//    int r = Convert.ToInt32(Console.ReadLine());
//    valorSamado = valorSamado + r;
//}
//Console.WriteLine($"A média dos valor é {valorSamado / 5} ");

//Console.WriteLine("Exercicio 6. Contagem Regressiva");

//Console.WriteLine("Digite um número");
//int usuario = Convert.ToInt32(Console.ReadLine());

//for (int i = usuario; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}


//Console.WriteLine("Exercicio 7. Verificação de Número Primo");
//Console.WriteLine("Digite um número");
//int primo = Convert.ToInt32(Console.ReadLine());

//if (primo % primo == 0 && primo / 2 != 0) 
//    Console.WriteLine("Primo");
//else
//    Console.WriteLine("Esté número não é primo");


//int[] numeros = new int[5];
//variavel[lista] = int.Parse(Console.ReadLine()); 

//                           LISTA

//Console.WriteLine("Exercicio 1. Soma dos Elementos");

//int[] lista = new int[5];
//for (int i = 0; i < 5; i++)
//{
//    Console.Write("Digite um número: ");
//    lista[i] = int.Parse(Console.ReadLine());
//}
//int total = 0;
//for (int i = 0; i < 5; i++)
//{
//    total += lista[i];
//}
//Console.WriteLine($"total {total}");

//Console.WriteLine("Exercicio 2. Maior e Menor Valor");

//int[] lista = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    Console.Write("Digite um número: ");
//    lista[i] = int.Parse(Console.ReadLine());
//}
//int ValorMaior = 0;


//for (int i = 0; i < 10; i++)
//{
//    if (lista[i] > ValorMaior)
//    {
//        ValorMaior = lista[i]; 
//    }
//}
//Console.WriteLine($"O valor maior da lista é {ValorMaior}");
//int ValorMenor = ValorMaior;
//for (int i = 0; i < 10; i++)
//{
//    if (lista[i] < ValorMenor)
//    {
//        ValorMenor = lista[i];
//    }
//}
//Console.WriteLine($"O valor menor da lista é {ValorMenor}");

//Console.WriteLine("Exercicio 3. Média dos Valores");

//int[] lista = new int[6];
//for (int i = 0; i < lista.Length; i++)
//{
//    Console.Write("Digite um número: ");
//    lista[i] = int.Parse(Console.ReadLine());
//}
//int soma = 0;

//for (int i = 0; i < lista.Length; i++)

//{
//    soma += lista[i];
//}
//Console.WriteLine($"média dos valores somados são {soma / 6}");

//Console.WriteLine("Exercicio 4. Contagem de Números Pares");
//List<int> lista = new List<int>();

//for (int i = 0; i < 5; i++)
//{
//    Console.Write("Digite um número: ");
//    lista.Add(int.Parse(Console.ReadLine()));
//}
//List<int> Pares = new List<int>();

//for (int i = 0; i < 5; i++)
//{
//    if (lista[i] % 2 == 0)
//    {
//        //int numero = lista[i];
//        Pares.Add(lista[i]);
//    }
//}
//for (int z = 0; z < Pares.Count; z++)
//{
//    Console.WriteLine($"Valores {Pares[z]}");
//}

Console.WriteLine("Exercicio 6. Inversão de Elementos");
List<int> lista = new List<int>();

for (int i = 0; i < 8; i++)
{
    Console.Write("Digite um número: ");
    lista.Add(int.Parse(Console.ReadLine()));
}