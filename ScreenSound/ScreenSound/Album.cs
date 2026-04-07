class Album
{
    // puxando as informações de "Music.cs" para esse arquivo para poder
    // usar as informações da musica no album
    private List<Music> musics = new List<Music>();

    public string Name { get; set; }
    public int totalLength => musics.Sum(m => m.Length);


    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowAlbumMusic()
    {
        Console.WriteLine($"Playlist from {Name}: \n");
        foreach (var music in musics)
        {
            Console.WriteLine($"Music: {music.Name}");
            Console.WriteLine($"music.Artist");
            Console.WriteLine($"Type of music: {music.Type}");
            Console.WriteLine($"Music length: {music.Length}");

        }
        Console.WriteLine($"\n To listen this album {totalLength} you " +
            $"need to be a premium user\n");
    }
}