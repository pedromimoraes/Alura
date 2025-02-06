//TODO: Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
Dictionary<string, string> perguntasERespostas = new()
{
	{"Qual é a capital do Brasil?", "Brasilia"}, {"Qual é o maior time do mundo?", "Flamengo"}, {"Qual é o pior time do mundo?", "Vasco"}
};

foreach(var  pergunta in perguntasERespostas)
{
	Console.WriteLine(pergunta.Key);
	System.Console.Write("\nResposta: ");

	string resposta = Console.ReadLine()!;

	Console.Clear();

	if(resposta == pergunta.Value)
	{
		System.Console.WriteLine("Resposta correta!");
	}
	else
	{
		System.Console.WriteLine("Resposta errada.");
	}

	System.Console.Write("\nPressione qualquer tecla para continuar! ");
	Console.ReadKey();
	Console.Clear();
}

System.Console.WriteLine("Fim do programa!");
System.Console.Write("\nPressione qualquer tecla para sair");
Console.ReadKey();
Console.Clear();