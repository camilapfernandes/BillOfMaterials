using System;
using System.Collections.Generic;
using System.Linq;
class Projeto
{
    private List<Material> materiais = new();

    public Projeto (string numeroDaNota, string nomeDoProjeto)
    {
        NumeroDaNota = numeroDaNota;
        NomeDoProjeto = nomeDoProjeto;
    }

    public string NumeroDaNota { get; }
    public string NomeDoProjeto { get; }

    public void AdicionarMaterial (Material material)
    {
        materiais.Add (material);
    }

    public void ExibirListaDeMaterial()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine($"PROJETO: {NomeDoProjeto}");
        Console.WriteLine($"NOTA: {NumeroDaNota}");
        Console.WriteLine("========================================");
        Console.WriteLine("\n--- ListaDeMaterial ---");
        foreach(Material material in materiais)
        {
            Console.WriteLine($"Código: {material.Codigo}");
            Console.WriteLine($"Descrição: {material.Descricao}");
            Console.WriteLine($"Quantidade: {material.Quantidade}{material.Tipo}");

            Console.WriteLine("-----------------------------------");
        }
    }

    }