// TODO: Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

Dictionary<string, string> credenciais = [];

bool sairDoPrograma = false;

while (!sairDoPrograma)
{
    Console.Clear();

    Console.WriteLine("Sistema de login e senha\n");
    Console.WriteLine("1. Efetuar login");
    Console.WriteLine("2. Cadastrar novo usuário");
    Console.WriteLine("3. Sair do programa");

    Console.Write("\nEscolha uma opção: ");
    int opt = int.Parse(Console.ReadLine()!);

    Console.Clear();

    switch (opt)
    {
        case 1:
            if (credenciais.Count == 0)
            {
                Console.WriteLine("Não existe nenhum usuário cadastrado. Favor realizar cadastro no sistema!");
                Console.Write("\nPressione qualquer tecla para continuar");
                Console.ReadKey();
            }
            else
            {

                Console.WriteLine("Insira suas credenciais\n");

                Console.Write("Login: ");
                string login = Console.ReadLine()!;

                if (credenciais.ContainsKey(login))
                {
                    Console.Write("Senha: ");
                    string senha = Console.ReadLine()!;

                    if (credenciais[login] == senha)
                    {
                        Console.WriteLine("Login realizado com sucesso!");
                        Console.Write("\nPressione qualquer tecla para continuar");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("Senha incorreta.");
                        Console.Write("\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Login incorreto.");
                    Console.Write("\nPressione qualquer tecla para continuar");
                    Console.ReadKey();
                }
            }
            break;

        case 2:
            Console.WriteLine("Cadastrando um novo usuário\n");

            Console.Write("Login: ");
            string novoLogin = Console.ReadLine()!;

            Console.Write("Senha: ");
            string novaSenha = Console.ReadLine()!;

            credenciais!.Add(novoLogin, novaSenha);
            Console.WriteLine("Cadastro realizado com sucesso!");
            Console.Write("\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            break;
        case 3:
            Console.WriteLine("Fechando o programa..");
            Console.Write("\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            sairDoPrograma = true;
            break;
        default:
            Console.WriteLine("Opção invalida.");
            break;

    }
}