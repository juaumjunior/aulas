//tipos numericos:
//int: armazena numeros inteiros com sinal. EX -10,0,42
//uint: armazena numeros inteiros com sinal (positivos) ex 10,0,42
//long: armazena numeros inteiros longos com sinal ex 456784546 (armazena mais casas que o int)

//float: numero com ,
//double: armazena numeros de ponto flutuante de precisao dupla (padrao valores decimais)
//decimal: armazena numero decimal de alta precisao (usado mais em calculo financeiro)

//bool: armazena valores verdadeiros (true) ou falsos (false)

//texto
//char: armazena um unico caractere
//string: armazena sequencia de caracteres

//tipo enumerados:
//os enumerados (enum) permitem definir um conjunto de valores nomeados e atribui-los a uma variavel.
//por exemplo, enum DiasDaSemana {segunda, terça, quarta, quinta, sexta, sabado, domingo}, geralmente
//utilizados em listas com valores semelhantes.

//tipos data e hora
//DateTime: armazena data e hora
//TimeSpan: Armazena uma duracao ou intervalo de tempo

//outros tipos:
//object: pode armazenar qualquer tipo de objeto (classes)
//dynamic: Uma variavel de tipo dinamico que permite a mudança de tipo em tempo de execucao
// object = classe = arquivo    
//classe aluno
//string nome
//int idade
//string endereco

int idad = 0;
decimal orcamento = 0;
bool temDesconto;

try{
Console.WriteLine("Insira sua idade: ");
idad = int.Parse(Console.ReadLine());

Console.WriteLine("Insira seu orçamento: ");
orcamento = decimal.Parse(Console.ReadLine());

if(idad>=18){

if(orcamento>= 30){

if(idad>=18){
    if(idad<=30){

        Console.WriteLine("Voce tem duas opçoes, o plano padrao de R$ 30,00 e o plano premium de R$ 50,00");
        Console.WriteLine("Qual voce deseja? padrao ou premium");
        
        string tipoPlano = "";
        
        tipoPlano = Console.ReadLine();

        if( tipoPlano == "padrao"){
            if(orcamento>=30){
            Console.WriteLine("Voce tera um investimento de R$ 30,00");
            Console.WriteLine("seu orçamento esta dentro do necessario, te roubamos: " + (orcamento - 30));
            }
            else{
                Console.WriteLine("Saldo Insuficiente: ");
            }
        }
        else if (tipoPlano == "premium") {
            if(orcamento>50){
            Console.WriteLine("Voce tera um investimento de R$ 50,00");
            Console.WriteLine("seu orçamento esta dentro do necessario, te roubamos: " + (orcamento - 50));
            }else{
                Console.WriteLine("Saldo Insuficiente:");
            }
            }
    }
    else if (idad>30){
        
        Console.WriteLine("Voce tem duas opçoes, o plano padrao de R$ 70,00 e o plano premium de R$ 100,00");
        Console.WriteLine("Qual voce deseja? padrao ou premium");

        string tipoPlano = "";
        
        tipoPlano = Console.ReadLine();
        
        if( tipoPlano == "padrao"){
            if(orcamento>=70){
                Console.WriteLine("Voce tera um investimento de R$ 70,00");
                        Console.WriteLine("seu orçamento esta dentro do necessario, te roubamos: " + (orcamento - 70));
            }
            else{
                Console.WriteLine("Saldo insuficiente! ");
            }
            
        }
        else if (tipoPlano == "premium") {
            if(orcamento>=100){
            Console.WriteLine("Voce tera um investimento de R$ 100,00");
            Console.WriteLine("seu orçamento esta dentro do necessario, te roubamos: " + (orcamento - 100));
        }
        else{
                Console.WriteLine("Saldo insuficiente! ");
            }
        }
        
        
}

        }

    }
    

else{
    Console.WriteLine("Saldo insuficiente");
}
}
else{
    Console.WriteLine("voce e menor de idade sua ingua, vaza daqui:");
}
}
catch{
    Console.WriteLine("e numero mano, para de ser burro");
}


