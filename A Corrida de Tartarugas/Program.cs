int quantidadeEntradas = 1;
string tartarugasTest1 = "10 10 10 10 15 18 20 15 11 10";
string tartarugasTest2 = "1 5 2 9 5 5 5 8 4 4 3";
string tartarugasTest3 = "19 9 1 4 5 8 6 11 9 7";
    
while (quantidadeEntradas > 0) 
{
    // var numeroQuantidade = Int32.Parse(Console.ReadLine());
    int numeroQuantidade = 3;
    
    if (numeroQuantidade >= 1 && numeroQuantidade <= 500) 
    {
        string[] tartarugas = tartarugasTest3.Split(" ");
        var maiorVelocidade = Int32.Parse(tartarugas[0]);
        
        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < tartarugas.Length; i++) 
        {
            var tartaruga = Int32.Parse(tartarugas[i]);
            
            if (tartaruga > maiorVelocidade) 
            {
                maiorVelocidade = tartaruga;
            }
        }

        if(maiorVelocidade < 10) 
        {
            Console.WriteLine(1);
        } 
        else if (maiorVelocidade >= 10 && maiorVelocidade< 20) 
        {
            Console.WriteLine(2);
        } 
        else if (maiorVelocidade >= 20) 
        {
            Console.WriteLine(3);
        }
        
        quantidadeEntradas--;
    } 
    else 
    {
        Console.WriteLine("Insira um número entre 1 e 500");
    }
}