using AverageOfDices;

Console.WriteLine("Witamy w programie do zapisywania rzutów kością");
Console.WriteLine("===============================================");
Console.WriteLine();

var player1f = new PlayerInFile("Driarith");
var player2f = new PlayerInFile("Ruta");
var player3f = new PlayerInFile("Ragval");
var player4f = new PlayerInFile("Loki");

var player1m = new PlayerInMemory("Driarith");
var player2m = new PlayerInMemory("Ruta");
var player3m = new PlayerInMemory("Ragval");
var player4m = new PlayerInMemory("Loki");

bool CloseApp = false;

while (!CloseApp)
{
    Console.WriteLine();
    Console.WriteLine(
        "1 - Dodaj kości to pamięci programu i pokaż statystyki\n" +
        "2 - Dodaj kości do pliku tekstowego i pokaż statystyki\n" +
        "Q - Zamknij program i przejdz do podsumowania.\n");

    Console.WriteLine("Co chcesz zrobić?\nWybierz odpowiedni znak 1, 2 lub Q");
    var userInput = Console.ReadLine().ToUpper();

    switch (userInput)
    {
        case "1":
            AddDicesToMemory();
            break;
        case "2":
            AddDicesToTxtFile();
            break;
        case "Q":
            CloseApp = true;
            break;
        default:
            Console.WriteLine("Niepoprawna Operacja.\n");
            continue;
    }
}


void AddDicesToMemory()
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
        var input = Console.ReadLine().ToUpper();
        if (input == "Q")
        {
            break;
        }
        try
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine("Wybrałeś Driarith, podaj rzut:");
                    var input1m = Console.ReadLine();
                    player1m.AddDice(input1m);
                    break;
                case "2":
                    Console.WriteLine("Wybrałeś Rute, podaj rzut:");
                    var input2m = Console.ReadLine();
                    player2m.AddDice(input2m);
                    break;
                case "3":
                    Console.WriteLine("Wybrałeś Raghvala, podaj rzut:");
                    var input3m = Console.ReadLine();
                    player3m.AddDice(input3m);
                    break;
                case "4":
                    Console.WriteLine("Wybrałeś Lokiego, podaj rzut:");
                    var input4m = Console.ReadLine();
                    player4m.AddDice(input4m);
                    break;
                default:
                    Console.WriteLine("Invalid Throw.\n");
                    continue;
            }
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"Exception caught, couldn't parse: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
}

void AddDicesToTxtFile()
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
        var input = Console.ReadLine().ToUpper();
        if (input == "Q")
        {
            break;
        }
        try
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine("Wybrałeś Driarith, podaj rzut:");
                    var input1f = Console.ReadLine().ToUpper();
                    player1f.AddDice(input1f);
                    break;
                case "2":
                    Console.WriteLine("Wybrałeś Rute, podaj rzut:");
                    var input2f = Console.ReadLine().ToUpper();
                    player2f.AddDice(input2f);
                    break;
                case "3":
                    Console.WriteLine("Wybrałeś Raghvala, podaj rzut:");
                    var input3f = Console.ReadLine().ToUpper();
                    player3f.AddDice(input3f);
                    break;
                case "4":
                    Console.WriteLine("Wybrałeś Lokiego, podaj rzut:");
                    var input4f = Console.ReadLine().ToUpper();
                    player4f.AddDice(input4f);
                    break;
                default:
                    Console.WriteLine("Invalid Throw.\n");
                    continue;
            }
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"Exception caught, couldn't parse: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
}
var statistics1m = player1m.GetPlayerStatistics();
var statistics2m = player2m.GetPlayerStatistics();
var statistics3m = player3m.GetPlayerStatistics();
var statistics4m = player4m.GetPlayerStatistics();

var statistics1f = player1f.GetPlayerStatistics();
var statistics2f = player2f.GetPlayerStatistics();
var statistics3f = player3f.GetPlayerStatistics();
var statistics4f = player4f.GetPlayerStatistics();

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

