// Richiesta quantità cibi preferiti:

Console.WriteLine("Quanti sono i tuoi cibi preferiti?");
int imputUserNumberFavoriteFoods = int.Parse(Console.ReadLine());

string[] userNumberFavoriteFoods = new string[imputUserNumberFavoriteFoods];

// Inserimento cibi preferiti

    for (int i = 0; i < userNumberFavoriteFoods.Length; i++)
    {
    Console.WriteLine($"Inserisci i tuoi cibi preferiti: {i + 1}");
    userNumberFavoriteFoods[i] = Console.ReadLine();
    }

// Stampa lista cibi utente:

printArray(userNumberFavoriteFoods);

// Stampa mediana lista:

printMedianaArray(userNumberFavoriteFoods);

// Funzioni:

void printArray(string[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.WriteLine((i + 1) + ". " + (array[i]));
    }
}

void printMedianaArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length / 2)
        Console.WriteLine("Posizione mediana: " + array[i]);
    }
}
   
