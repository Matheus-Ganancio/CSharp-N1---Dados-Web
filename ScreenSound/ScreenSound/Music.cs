class Music
{
    public string Name {  get; set; }
    public string Artist { get; set; }
    public int Length { get; set; }
    public bool Disponible {  get; set; }
    public string Type { get; set; }
    public string Description =>
        $"The music {Name} are from {Artist}";



    public void ShowTechinicalsSpecifications()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Length: {Length}");
        if (Disponible)
        {
            Console.WriteLine("Disponible in the plan");
        }
        else
        {
            Console.WriteLine("Want to be premium?");
        }
    }
}
