//Estrutura de repetição
// Random numeroAleatorio = new Random();
// int numero = numeroAleatorio.Next(1, 100);
// int contador = 0;
// Console.WriteLine($"Número alvo: {numero}");
// //lopp que incrementa o contador até ele atingir um numero alvo
// while (contador != numero)
// {
//     Console.WriteLine($"Contador: {contador}.");
//     contador++;
// }
// Console.WriteLine($"Contador atingiu o número alvo:{contador}");

//Estruturas de repetição do while
// int numero = 0;

// do
// {
//     Console.WriteLine($"Número:{numero}");
//     numero++;
// }while (numero < 10);


//Estruturas de repetição do for
// for (int i=0; i <= 10; i++)
// {
//     Console.WriteLine($"Valor de i: {i}");
// }

//Estrutura de repetição foreach
// string[] nomes = { "Jp", "Bê", "Bill"};
// foreach (string nome in nomes)
// {
//     Console.WriteLine(nome);
// }

//Exercicio 1.
// int numero = 0;
// for (int i=0; i < 100; i++)
//       if(numero % 3 == 0)
// {
//     Console.WriteLine($"Soma dos números pares é: {i}");
// }
//Exercicio 2.
// int numero = 11;
// do
// {
// Console.WriteLine($"Número:{numero}");
// numero--;
// }while (numero > 0);

//Exercicio 3
// Console.ReadLine();
// string[] vogais = {"A", "E", "I", "O", "U"};
// foreach (string palavras in vogais);

{
int vogal = 0;
char[] caracteres ={'A', 'E', 'I', 'O', 'U'};
Console.WriteLine("Digite um nome completo:");
char[] nome_completo = Console.ReadLine().ToLower().ToCharArray();
for(int conta=0; conta <nome_completo.Length; conta++)
{
    if(caracteres.Contains(nome_completo[conta]))
{
    vogal++;
}
}
Console.WriteLine("Total de {0} letras \"{1}\".", vogal, caracteres[0]);
Console.Read();
Console.ReadKey();
}



 