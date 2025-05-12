Console.Write("Informe um número: ");
int numero = int.Parse(Console.ReadLine());

bool pertence = VerificaFibonacci(numero);

if (pertence)
    Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
else
    Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");

static bool VerificaFibonacci(int numero)
{
    int a = 0;
    int b = 1;

    while (a <= numero)
    {
        if (a == numero)
            return true;

        int temp = a;
        a = b;
        b = temp + b;
    }

    return false;
}