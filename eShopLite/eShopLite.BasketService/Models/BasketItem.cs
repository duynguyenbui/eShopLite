using System.ComponentModel.DataAnnotations;

namespace eShopLite.GrpcBasket;

public class BasketItem
{
    public string? Id { get; set; }
    public int ProductId { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal OldUnitPrice { get; set; }
    public int Quantity { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext context)
    {
        List<ValidationResult>? results = null;
        if (Quantity < 1)
        {
            results = [new("Invalid number of units", ["Quantity"])];
        }

        return results ?? Enumerable.Empty<ValidationResult>();
    }
}