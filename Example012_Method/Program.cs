//Вид 1 "Ничего не принимают и ничего не возвращают"
//void Method1()
//{
//    Console.WriteLine("Автор...");
//}
//Method1();

//Вид2 "Что-то принимают и ничего не возвращают"
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg:"Текст сообщения");


// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст", 4);
// Method21(count: 4,msg: "новый текст");


//Вид3 "Ничего не принимают ,но что то возвращают"
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int Year = Method3();
// Console.WriteLine(Year);


//Вид4 "Что-то принимают и что-то возвращают"
// string Method4(int count, string text)
// {
    
//     string result = String.Empty;
//     for (int i = 0;i < count;i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

//цикл в цикле
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


//Замена текста или символа
// string text = "Я лумаююаыв авыауц ЫУЙЦуй выфвфы";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ','|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'а','А');
// Console.WriteLine(newText);

//упорядочить массив
int[] arr = {1, 2, 3, 1, 2, 4, 5, 6, 7};
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} " );
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition] ) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);

SelectionSort(arr);


PrintArray(arr);