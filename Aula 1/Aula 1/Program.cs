using System.Security.AccessControl;
// alt0233
// K+U
// K+C

string nome = "Marcos";
int idade = 20;
char genero = 'M';
float altura = 1.72f;
double pi = 3.14;
bool estudante = true;


//Console.WriteLine($"Nome: {nome}\nIdade: {idade}");

//solicita a idade do usuário
//Console.WriteLine("Qual o seu novo nome?");
//nome = Console.ReadLine();

//Console.WriteLine($"O seu novo nome é {nome}!");

//Console.WriteLine("Qual a sua idade atual? (apenas numeros inteiros)");
//idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A sua idade atualizada é {idade}");

//Console.WriteLine("Qual a sua nova altura?");
//altura = float.Parse(Console.ReadLine());

//Console.WriteLine($"Sua altura é de {altura}");

//Operadores matemáticos

//Console.WriteLine(5 + 5);
//Console.WriteLine(nome + " " + altura);
//Console.WriteLine($"{nome} {altura}");
//Console.WriteLine(pi - altura);
//Console.WriteLine(5 + "5");
//Console.WriteLine(5 * 5);
//Console.WriteLine(10 / 5);
//Console.WriteLine(11 / 3);
//Console.WriteLine(Convert.ToDouble(11) / (double)3);

//int valorPadrao = 21;

////Console.WriteLine(20 == idade);
///*Console.WriteLine(valorPadrao >= 20);
//Console.WriteLine(valorPadrao <= 19);
//Console.WriteLine(valorPadrao < 19);
//Console.WriteLine(valorPadrao > 40);
//Console.WriteLine(valorPadrao != 22);*/

//bool estaSol = false;
//bool estaChovendo = false;

//Console.WriteLine(estaSol || estaChovendo);

//Console.WriteLine(5 == 5 && 8 == 8);// true && true = true
//Console.WriteLine(5 == 5 && 8 == 9);// true && false = false
//Console.WriteLine(5 == 6 && 8 == 8);// false && true = false
//Console.WriteLine(5 == 4 && 8 == 9);// false && false = false


//Console.WriteLine(2 == 2 || 3 == 3);//true || true = true
//Console.WriteLine(2 == 2 || 3 == 4);//true || false = true
//Console.WriteLine(5 == 2 || 3 == 3);//false || true = true
//Console.WriteLine(1 == 2 || 3 == 4);//false || false = false


//Console.WriteLine(!(2 == 2 || 3 == 3)); //negação ou não verdade

//idade = 20;
//int valor1 = 20;
//int valor2 = 19;

//Console.WriteLine(!(idade == valor1));

//string usuario = "admin";
//string senha = "1234";

////solicito o usuario
//Console.WriteLine("digite o seu usuario\n>");
//string usuarioInserido = Console.ReadLine();
////solicito a senha
//Console.WriteLine("digite a sua senha\n>");
//string senhaInserida = Console.ReadLine();

////valido usuario e a senha

//if(usuario == usuarioInserido && senha == senhaInserida)
//{
//    Console.WriteLine("Login feito com sucesso!");
//}
//else if(usuario == usuarioInserido && senha != senhaInserida)
//{
//    Console.WriteLine($"senha inválida para o usuário {usuario}");
//}
//else
//{
//    Console.WriteLine("Falha ao efetuar login");
//}

Console.WriteLine("Para qual marcha eu devo trocar?");
char marcha = Convert.ToChar(Console.ReadLine());

if (marcha == '1')
{
    Console.WriteLine("Primeira marcha");
}
else if (marcha == '2')
{
    Console.WriteLine($"segunda marcha");
}
else if (marcha == '3')
{
    Console.WriteLine($"terceira marcha");
}
else
{
    Console.WriteLine("Falha ao efetuar login");
}

switch (marcha)
{
    case '1':
        Console.WriteLine("Primeira marcha");
        break;
    case '2':
        Console.WriteLine("Segunda marcha");
        break;
    default:
        Console.WriteLine("Marcha Inválida");
        break;
}

bool piscaAlertaLigado = marcha == '1';
string motivoPiscaAlerta = marcha == '1' ? "Ligou por conta da marcha" : "Ligou por conta de outro motivo";


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
