Console.WriteLine("Digite um valor para encontrar seu fatorial");
int valor = int.Parse(Console.ReadLine());
int fatorial = 1;

for (int i = 1; i <= valor; i++)
{
    fatorial = fatorial * i;
}

Console.WriteLine($"O fatorial de {valor} é: {fatorial}");

