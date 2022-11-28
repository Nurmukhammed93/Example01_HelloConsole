Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ару")
{
    Console.WriteLine("Ура, это же АРУ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
    }

