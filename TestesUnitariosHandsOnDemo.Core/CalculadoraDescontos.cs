
namespace TestesUnitariosHandsOnDemo.Core;

public class CalculadoraDescontos
{
    public decimal CalcularSubtotal(decimal precoUnitario, int quantidade)
    {
        if (precoUnitario < 0)
            throw new ArgumentException("O preço não pode ser negativo.");

        if (quantidade <= 0)
            throw new ArgumentException("A quantidade deve ser superior a zero.");

        return precoUnitario * quantidade;
    }

    public decimal CalcularDesconto(decimal subtotal, decimal percentagem)
    {
        if (subtotal < 0)
            throw new ArgumentException("O subtotal não pode ser negativo.");

        if (percentagem < 0 || percentagem > 100)
            throw new ArgumentException("A percentagem deve estar entre 0 e 100.");

        return subtotal * percentagem / 100;
    }

    public decimal CalcularTotal(decimal subtotal, decimal desconto)
    {
        if (subtotal < 0 || desconto < 0 || desconto > subtotal)
            throw new ArgumentException("Valores inválidos.");

        return subtotal - desconto;
    }
}
