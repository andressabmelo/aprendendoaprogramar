bool guri =false; //verdadeiro ou falso

int cacau =8; //números inteiros
float calu =17.9f; //números com vírgula com capacidade de 7 números após a vírgula, e tem que colocar o f
double rei =689.38; //números com vírgula com capacidade de 14 números após a vírgula

char fred = 'a'; //é uma letra
string branca = "gata mimada"; //conjunto de letras sem limite

DateTime beti = DateTime.Now; //variavel de data e hora

// - subtração + adição / divisão * multiplicação
// % módulo é o resto da divisão 
// = atribuição atribuindo falando o que é
// == comparação se são iguais
// != comparação se são diferentes
//var resultado =3+(cacau-5*4)/7f;

Console.WriteLine("por favor digite algo");
var resultado =Console.ReadLine();

Console.WriteLine("por favor digite outra palavra");
var resultado2 =Console.ReadLine();
Console.WriteLine("a soma das palavras que voce digitou foi:");



Console.WriteLine (resultado+resultado2);