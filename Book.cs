namespace MP_KT13_2025;

public class Book
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Book(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} with {Price} price";
    }
}
