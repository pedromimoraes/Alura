namespace terceiroDesafio;
//TODO: Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
class Program
{
    static void Main(string[] args)
    {
        List<string> linguagensDeProgramacao = new() { "C#", "Java", "JavaScript" };

        Console.Write(linguagensDeProgramacao[0]);

    }
}