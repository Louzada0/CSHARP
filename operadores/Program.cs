// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// // Operadores Aritmeticos

// double resultado = 12 + 8 + 12 / 3
// Console.WriteLine(resultado);

// double resultado = (12 + 8 + 12) / 3
// Console.WriteLine(resultado);

// double resultado = (2 + 8) * 2 / 4
// Console.WriteLine(resultado);

// //Cast/Casting
// string valorEmTexto = "100";
// Console.WriteLine("Valor da variável String:" + valorEmTexto);
// Console.WriteLine("A variável é do tipo: " + valorEmTexto .GetType());

// int numeroCOnvertido = Convert.ToInt32(valorEmTexto);
// Console.WriteLine (númeroConvertido);
// Console.WriteLine("Após conversão a variável númeroConvertido é do tipo: " + númeroConvertido.
// GetType());

// //ToString

// int numero =123;
// Console.WriteLine(numero.GetType());

// string numeroComoString = numero.ToString();
// Console.WriteLine(numeroComoString.GetType());

//Personalização de Formato

using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Mail;

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);

// string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
// Console.WriteLine(dataFormatada);
// string dataHoraFormatada = dataAtual.ToString("HH:mm:ss");
// Console.WriteLine(dataHoraFormatada);

//Uso em Interpolação de Strings
// double preco = 29.99;
// Console.WriteLine($"O preço é: {preco.ToString("C2")}");

// decimal valor = 1234.56m;
// string valorUS = valor.ToString("C", new System.Globalization.CultureInfo
// ("en-US"));
// Console.WriteLine(valorUS);

// string valorBR = valor.ToString("C" , new System.Globalization.CultureInfo
// ("pt-BR"));
// Console.WriteLine(valorBR);

