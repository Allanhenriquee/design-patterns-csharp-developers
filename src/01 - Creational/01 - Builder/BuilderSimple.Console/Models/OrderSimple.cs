namespace BuilderSimple.Console.Models;

public class OrderSimple
{
    private OrderSimple() { }

    private List<string> Products { get; set; } = new();
    private string PaymentMethod { get; set; } = string.Empty;
    private decimal Total { get; set; }
    private decimal Discount { get; set; }
    private decimal Tax { get; set; }
    private string ShippingAddress { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Order:\n" +
               $"- Products: {string.Join(", ", Products)}\n" +
               $"- Payment Method: {PaymentMethod}\n" +
               $"- Total: {Total:C}\n" +
               $"- Discount: {Discount:C}\n" +
               $"- Tax: {Tax:C}\n" +
               $"- Shipping Address: {ShippingAddress}\n";
    }
    
    public class OrderSimpleBuilder
    {
        private readonly OrderSimple _orderSimple = new();

        public OrderSimpleBuilder AddProduct(string product, decimal price)
        {
            _orderSimple.Products.Add(product);
            _orderSimple.Total += price;
            return this;
        }

        public OrderSimpleBuilder SetPaymentMethod(string paymentMethod)
        {
            _orderSimple.PaymentMethod = paymentMethod;
            return this;
        }

        public OrderSimpleBuilder ApplyDiscount(decimal discount)
        {
            _orderSimple.Discount = discount;
            _orderSimple.Total -= discount;
            return this;
        }

        public OrderSimpleBuilder CalculateTax(decimal tax)
        {
            _orderSimple.Tax = _orderSimple.Total * tax;
            _orderSimple.Total += _orderSimple.Tax;
            return this;
        }

        public OrderSimpleBuilder SetShippingAddress(string address)
        {
            _orderSimple.ShippingAddress = address;
            return this;
        }

        public OrderSimple Build()
        {
            return _orderSimple;
        }
    }
}