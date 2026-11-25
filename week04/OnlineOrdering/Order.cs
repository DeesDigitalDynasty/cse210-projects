using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Sum of each product's total cost + one-time shipping.
    public decimal GetTotalPrice()
    {
        decimal total = 0m;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        decimal shipping = _customer.IsInUSA() ? 5m : 35m;
        return total + shipping;
    }

    // Packing label: name and product id of each product.
    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("PACKING LABEL");
        sb.AppendLine("-------------");
        foreach (Product product in _products)
        {
            sb.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }
        return sb.ToString();
    }

    // Shipping label: customer name and full address.
    public string GetShippingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("SHIPPING LABEL");
        sb.AppendLine("--------------");
        sb.AppendLine(_customer.GetName());
        sb.AppendLine(_customer.GetAddress().GetFullAddress());
        return sb.ToString();
    }
}