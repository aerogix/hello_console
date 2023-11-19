Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
    Console.WriteLine("Hello, Super Maria!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}