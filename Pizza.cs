namespace la_mia_pizzeria_static
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public float Price { get; set; }

        public Pizza(int id, string name, string imagePath, float price)
        {
            Id = id;
            Name = name;
            ImagePath = imagePath;
            Price = price;
        }
    }
}
