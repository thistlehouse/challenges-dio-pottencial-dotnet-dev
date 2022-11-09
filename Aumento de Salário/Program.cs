    double salario = 0.00; 
    double reajuste = 0.00; 
    double novoSalario = 0.00; 
    double percentual = 0.00; 
  
    salario = Convert.ToDouble(Console.ReadLine()); 

//TODO: Complete os espaços em branco com uma possível solução para o problema:
   
    if(salario < 0 ) { 
      return; 

    } else if (salario <= 400.00 || salario == 0) { 
      percentual = .15; 
      reajuste =  salario * percentual; 
      novoSalario =   salario + reajuste; 


    } else if (salario > 400.00 && salario <= 800.00 ) { 
      percentual =  .12; 
      reajuste =  salario * percentual;         
      novoSalario = salario + reajuste; 

    } else if (salario > 800.00 && salario <= 1200.00) { 
      percentual = .10; 
      reajuste =  salario * percentual; 
      novoSalario = salario + reajuste; 

    } else if (salario > 1200.00 && salario <= 2000.00 ) { 
      percentual =  .07; 
      reajuste =   salario * percentual; 
      novoSalario =  salario + reajuste; 

    } else { 
      percentual = .04; 
      reajuste = salario * percentual; 
      novoSalario = salario + reajuste; 

    } 

    Console.WriteLine("Novo salario: {0:0.00}", novoSalario); 
    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste); 
    Console.WriteLine("Em percentual: {0} %", percentual * 100); 