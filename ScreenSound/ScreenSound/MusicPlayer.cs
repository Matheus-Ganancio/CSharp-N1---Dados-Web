public class MusicPlayer
{
    public int Volume { get; set; }
    public int CurrentTrackIndex { get; set; }
    public bool IsPlaying { get; set; }

    public void MusicPlayerInfo()
    {
        Console.WriteLine($"Volume: {Volume}%");
        Console.WriteLine($"Music Number: {CurrentTrackIndex}");
        if(IsPlaying)
        {
            Console.WriteLine("Playing");
        }
        else
        {
            Console.WriteLine("Paused");
        }
    }

}
