// цикл в цикле(таблицу умножения)

for (int i = 2; i < 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    System.Console.WriteLine();
}

// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а большие «С» заменить на маленькие «с».


string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
    + "ежели бы вас послали вместо нашего милого Винценгероде,"
    + "вы бы взяли приступом согласие прусского короля."
    + "Вы так красноречивы. Вы дадите мне чаю?";

string replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}

string newText = replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();

newText = replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();

newText = replace(newText, 'с', 'С');
System.Console.WriteLine(newText);
System.Console.WriteLine();


//задача с упорядовачиванием массива
int[] arr = { 1, 5, 5, 4, 2, 6, 7, 1, 1 };

void printArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;

            }
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

printArray(arr);
SelectionSort(arr);

printArray(arr);
