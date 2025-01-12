﻿//------------DESAFIO 1-------------//

/*
//Conta os números de 10 a 999000
for (int i = 10; i <= 999000; i++)
{
   var numero = Convert.ToString(i);
   if (VerificaNumeroImpar(numero))
   {
       Console.WriteLine(numero);
   }
}

//Verifica se o resultado é impar e menos que 1 milhão
static bool VerificaNumeroImpar(string numero)
{
   var numero1 = Convert.ToInt32(numero);
   var numero2 = 0;

   var numeroInvertido = StringHelper.ReverseString(numero);

   numero2 = Convert.ToInt32(numeroInvertido);

   if ((numero1 + numero2) % 2 == 1 && (numero1 + numero2) < 1000000)//<- alterar o número aqui
       return true;

   return false;
}

//Inverte o número recebido como parametro
static class StringHelper
{
   public static string ReverseString(string numero)
   {
       char[] array = numero.ToCharArray();
       Array.Reverse(array);
       return new string(array);
   }
}
*/
//------------DESAFIO 2-------------//
/*
using Desafios;

var aula = new Aula();
var alunosNoTempo = 0;

Console.WriteLine("Insira o mínimo de alunos para iniciar uma aula:");
aula.minimoAlunos = (Convert.ToInt32(Console.ReadLine()));

int contador = 1;//conta o número do aluno. Implementação mais estética. Poderia ser desconsiderada.

while (true)
{
    var tempo = "";

    try
    {
        Console.Clear();
        Console.WriteLine($"Insira o tempo de chegada do {contador}o aluno:");
        Console.WriteLine("digite 'stop' para parar o programa");

        //Lê a resposta e tenta converter. Se der erro na conversão cai no catch
        tempo = Console.ReadLine();
        aula.Alunos.Add(new Aluno(Convert.ToInt32(tempo)));
    }
    catch (Exception)
    {
        contador++;
        //Verifica se o usuário quer parar
        if (tempo == "stop")
        {
            break;
        }
        //Tratamento de exceção
        else
        {
            Console.WriteLine("Insira um tempo válido");
            Console.WriteLine("Pressione ENTER para prosseguir");
            Console.ReadKey();
            contador--;
        }
    }
}

//Conta quantos alunos chegaram a tempo
foreach (var aluno in aula.Alunos)
{
    if (aluno.TempoAtraso <= 0)
    {
        alunosNoTempo++;
    }
}

//Verifica se ocorrerá aula ou não.
if (alunosNoTempo < aula.minimoAlunos)
{
    Console.WriteLine("Aula cancelada");
}
else
{
    Console.WriteLine("Aula normal");
}
*/










/*
 * Lógica máxima desenvolvida no desafio 3
 * 
var numeroEstimado = 0;
var vetor = new int[3];
var menorResultado = 0;
var possibilidades = "";

try
{
    Console.WriteLine("Insira o número n desejado");
    numeroEstimado= Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine($"Insira o {i+1}o número");
        vetor[i] = Convert.ToInt32(Console.ReadLine());
    }
}
catch (Exception)
{
    Console.WriteLine("Fvor insira um valor válido");
    Console.WriteLine("Aperte ENTER para continuar");
    Console.ReadKey();
}

menorResultado = 10 / vetor[0];

foreach (var numero in vetor)
{
    if (numeroEstimado / numero < menorResultado)
    {
        menorResultado = numeroEstimado / numero;
        possibilidades = $"{numeroEstimado}/{numero}";
    }
}

Console.WriteLine(possibilidades);
*/