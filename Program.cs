List<int> pedacos = new List<int>();
while (true)
{
    Console.Write("Digite o comprimento do item ou 0 para finalizar: ");
    int valor;
    if (!int.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("Entrada invalida, digite um numero: ");
        continue;
    }
    if (valor == 0) break;

    Console.Write("Digite a quantidade: ");
    int quantidade;
    if (!int.TryParse(Console.ReadLine(), out quantidade))
    {
        Console.WriteLine("Entrada invalida, digite um número: ");
        continue;
    }
    for (int i = 0; i < quantidade; i++)
    {
        pedacos.Add(valor);
    }
}
pedacos = pedacos.OrderByDescending(x => x).ToList();
Console.WriteLine("Lista final:");
Console.WriteLine("[" + string.Join(", ", pedacos) + "]");

int qtdPedacos = pedacos.Count();
int qtdBarras = 0;
List<int> sobras = new List<int>();

for(int i = 0;i < qtdPedacos; i++)
{
    sobras = sobras.OrderByDescending(x => x).ToList();
    if (sobras.Count > 0 && sobras[0] >= pedacos[i])
    {
        sobras[0] -= pedacos[i];
    } else
    {
        int sobra = 6000 - pedacos[i];
        sobras.Add(sobra);
        qtdBarras++;
    }
}

Console.WriteLine(qtdBarras);   


