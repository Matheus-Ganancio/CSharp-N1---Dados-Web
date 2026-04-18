class Podcast
{
    private List<Episode> episodes = new();
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public string Name { get; }
    public string Host { get; }

    // usado lambda para que o valor total da lista de episodios seja
    // igual a contagem da lista "episodes"
    public int TotalEpisodes => episodes.Count;

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }
    public void ShowDetails()
    {
        Console.WriteLine($"Podcast {Name} presented by {Host} \n");
        // pra cada episodio criado em "AddEpisode" para a lista "episodes"
        // lista derivada de "Episode"
        foreach (Episode episode in episodes.OrderBy(e => e.EpisodeIndex))
        {
            Console.WriteLine(episode.Summary);
        }
        Console.WriteLine($"\n\nThis Podcast have {TotalEpisodes} episodes");
    }
}