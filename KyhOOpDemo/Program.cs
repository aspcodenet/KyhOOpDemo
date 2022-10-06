using KyhOOpDemo;


var p = new Person("Stefan", 50); 
p.PlayerPosition = PlayerPositionType.Defence;

var p2 = new Person("Foppa", 50);
p2.PlayerPosition = PlayerPositionType.Forward;

var p3= new Person("Sudden", 50);
p3.PlayerPosition = PlayerPositionType.Forward;

var p4 = new Person("Oliver", 24);
p4.PlayerPosition = PlayerPositionType.Forward;


var l = new List<Person>();
l.Add(p);
l.Add(p2);
l.Add(p3);

foreach (var player in l)
{
    if(player.PlayerPosition == PlayerPositionType.Forward )
        Console.WriteLine($"{player.Name}");
}







var app = new App();
app.Run();