Console.WriteLine("Insira o priemrio número");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o priemrio número");
double n2 = Convert.ToDouble(Console.ReadLine());

double sum = n1 + n2;
double sub = n1 - n2;
double mult = n1 * n2;
double div = n1 / n2;

Console.WriteLine("A some de " + n1 + " + " + n2 + " é igual a: " + sum );
Console.WriteLine("A subtração de {0} - {1} é igual a: {2}", n1, n2, sub);
Console.WriteLine($"A multplicação de {n1} por {n2} é igual a {mult}");
Console.WriteLine($"A divisão de {n1} por {n2} é igual a {div}");