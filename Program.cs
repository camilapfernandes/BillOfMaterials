var material1 = new Material("Tubo 40x40", "C2250", "mp", "kg", 24);

var itensMaterial1 = new List<(int comprimento, int quantidade)>
{
    (2000, 2),
    (1500, 3),
    (1000, 1)
};
var material2 = new Material("perfil U 10pol", "C2251", "mp", "un", 12);

var itensMaterial2 = new List<(int comprimento, int quantidade)>
{
    (2256, 5),
    (1500, 1),
    (1000, 1),
    (6000, 2),
};

material1.CalcularQuantidade(itensMaterial1);
material2.CalcularQuantidade(itensMaterial2);


var Projeto1 = new Projeto("35000001", "Carrinho de Logistica");

Projeto1.AdicionarMaterial(material1);
Projeto1.AdicionarMaterial(material2);
Projeto1.ExibirListaDeMaterial();


//trabalhar as seguintes Melhorias:
// criar Menu para digitar as informações;
// incluir calculo de preço;
// apresentar a lista em formato de tabela;
// calculo de aproveitamento de chapas e de usinagem;
// criar regra para identificar tipo e unidade de medida com base no codigo;
// Extrair informações de uma planilha excel ;
// criar lista generica com base na seleção de tipo de projeto(Ex:carrinho, escada, portão, guardacorpo)...
