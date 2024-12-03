
        class Customer
    {
        public string Name { get; }
        private Address Address { get; }

        public Customer(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public bool LivesInUSA()
        {
            return Address.IsInUSA();
        }

        public string GetAddressString()
        {
            return Address.ToString();
        }
    }
