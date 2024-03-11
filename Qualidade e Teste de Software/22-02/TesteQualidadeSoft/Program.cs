
Console.Title = "Teste e Qualidade de Software - Iago Fragnan";

bool num1 = false;
bool num2 = false;

double value_num1 = 0;
double value_num2 = 0;

while (num1 != true)
{
    Console.WriteLine("Digite um numero:");
    Console.Write(">");
    string l1 = Console.ReadLine();
    double n1;
    if (double.TryParse(l1, out n1))
    {
        value_num1 = Convert.ToDouble(l1);
        num1 = true;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Erro! não é um numero");
    }
}

while (num2 != true)
{
    Console.WriteLine("Digite um numero:");
    Console.Write(">");
    string l2 = Console.ReadLine();
    double n2;
    if (double.TryParse(l2, out n2))
    {
        value_num2 = Convert.ToDouble(l2);
        num2 = true;
    }
    else
    {
    Console.Clear();
        Console.WriteLine("Erro! não é um numero");
    }
}

Console.Clear();
Console.WriteLine($"Resultado da soma: {value_num1 + value_num2}");