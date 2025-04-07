// See https://aka.ms/new-console-template for more information
#region Exercise A
int i = 1;
while (i<16)
{
    Console.WriteLine(i);
    i++;
}

for (int ii=0; ii<16; ii++)
{ 
    Console.WriteLine(ii); 
}
#endregion

#region Exercise B
string input = "";

while (input != "quit")
{ 
    Console.WriteLine("To end type quit");
    input = Console.ReadLine();
}
#endregion

#region Exercise C
int hp = 100;
int dmg;
while (hp > 0)
{
    Console.WriteLine("Player has " + hp + " type numbers to deal dmg");
    dmg = Convert.ToInt32(Console.ReadLine());
    hp -= dmg;
    if (hp <= 0)
    {
        Console.WriteLine("Player died");
    }
}
#endregion