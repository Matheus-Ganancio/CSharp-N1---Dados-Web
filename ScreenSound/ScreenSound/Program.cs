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



using System.Text.RegularExpressions;

Group slipknot = new Group();
slipknot.Name = "Slipknot";


Album albumSlipknot = new Album();
albumSlipknot.Name = "All Hope Is Gone";

Music music1 = new Music(slipknot);
music1.Name = "Psychosocial";
music1.Type = "Rock";
music1.Length = 302;

Music music2 = new Music(slipknot);
music2.Name = "Dead Memories";
music2.Type = "Rock";
music2.Length = 294;

albumSlipknot.AddMusic(music1);
albumSlipknot.AddMusic(music2);


slipknot.AddAlbum(albumSlipknot);

albumSlipknot.ShowAlbumMusic();
slipknot.Showdiscography();
                          