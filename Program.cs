// EX-1
int indice = 13;
int soma = 0;
int k = 0;

while (k < indice)
{
    k++;
    soma += k;
}

Console.WriteLine(soma);


//EX-2
Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
int numero = Convert.ToInt32(Console.ReadLine());

if (VerificarFibonacci(numero))
{
    Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
}

static bool VerificarFibonacci(int numero)
{
    int anterior = 0;
    int atual = 1;

    if (numero == 0 || numero == 1)
    {
        return true;
    }

    while (atual <= numero)
    {
        int proximo = anterior + atual;
        if (proximo == numero)
        {
            return true;
        }
        anterior = atual;
        atual = proximo;
    }

    return false;
}



// EX-5
Console.WriteLine("Informe uma string para ser invertida:");
string texto = Console.ReadLine();

static string InverterString(string texto)
{

    char[] caracteres = texto.ToCharArray();

    char[] caracteresInvertidos = new char[caracteres.Length];


    for (int i = 0; i < caracteres.Length; i++)
    {
        caracteresInvertidos[i] = caracteres[caracteres.Length - 1 - i];
    }

    string textoInvertido = new(caracteresInvertidos);

    return textoInvertido;
}

Console.WriteLine(InverterString(texto));