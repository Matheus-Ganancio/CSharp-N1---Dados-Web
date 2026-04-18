class Episode
{
    private List<string> guests = new();

    public Episode(int episodeIndex, string title, float time)
    {
        EpisodeIndex = episodeIndex;
        Title = title;
        Time = time;
    }


    public int EpisodeIndex {  get; }
    public string Title { get; }
    public float Time { get; }
    public string Summary => $"{EpisodeIndex}. {Title}. ({Time} min) - " +
        $"{string.Join(", ", guests)}";

    public void AddGuest(string guest)
    {
        guests.Add(guest);
    }
}