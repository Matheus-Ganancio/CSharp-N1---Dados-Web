//// Defining technical specifications for the songs and displaying them in the console.
////  "Music music1 = new Music()" Cria uma variavel adotando o valor
////  (como name, artist, time e disponible da classe "Music" dentro de ScreenSound

//Music music1 = new Music();
//music1.Name = "Before i forget";
//music1.Artist = "Slipknot";
//music1.Length = 244;
//music1.Disponible = true;
//Console.WriteLine(music1.Description);

//Music music2 = new Music();
//music2.Name = "Boulevard of Broken Dreams";
//music2.Artist = "Green Day";
//music2.Length = 262;
//music2.Disponible = false;


//music1.ShowTechinicalsSpecifications();
//music2.ShowTechinicalsSpecifications();



// using System.Text.RegularExpressions;

Group slipknot = new Group("Slipknot");

Album albumSlipknot = new Album("All Hope Is Gone");
// albumSlipknot.Name = "All Hope Is Gone";

Music music1 = new Music(slipknot, "Psychosocial")
{
    Length = 302,
    Disponible = true,
};

MusicPlayer music1_Player = new MusicPlayer()
{
    Volume = 50,
    CurrentTrackIndex = 0,
    IsPlaying = true,
};

// music1.Name = "Psychosocial";
// music1.Type = "Rock";
// music1.Length = 302;

Music music2 = new Music(slipknot, "Dead Memories")
{
    Length = 294,
    Disponible = false,
};
// music2.Name = "Dead Memories";
// music2.Type = "Rock";
// music2.Length = 294;

albumSlipknot.AddMusic(music1);
albumSlipknot.AddMusic(music2);
slipknot.AddAlbum(albumSlipknot);

music1.ShowTechinicalsSpecifications();
music1_Player.MusicPlayerInfo();
music2.ShowTechinicalsSpecifications();
albumSlipknot.ShowAlbumMusic();
slipknot.Showdiscography();

Console.WriteLine("\nPressione qualquer tecla para encerrar...");
Console.ReadKey();
                          