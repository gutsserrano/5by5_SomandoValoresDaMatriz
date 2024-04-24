// Faça um programa que gere uma matriz e faça a soma da suas linhas, colunas e diagonais

int qtdLinhas = 5, qtdColunas = 5;
int[,] matriz = new int[qtdLinhas, qtdColunas];
int soma;
int option;

do
{
    Console.Clear();
    soma = 0;

    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            matriz[linha, coluna] = new Random().Next(1, 10);
        }
    }

    Console.Write("Matriz gerada");
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            Console.Write(matriz[linha, coluna] + " ");
        }
    }

    Console.Write("\n\nSoma das linhas\n");
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            soma += matriz[linha, coluna];
        }
        Console.Write($"Linha {linha} = {soma}");
        soma = 0;
    }

    Console.Write("\n\nSoma das colunas\n");
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            soma += matriz[coluna, linha];
        }
        Console.Write($"Coluna {linha} = {soma}");
        soma = 0;
    }

    // Calcula diagonal 1
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        soma += matriz[linha, linha];
    }

    Console.Write("\n\nCalcular as diagonais de cima para baixo");

    Console.WriteLine($"\n\nDiagonal esquerda pra direita = {soma}");

    // Calcula diagonal 2
    soma = 0;
    for (int coluna = qtdColunas - 1, auxLinha = 0; coluna >= 0; coluna--, auxLinha++)
    {
        soma += matriz[auxLinha, coluna];
    }

    Console.WriteLine($"Diagonal direita pra esquerda = {soma}\n");

    do
    {
        Console.WriteLine("\nDeseja sair do programa?");
        Console.WriteLine("1 - Sair");
        Console.WriteLine("2 - Continuar");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);
