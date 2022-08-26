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

/*
for é a estrutura que faz repetir, que recebe um contador, depois até onde ele vai e o quanto ele vai subir

var resultado ="";
for(int contador=0; contador<5;contador+=1)
{
    Console.WriteLine("por favor digite a palavra "+(contador+1));
    resultado+=Console.ReadLine();
}
Console.WriteLine("a soma das suas palavras é:");
Console.WriteLine (resultado);
*/

/*
ele repete até mandar parar

var resultado ="";
while(!resultado.Contains("cansei"))
{
    Console.WriteLine("por favor digite uma palavra");
    resultado+=Console.ReadLine();
}
Console.WriteLine("a soma das suas palavras é:");
Console.WriteLine (resultado);
*/

// if é se     else é senão, if se for aquilo ele faz algo senão for ele faz outra coisa
var resultado=Console.ReadLine();
if(resultado == "1")
{
    Console.WriteLine("passarinho");
}

else{
    Console.WriteLine("gatos");
}







