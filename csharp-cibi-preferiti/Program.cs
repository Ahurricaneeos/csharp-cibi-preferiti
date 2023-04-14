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

Console.WriteLine("");

// Stampa prima ed ultima posizione della classifica:

Console.WriteLine($"Il cibo che preferisco di più è: {favoriteFoods[0]}");
Console.WriteLine($"il cibo che preferisco di meno è: {favoriteFoods[6]}");

