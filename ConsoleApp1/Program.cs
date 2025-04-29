int password = 12345;
bool a = true;
while (a == true)
{
    int password1 = Convert.ToInt32(Console.ReadLine());
    if(password == password1)
    {
        Console.WriteLine("Пароль принят");
        a = false;
    }
    else
    {
        Console.WriteLine("Повторите попытку");
    }
}