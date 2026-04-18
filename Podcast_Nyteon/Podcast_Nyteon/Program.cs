// ordem da descricao sao argumentos baseados na classe, no caso o 
// "EpisodeIndex", "Title" e "Time"
Episode ep1 = new(0, "facilitation techniques", 32);

ep1.AddGuest("Maria");
ep1.AddGuest("Marcelo");

//Console.WriteLine(ep1.Summary);

Episode ep2 = new(1, "learning techniques", 27);

ep2.AddGuest("Fernando");
ep2.AddGuest("Julia");
ep2.AddGuest("Luis");

//Console.WriteLine(ep2.Summary);

Podcast podcast = new("Podcast special", "Matheus");
podcast.AddEpisode(ep1);
podcast.AddEpisode(ep2);
podcast.ShowDetails();