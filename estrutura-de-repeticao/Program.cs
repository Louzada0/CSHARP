//Estrutura de repetição
random numeroAleatorio = new random();
int numero = numeroAleatorio.Next(1, 100);
int contador = 0;
Console.WriteLine($"Número alvo:`{numero}");
//lopp que incrementa o contador até ele atingir um numero alvo
while (contador != numero)
{
    Console.WriteLine($"Contador:{contador}.");
    contador++;
}
Console.WriteLine($"Contador atingiu o número alvo:{contador}");
