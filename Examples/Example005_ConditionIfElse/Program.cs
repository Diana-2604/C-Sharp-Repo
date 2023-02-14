Console.WriteLine("Please enter your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "diana")
{
    Console.WriteLine("Hurray, DIANA is here!");
}
else
{
    Console.WriteLine("Hello, ");
    Console.Write(username);
}