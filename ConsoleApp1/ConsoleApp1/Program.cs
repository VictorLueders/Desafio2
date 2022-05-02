/*Um professor de programação, frustrado com a falta de disciplina de seus alunos, decidi cancelar a aula se menos de x alunos estiverem presentes 
 * quando a aula for iniciada. O tempo de chegada varia entre:

Normal: tempoChegada <= 0
Atraso: tempoChegada > 0
Construa um algoritmo que dado o tempo de chegada de cada aluno e o limite x de alunos presentes, determina se a classe vai ser cancelada ou não ("Aula cancelada” ou “Aula normal”).

Exemplo:

Entrada de dados:
x = 3
tempoChegada = [-2, -1, 0, 1, 2]

Saída de dados:
Aula normal.

Explicação:
Os três primeiros alunos chegaram no horário. Os dois últimos estavam atrasados. O limite é de três alunos, portanto a aula não será cancelada.*/


//-------------------------/


using Desafio2;

var aula = new Aula();
var alunosNoTempo = 0;

Console.WriteLine("Insira o mínimo de alunos para iniciar uma aula:");
aula.minimoAlunos = (Convert.ToInt32(Console.ReadLine()));

while (true)
{
    int contador = 1;

    var tempo = "";

    try
    {
        Console.Clear();
        Console.WriteLine($"Insira o tempo de chegada do {contador}o aluno:");
        Console.WriteLine("digite 'stop' para parar o programa");

        tempo = Console.ReadLine();
        aula.Alunos.Add(new Aluno(Convert.ToInt32(tempo)));
    }
    catch (Exception)
    {
        if (tempo == "stop")
        {
            break;
        }
    }
}

foreach (var aluno in aula.Alunos)
{
    if (aluno.TempoAtraso <= 0)
    {
        alunosNoTempo++;
    }
}

if (alunosNoTempo < aula.minimoAlunos)
{
    Console.WriteLine("Aula cancelada");
}
else
{
    Console.WriteLine("Aula normal");
}