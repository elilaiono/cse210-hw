// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Team firebirds = new Team("Firebirds");
Team pickleball = new Team("Club Pickleball");

Match superbowl = new Match(firebirds, pickleball);

Player john = new Player("John Henderson", 12);
// john.Display();
Player tim = new Player("Tim Nunn", 13);

Player eli = new Player("Elijah Aiono", 24);
Player carter = new Player("Cater Davis", 20);

firebirds.AddPlayer(john);
firebirds.AddPlayer(tim);
firebirds.DisplayRoster();

pickleball.AddPlayer(eli);
pickleball.AddPlayer(carter);
pickleball.DisplayRoster();

superbowl.DecideWin();