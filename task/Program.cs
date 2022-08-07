/*  Написать программу, которая из имеющего массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа.
    Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.При решении не рекомендуется пользоваться коллекциями,
    лучше обойтись исключительно массивами.
*/
Console.Clear();
int count = 0;

void FillArray(string?[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{i + 1} строка: ");
        array[i] = Console.ReadLine();
        if (array[i]!.Length <= 3 && array[i] != " ")
        {
            count++;
        }
    }
    System.Console.WriteLine();
}

char quoteDouble = '"';
void ResultPrintArray(string[] array, string[] matrix)
{

    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i] != " ")
        {
            matrix[index] = quoteDouble + array[i] + quoteDouble;
            index++;
        }

    }
    System.Console.Write("[" + '"' + string.Join('"' + ", " + '"', array) + '"' + "]" + " -> ");
    System.Console.WriteLine("[" + string.Join(", ", matrix) + "]");
}
System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите массив из строк:");
string[] array = new string[size];

FillArray(array);
string[] matrix = new string[count];

ResultPrintArray(array, matrix);