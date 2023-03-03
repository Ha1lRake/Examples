Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "русик") 
{
    Console.WriteLine("Ура, это же Русик");
}

else
{
    Console.Write ("Привет,");
    Console.WriteLine(username);   
}
    