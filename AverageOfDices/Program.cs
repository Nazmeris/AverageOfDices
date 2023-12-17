using AverageOfDices;

Console.WriteLine("Witamy w programie do zapisywania rzutów kością");
Console.WriteLine("===============================================");
Console.WriteLine();

var playerInFileArray = new PlayerInFile[] {
    new PlayerInFile("Driarith"), 
    new PlayerInFile("Ruta"), 
    new PlayerInFile("Ragval"), 
    new PlayerInFile("Loki") };

var playerInMemoryArray = new PlayerInMemory[] {
    new PlayerInMemory("Driarith"), 
    new PlayerInMemory("Ruta"), 
    new PlayerInMemory("Ragval"), 
    new PlayerInMemory("Loki") };

bool CloseApp = false;

while (!CloseApp)
{
    Console.WriteLine();
    Console.WriteLine(
        "1 - Dodaj kości to pamięci programu i pokaż statystyki\n" +
        "2 - Dodaj kości do pliku tekstowego i pokaż statystyki\n" +
        "Q - Zamknij program i przejdz do podsumowania.\n");

    Console.WriteLine("Co chcesz zrobić?\nWybierz odpowiedni znak 1, 2 lub Q");
    var userInput = Console.ReadLine()!.ToUpper();

    switch (userInput)
    {
        case "1":
            AddDicesToPlayer(playerInMemoryArray);
            break;
        case "2":
            AddDicesToPlayer(playerInFileArray);
            break;
        case "Q":
            CloseApp = true;
            break;
        default:
            Console.WriteLine("Niepoprawna Operacja.\n");
            continue;
    }
}
void AddDicesToPlayer(BasePlayer[] playerArray)
{
    Console.WriteLine("Wybierz gracza któremu chcesz dodać rzuty, żeby zakończyć dodawanie wciśnij q:\n" +
"============\n" +
"Driarith - 1\n" +
"Ruta     - 2\n" +
"Raghval  - 3\n" +
"Loki     - 4\n" +
"============\n");

    while (true)
    {
        Console.WriteLine("Wybierz gracza któremu chcesz dodać rzuty, żeby zakończyć dodawanie wciśnij q:");
        var input = Console.ReadLine()!.ToUpper();
        if (input == "Q")
        {
            break;
        }
        try
        {
            var parsingResult = int.TryParse(input, out var number);
            if (parsingResult == false)
            {
                Console.WriteLine("Podaj liczbę.");
            }
            var arrayLength = playerArray.Length;
            if (number > arrayLength)
            {
                Console.WriteLine("Liczba po za zakresem graczy.");
                continue;
            }
            Console.WriteLine($"Wybrałeś {playerArray[number - 1].Name}, podaj rzut:");
            var diceInput = Console.ReadLine();
            playerArray[number - 1].AddDice(diceInput!);
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"Exception caught, couldn't parse: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception caught: {e.Message}");
        }
    }
}

var statistics1m = playerInMemoryArray[0].GetPlayerStatistics();
var statistics2m = playerInMemoryArray[1].GetPlayerStatistics();
var statistics3m = playerInMemoryArray[2].GetPlayerStatistics();
var statistics4m = playerInMemoryArray[3].GetPlayerStatistics();

var statistics1f = playerInFileArray[0].GetPlayerStatistics();
var statistics2f = playerInFileArray[1].GetPlayerStatistics();
var statistics3f = playerInFileArray[2].GetPlayerStatistics();
var statistics4f = playerInFileArray[3].GetPlayerStatistics();

Console.WriteLine("-------------------------------");

Console.WriteLine("Statystyki rzutów z pamięci:");
Console.WriteLine($"Min: |Driarith:{statistics1m.Min}| |Ruta:{statistics2m.Min}| |Raghval:{statistics3m.Min}| |Loki:{statistics4m.Min}|");
Console.WriteLine($"Max: |Driarith:{statistics1m.Max}| |Ruta:{statistics2m.Max}| |Raghval:{statistics3m.Max}| |Loki:{statistics4m.Max}|");
Console.WriteLine($"Driarith Average:{statistics1m.Average} -> {statistics1m.ThrowAverage} ");
Console.WriteLine($"Ruta     Average:{statistics2m.Average} -> {statistics2m.ThrowAverage} ");
Console.WriteLine($"Raghval  Average:{statistics3m.Average} -> {statistics3m.ThrowAverage} ");
Console.WriteLine($"Loki     Average:{statistics4m.Average} -> {statistics4m.ThrowAverage} ");

Console.WriteLine("-------------------------------");
Console.WriteLine("Statystyki rzutów z Pliku:");
Console.WriteLine("-------------------------------");

Console.WriteLine($"Driarith Average:{statistics1f.Average} -> {statistics1f.ThrowAverage} ");
Console.WriteLine($"Ruta     Average:{statistics2f.Average} -> {statistics2f.ThrowAverage} ");
Console.WriteLine($"Raghval  Average:{statistics3f.Average} -> {statistics3f.ThrowAverage} ");
Console.WriteLine($"Loki     Average:{statistics4f.Average} -> {statistics4f.ThrowAverage} ");

Console.WriteLine("-------------------------------");


Console.WriteLine("\n\nDo zobaczenia następnym razem! Naciśnij dowolny przycisk żeby zamknąć.");
Console.ReadKey();

