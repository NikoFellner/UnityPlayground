Console.WriteLine("Enter the name of the first Pokemon");
string pok1Name = Console.ReadLine();
Console.WriteLine("You are fighting against Pikachu");
string pok2Name = "Pikachu";


int pok1Hp = 100; 
int pok2Hp = 100;

Random rng = new Random();
int pok1Dmg = 0; 
int pok2Dmg = 0;
#region
string attackChosen;
while (pok1Hp>0 && pok2Hp>0)
{
    Console.WriteLine("Choose your attack\n1) Firestorm\n2) Multi-Tackle");
    attackChosen = Console.ReadLine();
    if (attackChosen == "1")
    {
        pok1Dmg = rng.Next(15, 23);
        pok2Hp -= pok1Dmg;
    }
    else if (attackChosen == "2") 
    { 
        for (int i = 0; i < 4; i++)
        {
            pok1Dmg = rng.Next(6, 11);
            pok1Dmg += pok1Dmg;
        }
        pok2Hp -= pok1Dmg;
    }

    if (rng.Next(0, 101) >= 50)
    {
        Console.WriteLine("Pikachu uses thunderstorm");
        pok2Dmg = rng.Next(20, 30);
        pok1Hp -= pok2Dmg;
    }
    else
    {
        Console.WriteLine("Pikachu uses tackle");
        pok2Dmg = rng.Next(8, 13);
        pok1Hp -= pok2Dmg;
    }
    Console.WriteLine(pok1Name + " attacks " + pok2Name + " and deals " + pok1Dmg + " damage");
    Console.WriteLine(pok2Name + " attacks " + pok1Name + " and deals " + pok2Dmg + " damage");
    if (pok1Hp <= 0 )
    {
        Console.WriteLine(pok2Name + " won!");
        break;
    }
    else if (pok2Hp <= 0 )
    {
        Console.WriteLine(pok1Name + " won!");
        break;
    }

    Console.WriteLine(pok1Name + ": " + pok1Hp);
    Console.WriteLine(pok2Name + ": " + pok2Hp);

}

#endregion