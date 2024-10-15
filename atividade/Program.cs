using System.Collections.Concurrent;
using System.Runtime;
using System.Security.Authentication;
Random r = new Random();
string adm = "Administrador";
string adms = "123456";
int i = 0;
bool controle = true;
bool controlex = true;
bool controley = true;
Console.Clear();
List<string> livros = [];
List<int> qtlivros = [];
while (controle)
{
    Console.WriteLine("Logue com seu usuário: ");
    string login = Console.ReadLine();
    if (login == adm)
    {
        Console.WriteLine("Informe a senha");
        string senha = Console.ReadLine().ToLower();
        if (senha == adms)
        {
            Console.WriteLine("Login efetuado com êxito! Você é o administrador.\nQual livro você deseja acrescentar?");
            //loop para adicionar os livros
            while (true)
            {

                i++;
                Console.Write(i + " - ");
                string novolivro = Console.ReadLine();
                //condição para que o loop pare de repetir
                if (novolivro == "sair")
                {
                    Console.WriteLine("Você saiu!");

                    break;
                }
                else
                {
                    //verifica se o valor dentro da variável é inexistente ou espaço em branco
                    if (!string.IsNullOrWhiteSpace(novolivro))
                    {
                        livros.Add(novolivro);
                    }
                    else
                    {
                        Console.WriteLine("informe um nome de livro válido");
                    }
                }
            }
            Console.WriteLine($"Informe a quantidade de unidade do livro, respectivamente");
            for (int c=qtlivros.Count; c <= livros.Count-1;c++)
            {
                while (controlex)
                {
                    Console.Write(livros[c] + " - ");
                    string info = Console.ReadLine().ToLower();
                    if (info == "sair")
                    {
                        Console.WriteLine("teste");
                        controlex = false;
                    }
                    else
                    {
                        if (int.TryParse(info, out int unilivro))
                        {
                            qtlivros.Add(unilivro);
                            Console.WriteLine(unilivro);
                            controlex = false;
                            controley = false;
                        }
                        else
                        {
                            Console.WriteLine("informe um valor válido");
                        }
                    }
                }
                if (controley == false)
                {
                    controlex = true;
                    controley = true;
                }

                if (controlex == false)
                {
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("senha incorreta.");
        }
    }
else
{
    Console.WriteLine("você é usuário\n");
    for (int c=0; c <= livros.Count-1;c++)
    {
        Console.WriteLine(c+" - "+livros[c]+" - "+qtlivros[c]);
    }

}

}
