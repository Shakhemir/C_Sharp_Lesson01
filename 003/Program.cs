Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "шах")
{
    Console.WriteLine("Хей хей!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}