// Faça um programa que gere uma matriz e faça a soma da suas linhas, colunas e diagonais

int qtdLinhas = 5, qtdColunas = 5;
int[,] matriz = new int[qtdLinhas, qtdColunas];
int operacao;

void GerarValores(int[,] m, int min, int max)
{
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            m[linha, coluna] = new Random().Next(min, max);
        }
    }
}


int MenuOperacoes()
{
    int op;
    do
    {
        Console.WriteLine("\n\nSelecione quais somas fazer:");
        Console.WriteLine("1 - somar linhas");
        Console.WriteLine("2 - somar colunas");
        Console.WriteLine("3 - somar diagonais");
        op = int.Parse(Console.ReadLine());
    } while (op < 1 || op > 3);

    return op;
}

void SomarLinhas(int[,] m)
{
    int soma = 0;
    Console.Write("\nSoma das linhas\n");
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            soma += m[linha, coluna];
        }
        Console.Write($"Linha {linha} = {soma}");
        soma = 0;
    }
}

void SomarColunas(int[,] m)
{
    int soma = 0;
    Console.Write("\nSoma das colunas\n");
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            soma += m[coluna, linha];
        }
        Console.Write($"Coluna {linha} = {soma}");
        soma = 0;
    }
}

void SomarDiagonais(int[,] m)
{
    int soma = 0;

    // Calcula diagonal 1
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        soma += m[linha, linha];
    }

    Console.WriteLine($"\nDiagonal 1 = {soma}");

    // Calcula diagonal 2
    soma = 0;
    for (int coluna = qtdColunas - 1, auxLinha = 0; coluna >= 0; coluna--, auxLinha++)
    {
        soma += m[auxLinha, coluna];
    }

    Console.WriteLine($"Diagonal 2 = {soma}\n");
}

void ImprimirMatriz(int[,] matriz, string titulo)
{
    Console.Write("\n\n" + titulo);
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            Console.Write(matriz[linha, coluna] + " ");
        }
    }
}

void Titulo()
{
    Console.Clear();
    Console.WriteLine("  __  __         _          _                \r\n |  \\/  |       | |        (_)               \r\n | \\  / |  __ _ | |_  _ __  _  ____ ___  ___ \r\n | |\\/| | / _` || __|| '__|| ||_  // _ \\/ __|\r\n | |  | || (_| || |_ | |   | | / /|  __/\\__ \\\r\n |_|  |_| \\__,_| \\__||_|   |_|/___|\\___||___/\r\n                                             ");
}

int menuExit()
{
    int option;
    do
    {
        Console.WriteLine("\nDeseja sair do programa?");
        Console.WriteLine("1 - Sair");
        Console.WriteLine("2 - Continuar");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);

    return option;
}

do
{
    Titulo();

    GerarValores(matriz, 0, 10);

    ImprimirMatriz(matriz, "Matriz gerada");

    operacao = MenuOperacoes();

    switch (operacao)
    {
        case 1:
            SomarLinhas(matriz);
            break;
        case 2:
            SomarColunas(matriz);
            break;
        case 3:
            SomarDiagonais(matriz);
            break;
    }

    
} while (menuExit() == 2);
