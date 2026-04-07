class Group
{
    private List<Album> albums = new List<Album>();
    public string Name { get; set; }
    
    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void Showdiscography()
    {
        Console.WriteLine($"discography from {Name}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Name} ({album.totalLength})");
        }
    }

}