using System.Collections.Generic;


    class Order
    {
        private List<Product> Products { get; }
        private Customer Customer { get; }

        public Order(Customer customer)
        {
            Customer = customer;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (var product in Products)
            {
                label += $"- {product.Name} (ID: {product.ProductId})\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{Customer.Name}\n{Customer.GetAddressString()}";
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var product in Products)
            {
                total += product.GetTotalCost();
            }
            total += Customer.LivesInUSA() ? 5 : 35; // Shipping cost
            return total;
        }
    }

