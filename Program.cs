using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Insira o numero da nota");
string numeroDaNota = Console.ReadLine()!;
Console.WriteLine("Informe a descrição do projeto");
string nomeDoProjeto = Console.ReadLine()!;

var projeto = new Projeto(numeroDaNota, nomeDoProjeto);

bool cadastrando = true;
while (cadastrando)
{
    Console.WriteLine("Cadastro de Material");
    Console.Write("Descrição: ");
    string descricao = Console.ReadLine()!;

    Console.Write("Código: ");
    string codigo = Console.ReadLine()!.ToUpper();

    string tipo = "ic";
    string unidade = "un";
    int peso = 0;

    if (codigo.StartsWith("C"))
    {
        tipo = "mp"; 

        if (codigo.StartsWith("C5"))
        {
            unidade = "kg";
        }
    }

    if (unidade == "kg")
    {
        Console.Write("Peso por unidade (kg): ");
        peso = int.Parse(Console.ReadLine()!);
    }

    var material = new Material(descricao, codigo, tipo, unidade, peso);

    var itens = new List<(int comprimento, int quantidade)>();

    if (material.Tipo == "ic")
    {
        Console.Write("Informe a quantidade: ");
        int qtd = int.Parse(Console.ReadLine()!);
        itens.Add((0, qtd));
    }
    else
    {
        while (true)
        {
            Console.Write("Comprimento (0 para sair): ");
            int comp = int.Parse(Console.ReadLine()!);
            if (comp == 0) break;
            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine()!);
            itens.Add((comp, qtd));
        }
    }
    material.CalcularQuantidade(itens);
    projeto.AdicionarMaterial(material);
    Console.Write("\nOriginal cadastrar outro material? (s/n): ");
    cadastrando = Console.ReadLine()?.ToLower() == "s";
}

Console.Clear();
projeto.ExibirListaDeMaterial();