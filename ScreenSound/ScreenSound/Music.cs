class Music
{
    // Construtor com parametro
    // Construtor nao tem void, nao tem retorno.
    // Construtor tem o nome/tipo
    public Music(Group artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    // metodo de atribuicao get e set.
    // get usa a informacao ja salva
    // set permite escrever uma atribuicao a aquele valor
    public string Name {  get; }
    public Group Artist { get; }
    public int Length { get; set; }
    public bool Disponible {  get; set; }
    public string Type { get; set; }
    public string Description =>
        $"The music {Name} are from {Artist.Name}";



    public void ShowTechinicalsSpecifications()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
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
