int qt = int.Parse(Console.ReadLine());

// TODO: Crie as outras condições necessárias para a resolução do desafio:
for (int i = 0; i < qt; i++)
{
    string input = Console.ReadLine();    
    string[] v = input.Split(' ');
    
    string a = v[0];
    string b = v[1];

    Console.WriteLine("a: " + a + " size: " + a.Length);
    Console.WriteLine("b: " + b + " size: " + b.Length);


    if (b.Length > a.Length)
        Console.WriteLine("nao encaixa");
    else if (a.EndsWith(b))
        Console.WriteLine("encaixa");
    else
        Console.WriteLine("nao encaixa");
}
