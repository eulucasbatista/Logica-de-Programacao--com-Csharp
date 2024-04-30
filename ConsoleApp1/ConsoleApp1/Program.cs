﻿var livros =  new List<string>();

while (true)
{
    Console.WriteLine("---- MENU PRINCIPAL ---");
    Console.WriteLine("1 - Cadastrar livro");
    Console.WriteLine("2 - Listar livro");
    Console.WriteLine("3 - Remover livro");
    Console.WriteLine("0 - Sair");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o título do livro.");

            var nomeLivro = Console.ReadLine();

            livros.Add(nomeLivro);

            Console.WriteLine("Livro cadastrado com sucesso.");
            break;
        case "2":
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }
            break;
        case "3":
            Console.WriteLine("Digite o nome do livro.");

            var livroRemover = Console.ReadLine();

            var sucesso = livros.Remove(livroRemover);

            if (sucesso)
            {
                Console.WriteLine("Livro removido");
            }
            else
            {
                Console.WriteLine("Livro não encontrado");
            }
            break;
        case "0":
            Console.WriteLine("Encerrando a aplicação...");
            return;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}