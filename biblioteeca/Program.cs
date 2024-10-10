using System.Collections.Concurrent;
using System.Security.Authentication;
Random r = new Random();
string adm = "Administrador";
string adms = "123456";
int i = 0;
bool controle = true;
Console.Clear();
List<string> livros = ["Dom Quixote", "Um Conto de Duas Cidades", "O Senhor dos Anéis", "O Pequeno Príncipe"];
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
                Console.WriteLine($"Informe a quantidade de cada livro, respectivamente");
            while (true)
            {
                //int.TryParse(Console.ReadLine(), out int qntlivro);
                
                 

                while (true)
                {
                    
                     string info = Console.ReadLine().ToLower();
                     if(info == "sair")
                     {
                        Console.WriteLine("teste");
                        break;
                     }
                     else
                     {
                        if (int.TryParse(info, out int qntlivro))
                        {
                            
                            if (qntlivro >= i)
                            {
                                Console.WriteLine("Quantidade não pode ser maior que o número de livros adicionados.");
                                break;
                            }
                            else
                            {
                                break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("informe um valor válido");
                        }
                     }
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
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

    }
    Console.WriteLine("Você deseja fechar o programa?(sim/não)");
    string op = Console.ReadLine().ToLower();
    if (op == "sim")
    {
        break;
    }

}






/*List<string> names = ["<name>", "Ana", "Felipe"];



names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}*/




/*string condicao = Console.ReadLine().ToLower();
                    if(condicao=="sair")
                    {
                        break;
                    }*/
