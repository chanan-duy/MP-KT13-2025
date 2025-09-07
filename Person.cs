namespace MP_KT13_2025;

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"person: {Name}";
    }
}
