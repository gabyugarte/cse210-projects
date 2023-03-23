using System.Collections.Generic;
public class Order
{
private List<Product> products;
private Customer customer;
public Order(List<Product> products, Customer customer)
{
    this.products = products;
    this.customer = customer;
}

public double CalculateTotalPrice()
{
    double totalPrice = 0;

    foreach (Product product in products)
    {
        totalPrice += product.Price;
    }

    if (customer.IsInUSA())
    {
        totalPrice += 5;
    }
    else
    {
        totalPrice += 35;
    }

    return totalPrice;
}

public string GetPackingLabel()
{
    string label = "";

    foreach (Product product in products)
    {
        label += $"{product.Name}, {product.ProductId}\n";
    }

    return label.TrimEnd('\n');
}

public string GetShippingLabel()
{
    return $"{customer.Name}\n{customer.Address.GetFormattedAddress()}";
}
}