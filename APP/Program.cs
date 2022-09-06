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

// if é se     else é senão, if se for aquilo ele faz não for ele faz outra coisa
/*

&& condição de ter 2 verdadeiros
|| condição de ter um ou outro verdadeiro

Console.WriteLine("Seu oponente jogou pedra, digite 1 para escolher tesoura, 2 para escolher papel, 3 para escolher pedra");
var resultado="0";
while(resultado!="1"&&resultado!="2"&&resultado!="3")
{

resultado=Console.ReadLine();

if(resultado == "1")
{
    Console.WriteLine("Você perdeu");
}

if(resultado == "2")
{
    Console.WriteLine("Você venceu");
}

if(resultado == "3")
{
    Console.WriteLine("Empate");
}

if(resultado != "1") if(resultado != "2") if(resultado != "3")
{
    Console.WriteLine("Opção Inválida");
}
}
*/

var Saudadedecasa= new Música();
Saudadedecasa.NomeDaMúsica= "Saudade de casa.";
Saudadedecasa.Letra= " Volta logo Jesus, vem, me leva pra casa, o céu é o meu lar, o céu é minha morada.";
Saudadedecasa.NomeDoArtista= "Jefferson e Suellen.";
Saudadedecasa.DataDeLançamento= 2020f;
Saudadedecasa.Executar();

var Podemoraraqui= new Música();
Podemoraraqui.NomeDaMúsica= "Pode morar aqui.";
Podemoraraqui.Letra= " Tem fogo nos olhos, eu não imaginava, que era lindo assim, que era lindo assim.";
Podemoraraqui.NomeDoArtista= "Theo Rubia.";
Podemoraraqui.DataDeLançamento= 2019f;
Podemoraraqui.Executar();

var Silêncio= new Música();
Silêncio.NomeDaMúsica= "No silêncio.";
Silêncio.Letra= " No silêncio, está te ensinando, no silêncio, ele está trabalhando, no silêncio, ele vai te moldar, mas é no silêncio, que você vai adorar.";
Silêncio.NomeDoArtista= "Jefferson e Suellen.";
Silêncio.DataDeLançamento= 2021f;
Silêncio.Executar();

public class Música
{
    public string NomeDaMúsica;
    public string Letra;
    public string NomeDoArtista;
    public float DataDeLançamento;
    public void Executar(){
        Console.WriteLine("Tocando: " +NomeDaMúsica +Letra +" Essa música é de autoria de: " +NomeDoArtista +" Publicada no ano: " +DataDeLançamento);
    }
}

/*
var Scott=new Lobisomem();
Scott.Nome= "Scott";
Scott.CorDoPelo= "Marrom";
Scott.TamanhoDaGarra= 5f;
Scott.Atacar();

// objeto é algo construído com as definições da classe
var Derek=new Lobisomem();
Derek.Nome= "Derek";
Derek.CorDoPelo= "Preto";
Derek.TamanhoDaGarra= 10f;
Derek.Atacar();





// classe é um conceito um tipo de coisa
public class Lobisomem
{
// atributo são as características de uma classe
    public string Nome;
    public string CorDoPelo;
    public float TamanhoDaGarra;
    // método é a ação que a classe executa
    public void Atacar(){
        Console.WriteLine(Nome +" se transformou em um lobisomem de cor " +CorDoPelo + " e atacou com suas garras de "+ TamanhoDaGarra + "cm.");
    }
}
*/





