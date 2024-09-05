
Spelare pl = new Spelare()
{
    Name = "Svean",
    Skada = 2
};
Fiende fiend = new()
{
    Name = "Fiend",
    HitPoints = 2
};

while (true)
{
    Console.WriteLine(fiend.HitPoints);

    Console.ReadLine();
    fiend.HitPoints -= pl.Skada;

    if (fiend.HitPoints < 1)
    {
        break;
    }

}