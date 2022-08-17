// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя");
string username = Console.ReadLine();
if(username.ToLower() == "1"){
    Console.WriteLine(username);
    Console.WriteLine("да");
} else {
    Console.WriteLine(username);
    Console.WriteLine("нет");
}