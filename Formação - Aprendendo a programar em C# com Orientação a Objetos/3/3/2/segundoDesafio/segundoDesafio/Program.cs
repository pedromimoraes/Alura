//Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.

using segundoDesafio.Modelos;

Programador programador = new()
{
    Nome = "Pedro", Salario = 1000
};

Console.WriteLine(programador.Detalhes);

Gerente gerente = new()
{
    Nome = "Juca", Salario = 6000
};

Console.WriteLine(gerente.Detalhes);

Analista analista = new()
{
    Nome = "Antiosco", Salario = 3500
};

Console.WriteLine(analista.Detalhes);