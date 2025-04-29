int password = 12345;
// верный пароль
bool a = true;
while (a == true)
{
    int password1 = Convert.ToInt32(Console.ReadLine());
    // запрашивает пароль
    if(password == password1)
    {"Если пороль верный то"
        Console.WriteLine("Пароль принят");
        a = false;"цикл закрывается"
    }
    else
    {"если код не верный то выводится строка (повторите попытку)"
        Console.WriteLine("Повторите попытку");
    }
}
