// метод 1

void Method1()
{
    System.Console.WriteLine("Автор Кока");
}
//описали фукцию, которая не возращает ничего и не принимает аргументы. (вывыдит автора)


Method1(); // вызов данного медода

// метод 2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

Method2("Текст сообщения");

// метод 2_1(пример)
void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
Method2_1(msg: "Текс", count: 4); //именнованный аргумент, можно писать не по порядку

// метод 3 
int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
System.Console.WriteLine($"сейчас идёт {Year} год");


//метод 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
System.Console.WriteLine(res);
