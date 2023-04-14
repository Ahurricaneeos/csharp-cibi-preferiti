// Array cibi preferiti:

string[] favoriteFoods = {"Pizza", "Hamburger", "Patatine", "Sushi", "Panna cotta", "Sacher", "Cioccolato"};

// Stampa lunghezza array:

Console.WriteLine("Lunghezza array: " + favoriteFoods.Length);
Console.WriteLine("");

// Stampa elementi array in ordine di preferenza:

Console.WriteLine("Cibi preferiti in ordine dal più al meno preferito: ");
Console.WriteLine("");

for (var i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine($"{i + 1}. {favoriteFoods[i]}");
}
