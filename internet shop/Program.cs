




// students, teachers, rooms, lessons



const string FileName = "shop product.txt";
const int MaximumRoomLenght = 25;
const int MaximumNameLenght = 50;
const string FileName2 = "shop.txt";
//const int MaximumRoomLenght2 = 25;
//const int MaximumNameLenght2 = 50;
var quantity = new int[] {};

void ShowallUsers()
{
    Console.WriteLine($"{"Name and Surname",20}"
        + $"{"Year of birth",20}"
        +$"{"Name account",20}");

    var fileContent = File.ReadAllLines(FileName2);

    foreach (var line in fileContent)
    {
        var meetingContent = line.Split(",");

        Console.WriteLine($"{meetingContent[0],20}" +
              $"{meetingContent[1],20}" + 
              $"{meetingContent[2],20}");
    }

    //Console.WriteLine("Press any key to return to menu...");
    Console.ReadLine();
}

void Buyproduct()
{

    Console.WriteLine("Товар который необходим:");
    var fileContent22 = File.ReadAllLines(FileName);
    string a = Console.ReadLine();
    if (fileContent22[1] == a)
    {
        Console.WriteLine("кол-во товара:");
        string tovar = Console.ReadLine();
        quantity[1]--;



    }

    //if ( a == )
    // {

    // }
}


void Regaccount()
{
    int a = 2005;
    Console.WriteLine("Name and Surname: ");
    var NaS = Console.ReadLine();
    Console.WriteLine("Year of birth: ");
    var Yofb = Console.ReadLine();
    
            
    Console.WriteLine("Name account: ");
    var Namacc = Console.ReadLine();


    File.AppendAllText(FileName2, $"{NaS},{Yofb}, {Namacc}" + Environment.NewLine);
}
void ShowallProduct()
{
    Console.WriteLine($"{"Product",20}"
        + $"{"quantity",20}"
        + $"{"Expiration date",20}"
        + $"{"Price",20}");



    var fileContent = File.ReadAllLines(FileName);

    foreach (var line in fileContent)
    {
        var meetingContent = line.Split(",");

        Console.WriteLine($"{meetingContent[0],20}" +
              $"{meetingContent[1],20}" +
              $"{meetingContent[2],20}" +
              $"{meetingContent[3],20}");
    }

    //Console.WriteLine("Press any key to return to menu...");
    Console.ReadLine();
}    
void ShowError(string error)
{
    Console.WriteLine(error);
    Console.ReadLine();
}

void Addproduct() 
{
    Console.WriteLine("Product:");
    //var product = new string[] { };
    var product = Console.ReadLine();


    Console.WriteLine("Quantity: ");
    var quantity = Console.ReadLine();
    
    //int[] quantity  = int.TryParse(out a);



    

    Console.WriteLine("Expiration date: ");
    var expirationdate = Console.ReadLine();
    

    Console.WriteLine("Price: ");
    var price = Console.ReadLine();

    


    File.AppendAllText(FileName, $"{product},{quantity},{expirationdate},{price}" + Environment.NewLine);
}

void Exit()
{
    Environment.Exit(0);
}



void Menu()
{
    Console.Clear();
    Console.WriteLine("6.Show Users");
    Console.WriteLine("5.Buy Product");
    Console.WriteLine("4. Register account");
    Console.WriteLine("3. Show all Product");
    Console.WriteLine("2. Add product");
    Console.WriteLine("1. Exit shop");
}

while (true)
{
    Menu();
    var keyInfo = Console.ReadKey();
    switch (keyInfo.Key)
    {
        case ConsoleKey.D1:
            Exit();
            break;
        case ConsoleKey.D2:
            Addproduct();
            break;
        case ConsoleKey.D3:
            ShowallProduct();
            break;
        case ConsoleKey.D4:
            Regaccount();
            break;
        case ConsoleKey.D5:
            Buyproduct();
            break;
        case ConsoleKey.D6:
            ShowallUsers();
            break;
        default: break;
    }
}


