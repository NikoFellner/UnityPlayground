// See https://aka.ms/new-console-template for more information
Console.WriteLine("First Pokemon:");
string firstPokemonName = Console.ReadLine();
Console.WriteLine("Second Pokemon:");
string secondPokemonName = Console.ReadLine();

int hpFirstPokemon = 100;
int hpSecondPokemon = 100;

Random rng = new Random();

int damageFirstPokemon;
int damageSecondPokemon;

Console.WriteLine("Turn 1");

damageFirstPokemon = rng.Next(10,21);
damageSecondPokemon = rng.Next(10,21);

Console.WriteLine(firstPokemonName + " dealt " + damageFirstPokemon + " dmg");
Console.WriteLine(secondPokemonName + " dealt " + damageSecondPokemon + " dmg");

hpFirstPokemon -= damageSecondPokemon;
hpSecondPokemon -= damageFirstPokemon;

Console.WriteLine(firstPokemonName + " has  " + hpFirstPokemon + " HP left");
Console.WriteLine(secondPokemonName + " has " + hpSecondPokemon + " HP left");

Console.WriteLine("Turn 2");

damageFirstPokemon = rng.Next(10, 21);
damageSecondPokemon = rng.Next(10, 21);

Console.WriteLine(firstPokemonName + " dealt " + damageFirstPokemon + " dmg");
Console.WriteLine(secondPokemonName + " dealt " + damageSecondPokemon + " dmg");

hpFirstPokemon -= damageSecondPokemon;
hpSecondPokemon -= damageFirstPokemon;

Console.WriteLine(firstPokemonName + " has  " + hpFirstPokemon + " HP left");
Console.WriteLine(secondPokemonName + " has " + hpSecondPokemon + " HP left");

Console.WriteLine("Turn 3");

damageFirstPokemon = rng.Next(10, 21);
damageSecondPokemon = rng.Next(10, 21);

Console.WriteLine(firstPokemonName + " dealt " + damageFirstPokemon + " dmg");
Console.WriteLine(secondPokemonName + " dealt " + damageSecondPokemon + " dmg");

hpFirstPokemon -= damageSecondPokemon;
hpSecondPokemon -= damageFirstPokemon;

Console.WriteLine(firstPokemonName + " has  " + hpFirstPokemon + " HP left");
Console.WriteLine(secondPokemonName + " has " + hpSecondPokemon + " HP left");