using System.Globalization;
// Parse é o ato de converter uma string em um outro tipo de dado.
// Os tipos primitivos tem suporte ao Parse.

// Já o Try Parse, tenta fazer a conversão do tipo.

var culture = new CultureInfo("pt-BR");
// O CultureInfo é a cultura global designada, por exemplo, datas no EUA são
// definidas com mes/dia/ano, enquanto no Brasil dia/mes/ano
// Passando a cultura, podemos definir o padão

var valor = int.Parse("123");
var valor2 = bool.Parse("true");
var valor3 = DateTime.Parse("01/01/2022", culture);

// Agora os numeros ja estao convertidos nos tipos respectivos

Console.WriteLine(valor);
Console.WriteLine(valor2);
Console.WriteLine(valor3);

// O TryParse, é uma tentativa de conversão, caso não ded certo, o código não vai 
// dar uma exception. Vale ressaltar que o TryParse retorna um booleano.

var deuCerto = int.TryParse("45689", out var valor4);

Console.WriteLine(deuCerto);
Console.WriteLine(valor4);

// O TryParse vai tentar converter um valor de string dentro da variavel 
// seguinte do parametro, levando em consideração o seu tipo

// Neste caso, se der certo será retornado true e o valor em numero.
// Se der errado, false e o valor padrão da variavel, neste caso, 0

