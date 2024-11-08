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
using System.Reflection.Metadata;

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

//operador ternario

// int idade = 18;
// string mensagem = idade >=18 ? "Maior de idade" : "Menor de idade";
// Console.WriteLine(mensagem);

// int idade = 17;
// string mensagem = idade >=18 ? "Entrada Liberada": "Possui autorização do responsável?";
// Console.WriteLine(mensagem);
// if mensagem

// //Exercicio
// bool ehmaiorIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;
// if (ehmaiorIdade || possuiAutorizacaoDoResponsavel)
// {
//      Console.WriteLine("Entrada liberada");
// }
// else
// {
// Console.WriteLine("Entrada não Liberada");
// }

// //Exercicio ternario 
// bool ehmaiorIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// string resultado = ehmaiorIdade || possuiAutorizacaoDoResponsavel ? "Entrada Liberada" : "Entrada Negada";
// Console.WriteLine(resultado);


// Feito por JP
// bool possuiPresencaMinima = false;
// bool possuiMediaIgualOuMaiorQueSete = true;

// if (possuiPresencaMinima && possuiMediaIgualOuMaiorQueSete)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

// //Feito Pelo Professor
// bool possuiPresencaMinima = true;
// double media3 = 7.0;

// if (possuiPresencaMinima && media3 >=7)
// {
//     Console.WriteLine($"Média {media3:F1}: Aprovado");
// }
// else
// {
//     Console.WriteLine($"Média {media3:F1}: Reprovado");
// }

//  bool choveu = true;
//  bool estaTarde = false;
//  if (choveu && ! estaTarde)
//  {
//     Console.WriteLine("Vou pedalar!"); 
//  }
//  else{
//      Console.WriteLine("Irei outro dia"); 
//  }
 