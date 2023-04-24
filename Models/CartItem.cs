using System.ComponentModel.DataAnnotations;

public class CartItem
{
    public int CartItemId { get; set; }
    [Required]
    public int ProductId { get; set; }
    [Required]
    public int CustomerId { get; set; }
    [Required]
    public int Quantity { get; set; }

    public Customer Customer { get; set; }
    public Product Product { get; set; }
}