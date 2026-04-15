class Product_Car
{

    public string Name { get; set; }
    public string Brand { get; set; }
    public bool Available { get; set; }
    public double Stock { get; set; }
    public double Price =>
        9999;
    public void carDetails()
    {
        Console.WriteLine("Our car details: \n");

    }

    public void carAvailability()
    {
        Console.WriteLine($"{Name} Information:\n");
        Console.WriteLine($"Made by: {Brand}");
        Console.WriteLine($"for only: {Price}");
        if (Available)
        {
            Console.WriteLine($"We still have: {Stock}");
        }
        else
        {
            Console.WriteLine("Out of stock!");
        }
    }
}