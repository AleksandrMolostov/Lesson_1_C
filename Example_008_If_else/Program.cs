Console.WriteLine("Введите имя");
string username = Console.ReadLine();
if (username.ToLower() == "masha")
{
   Console.WriteLine("Cool!"); 
}
else
{
    Console.WriteLine("Hello");
    Console.WriteLine(username);
}