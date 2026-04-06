// Defining technical specifications for the songs and displaying them in the console.
//  "Music music1 = new Music()" Cria uma variavel adotando o valor
//  (como name, artist, time e disponible da classe "Music" dentro de ScreenSound

Music music1 = new Music();
music1.Name = "Before i forget";
music1.Artist = "Slipknot";
music1.Time = 244;
music1.Disponible = true;
Console.WriteLine(music1.Description);

Music music2 = new Music();
music2.Name = "Boulevard of Broken Dreams";
music2.Artist = "Green Day";
music2.Time = 262;
music2.Disponible = false;


music1.ShowTechinicalsSpecifications();
music2.ShowTechinicalsSpecifications();