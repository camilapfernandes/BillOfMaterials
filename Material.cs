using System;
using System.Collections.Generic;
using System.Linq;


class Material
{
    public Material(string descricao, string codigo, string tipo, string unidade, int peso)
    {
        Descricao = descricao;
        Codigo = codigo;
        Tipo = tipo;
        Unidade = unidade;
        Peso = peso;
    }
    public string Descricao { get;}
    public string Codigo { get;}
    public string Tipo { get;}
    public string Unidade { get; }
    public int Peso { get; }
    public int Quantidade { get; private set; }

    public void CalcularQuantidade(List<(int comprimento, int quantidade)> itens)
    {
        if (Tipo == "ic")
        {
            Quantidade = itens.Sum(i => i.quantidade);
        } else if (Tipo == "mp")
        {
            Quantidade = CalcularBarras(itens);
        }

        if (Unidade == "kg")
        {
            Quantidade *= Peso;
        }
    }


    private int CalcularBarras(List<(int comprimento, int quantidade)> itens)
    {
        List<int> pedacos = new List<int>();

        foreach (var item in itens)
        {
            for (int i = 0; i < item.quantidade; i++) { 
            pedacos.Add(item.comprimento);

            }
        }
        pedacos = pedacos.OrderByDescending(x => x).ToList();

        int qtdBarras = 0;
        List<int> sobras = new List<int>();

        foreach (var pedaco in pedacos)
        {
            sobras = sobras.OrderByDescending(x => x).ToList();

            if (sobras.Count > 0 && sobras[0] >= pedaco)
            {
                sobras[0] -= pedaco;
            }
            else
            {
                sobras.Add(6000 - pedaco);
                qtdBarras++;
            }
        }

        return qtdBarras;
    }
}
    
