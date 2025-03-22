using System.Security.AccessControl;
// alt0233
// K+U
// K+C

string pergunta1 = "Digite o primeiro numero:";
string pergunta2 = "Digite o segundo numero:";


int numero1 = 10;
int numero2 = 20;
Console.WriteLine("Exercicio 1 BASICO\n Soma de dois números");
Console.WriteLine($"A soma do numero {numero1} e {numero2} é igual a {numero2 + numero1}\n");

//Console.WriteLine("Exercicio 2 BASICO\nInsira o valor de 2 numeros");
//Console.WriteLine(pergunta1);
//numero1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(pergunta2);
//numero2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Os numeros inseridos foram {numero1} e {numero2}");

//Console.WriteLine("Exercicio 3 BASICO\n Diferença");
//Console.WriteLine(pergunta1);
//numero1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("pergunta2);
//numero2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"A diferença dos valores equivale a  {numero1 - numero2}");

Console.WriteLine("Exercicio 1 INTERMEDIARIO\n Média de três números");
Console.WriteLine(pergunta1);
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(pergunta2);
numero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A diferença dos valores equivale a  {numero1 - numero2}");

Console.WriteLine("Exercicio 2 INTERMEDIARIO\n Resto da divisão");
Console.WriteLine(pergunta1);
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(pergunta2);
numero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A diferença dos valores equivale a  {numero1 % numero2}");

Console.WriteLine("Exercicio 1 Avançados\n Troca de valores sem variável auxiliar");
Console.WriteLine(pergunta1);
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(pergunta2);
numero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A diferença dos valores equivale a  {numero1 % numero2}");