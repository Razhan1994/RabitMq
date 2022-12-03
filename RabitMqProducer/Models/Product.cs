namespace RabitMqProducer.Models
{
    public class Product
    {
        public Product(string name, string description, string image, int price, int stock)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
            Image = image;
            Price = price;
            Stock = stock;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public int Price { get; set; }

        public int Stock { get; set; }
    }
}
