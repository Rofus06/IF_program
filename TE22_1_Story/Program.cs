
Console.WriteLine("det finns två väggar att gå och du vet inte vart någon av dom går.");
Thread.Sleep(1000);
Console.WriteLine("det ända du vet är att det finns två sjultar, och det vänstra sjulten står det Radiation.");
Thread.Sleep(1000);
Console.WriteLine("Den till höger står det Land Mines");
Thread.Sleep(1000);
Console.WriteLine("Vilken Väg Tar Du?");
string name = Console.ReadLine().ToLower();

if (name == "vänster" || name == "Vänster")
{
    Console.WriteLine("Då gick till vänter för att du viste att du hade en gas mask i din ryggsäck");
    Thread.Sleep(1000);
    Console.WriteLine("efter 10 min så kom du till två dörrar");
    Thread.Sleep(1000);
    Console.WriteLine("en av dom två dörrarna går rätt men vilken? 1 eller 2?");

    string door = Console.ReadLine();
    if (door == "1" || door == "ett")
    {
        Console.WriteLine("Du gick vänster igen och kom rätt, du vaknade i verkligheten och undrade vad hände?");
    } 
    else if (door == "2" || door == "två")
    {
    Console.WriteLine("Du gick till höger och vacknade i vekligheten som ett spöke");
    Thread.Sleep(1000);
    Console.WriteLine("Du kollade ner och ser din krop ligga där medvetslös");
    Thread.Sleep(1000);
    Console.WriteLine("Du sa, Visste inte att min dröm kom till verklig het, 1 dag senare sa doctorn att du dog av hjärt stop");
    }
    else
    {
        Console.WriteLine("Du tänkte men tog ingen av dörrarna och du försökte gå hem igen men din gas mask gick sönder så du dog av giftet när du gick");
    }
}


else if (name == "höger" || name == "Höger")
{
    Console.WriteLine("Du gick till höger trodde att det var falsk inforamtion 3 sekunder senare dog du have en Land Mine");
}
else
{
    Console.WriteLine("Du tänkte och valde ingen väg och gick tillbaka hem och dushade");
}

Console.ReadLine();