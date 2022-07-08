//Projeto 1 - Aplicação console - soma de multiplos de 3 e 5

Console.WriteLine("Digite um número.");

//Leitura do numero digitado
int numero = Convert.ToInt32(Console.ReadLine()); 

int soma = 0;

//Verificação de multiplos
for (int i = 0; i <= numero; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        soma += i;
    }
}

//Exibição da soma dos multiplos do numero digitado
Console.WriteLine("Soma dos multiplos de 3 ou 5 para o número " + numero + " é: " + soma);


