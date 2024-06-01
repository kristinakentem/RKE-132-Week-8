String[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Bilbo Baggins", "Scooby-Doo"};
String[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };
String[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "Lego brick" };


string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day");


string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villains} with {villainWeapon} tries to take over the world");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}
